using System;

namespace DBAapp.Models
{
    /* КЛАСС-КОНТЕЙНЕР ЗАПРОСОВ */
    internal class Queries
    {
        public static string GetMainData() // получение запроса для вывода информации на главный экран
        {
            return "Select " +
                "a.[abonent_id], a.[last_name], a.[first_name], a.[patronymic], " +
                "ad.[address_id], ad.[street], ad.[number], " +
                "p.[phone_number_id], p.[home_phone_number], p.[work_phone_number], p.[mobile_phone_number] " +
                "from Abonent a " +
                "inner join Address ad on a.[address_id] = ad.[address_id] " +
                "inner join PhoneNumber p on a.[phone_number_id] = p.[phone_number_id]";
        }

        public static string GetStreets()
        {
            return "Select " +
                "street_id, country, city, street, " +
                "a.abonent_id, count(a.abonent_id) as 'AbonentCount' " +
                "from Streets s " +
                "inner join Abonent a on a.abonent_id = s.abonent_id " +
                "group by street, country, city";
        }

        public static string GetAbonentsByPhone()
        {
            return "Select " +
                "a.[abonent_id], a.[last_name], a.[first_name], a.[patronymic], " +
                "ad.[address_id], ad.[street], ad.[number], " +
                "p.[phone_number_id], p.[home_phone_number], p.[work_phone_number], p.[mobile_phone_number] " +
                "from Abonent a " +
                "inner join Address ad on a.[address_id] = ad.[address_id] " +
                "inner join PhoneNumber p on a.[phone_number_id] = p.[phone_number_id] " +
                $@"where p.[home_phone_number] = @phoneNumber or p.[work_phone_number] = @phoneNumber or p.[mobile_phone_number] = @phoneNumber";
        }
    }
}
