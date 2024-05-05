using System;

namespace DBAapp.Models
{
    /* МОДЕЛЬ ТАБЛИЦЫ БАЗЫ ДАННЫХ Abonent */
    internal class Abonent
    {
        public int abonent_id {  get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string patronymic { get; set; }
        public string email { get; set; }
        public int phone_number_id { get; set; }
        public int address_id { get; set; }

        public PhoneNumber PhoneNumber { get; set; }
        public Address Address { get; set; } 

        public Abonent() { }

        public Abonent(string last_name, string first_name, string patronymic, string email, int phone_number_id, int address_id)
        {
            this.last_name = last_name;
            this.first_name = first_name;
            this.patronymic = patronymic;
            this.email = email;
            this.phone_number_id = phone_number_id;
            this.address_id = address_id;
        }
    }
}
