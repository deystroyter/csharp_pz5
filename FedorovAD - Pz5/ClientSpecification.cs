using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedorovAD___Pz5
{
    /// <summary>
    /// Класс спецификация для страны
    /// </summary>
    public class CountrySpecification : CompositeSpecification<Client>
        {
            /// <summary>
            /// Страна проживания клиента
            /// </summary>
            private readonly string _country;

            /// <summary>
            /// Конструктор класса спецификации для страны клиента
            /// </summary>
            /// <param name="country">Искомая страна</param>
            public CountrySpecification(string country)
            {
                _country = country;
            }

            /// <summary>
            /// Реализация главного булевого метода
            /// </summary>
            /// <param name="client">Клиент</param>
            /// <returns>Совпадает ли у клиента страна с искомой</returns>
            public override bool IsSatisfiedBy(Client client)
            {
                return client.GetCountry().Equals(_country);
            }
        }

    /// <summary>
    /// Класс спецификация для города
    /// </summary>
    public class CitySpecification : CompositeSpecification<Client>
        {
            /// <summary>
            /// Город проживания клиента
            /// </summary>
            private readonly string _city;

            /// <summary>
            /// Конструктор класса спецификации для города клиента
            /// </summary>
            /// <param name="city">Искомый город</param>
            public CitySpecification(string city)
            {
                _city = city;
            }

            /// <summary>
            /// Реализация главного булевого метода
            /// </summary>
            /// <param name="client">Клиент</param>
            /// <returns>Совпадает ли у клиента город с искомым</returns>
            public override bool IsSatisfiedBy(Client client)
            {
                return client.GetCity().Equals(_city);
            }
        }

    /// <summary>
    /// Класс спецификация для пола
    /// </summary>
    public class GenderSpecification : CompositeSpecification<Client>
    {
        /// <summary>
        /// Пол клиента
        /// </summary>
        private readonly char _gender;

        /// <summary>
        /// Конструктор класса спецификации для пола клиента
        /// </summary>
        /// <param name="gender">Искомый пол</param>
        public GenderSpecification(char gender)
        {
            _gender = gender;
        }

        /// <summary>
        /// Реализация главного булевого метода
        /// </summary>
        /// <param name="client">Клиент</param>
        /// <returns>Совпадает ли у клиента пол с искомым</returns>
        public override bool IsSatisfiedBy(Client client)
        {
            return client.GetGender().Equals(_gender);
        }
    }


}
