using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedorovAD___Pz5
{
    public class Client
    {
        /// <summary>
        /// Имя клиента
        /// </summary>
        private readonly string Name;
        /// <summary>
        /// Возраст клиента
        /// </summary>
        private readonly int Age;
        /// <summary>
        /// Пол клиента
        /// </summary>
        private readonly char Gender;
        /// <summary>
        /// Страна проживания клиента
        /// </summary>
        private readonly string Country;
        /// <summary>
        /// Город проживания клиента
        /// </summary>
        private readonly string City;

        /// <summary>
        /// Конструктор класса Client
        /// </summary>
        /// <param name="CName">Имя клиента</param>
        /// <param name="CAge">Возраст клиента</param>
        /// <param name="CGender">Пол клиента</param>
        /// <param name="CCountry">Страна клиента</param>
        /// <param name="CCity">Город клиента</param>
        public Client(string CName, int CAge, char CGender, string CCountry, string CCity)
        {
            Name = CName;
            Age = CAge;
            Gender = CGender;
            Country = CCountry;
            City = CCity;
        }

        /// <summary>
        /// Выводит всю информацию о клиенте в консоль
        /// </summary>
        public void GetFullInfo()
        {
            Console.WriteLine($"Name={Name} Age={Age} Gender={Gender} Country={Country} City={City}");
        }

        /// <summary>
        /// Возращает имя клиента
        /// </summary>
        public string GetName()
        {
            return Name;
        }
        /// <summary>
        /// Возращает возраст клиента
        /// </summary>
        public int GetAge()
        {
            return Age;
        }
        /// <summary>
        /// Возращает пол клиента
        /// </summary>
        public char GetGender()
        {
            return Gender;
        }
        /// <summary>
        /// Возращает страну клиента
        /// </summary>
        public string GetCountry()
        {
            return Country;
        }

        /// <summary>
        /// Возращает город клиента
        /// </summary>
        public string GetCity()
        {
            return City;
        }
    }
}
