using System;

namespace DBAapp.Models
{
    /* МОДЕЛЬ ТАБЛИЦЫ БАЗЫ ДАННЫХ Address */
    internal class Address
    {
        public int address_id {  get; set; }
        public string street {  get; set; }
        public int number {  get; set; }
        public string city {  get; set; }
        public string country {  get; set; }

        public Address() { }

        public Address(string street, int number, string city, string country)
        {
            this.street = street;
            this.number = number;
            this.city = city;
            this.country = country;
        }
    }
}
