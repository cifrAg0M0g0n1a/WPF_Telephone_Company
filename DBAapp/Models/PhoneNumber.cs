using System;

namespace DBAapp.Models
{
    /* МОДЕЛЬ ТАБЛИЦЫ БАЗЫ ДАННЫХ PhoneNumber */
    internal class PhoneNumber
    {
        public int phone_number_id {  get; set; }
        public string home_phone_number {  get; set; }
        public string work_phone_number {  get; set; }
        public string mobile_phone_number {  get; set; }

        public PhoneNumber() { }

        public PhoneNumber(string home_phone_number, string work_phone_number, string mobile_phone_number)
        {
            this.home_phone_number = home_phone_number;
            this.work_phone_number = work_phone_number;
            this.mobile_phone_number = mobile_phone_number;
        }
    }
}
