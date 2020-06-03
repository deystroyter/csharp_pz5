using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedorovAD___Pz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client[] clients =
{
                new Client("Andrey", 20, 'M', "Russia", "Smolensk"),
                new Client("Ksenia", 20, 'W', "Russia", "Bryansk"),
                new Client("Danyus", 23, 'M', "Russia", "Saint-Petersburg"),
                new Client("Ivan", 45, 'M', "Russia", "Saint-Petersburg"),
                new Client("John", 33, 'M', "USA", "Washington"),
                new Client("Kate", 27, 'W', "Germany", "Hamburg"),
                new Client("Boris", 22, 'M', "Ukraine", "Dorogobuzh"),
                new Client("Gennadiy", 44, 'M', "Russia", "Dorogobuzh"),
                new Client("John", 33, 'M', "USA", "Washington"),
                new Client("Bill", 62, 'M', "Canada", "Toronto"),
            };



            ISpecification<Client> Russia_Spec = new CountrySpecification("Russia");
            Console.WriteLine("Клиенты со страной Russia:");
            PrintResult(Russia_Spec, clients);

            ISpecification<Client> Dorogobuzh_Spec = new CitySpecification("Dorogobuzh");
            Console.WriteLine("Клиенты с городом Dorogobuzh:");
            PrintResult(Dorogobuzh_Spec, clients);

            var Women_Or_Ukraine_Spec = new GenderSpecification('W').Or(new CountrySpecification("Ukraine"));
            Console.WriteLine("Клиенты женского пола или из Украины:");
            PrintResult(Women_Or_Ukraine_Spec, clients);

            var Women_And_Russia_Spec = new GenderSpecification('W').And(new CountrySpecification("Russia"));
            Console.WriteLine("Клиенты женского пола из России:");
            PrintResult(Women_And_Russia_Spec, clients);

            var NotRussia_Spec = new CountrySpecification("Russia").Not();
            Console.WriteLine("Клиенты не из России: ");
            PrintResult(NotRussia_Spec, clients);

            var Men_And_NotRussia_Spec = new GenderSpecification('M').And(NotRussia_Spec);
            Console.WriteLine("Клиенты мужского пола не из России: ");
            PrintResult(Men_And_NotRussia_Spec, clients);

            Console.ReadLine();
        }

        private static void PrintResult(ISpecification<Client> spec, IEnumerable<Client> clients)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (var client in clients)
                if (spec.IsSatisfiedBy(client))
                    client.GetFullInfo();
            Console.WriteLine();
        }
    }
}
