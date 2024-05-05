using System;

namespace DBAapp.Models
{
    /* МОДЕЛЬ ТАБЛИЦЫ БАЗЫ ДАННЫХ Streets */
    internal class Streets
    {
        public int street_id {  get; set; }
        public string street {  get; set; }
        public string city {  get; set; }
        public string country {  get; set; }
        public int abonent_id {  get; set; }

        public Abonent Abonent { get; set; }

        public Streets() { }

        public Streets(string street, string city, string country, int abonent_id)
        {
            this.street = street;
            this.city = city;
            this.country = country;
            this.abonent_id = abonent_id;
        }
    }
}
