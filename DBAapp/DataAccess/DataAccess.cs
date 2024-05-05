using System.Collections.Generic;
using System.Linq;
using DBAapp.Models;
using System.Data;
using System.Data.SQLite;
using Dapper;
using DBAapp.ViewModels;

namespace DBAapp
{
    /* КЛАСС-АКСЕССОР ДАННЫХ */
    internal class DataAccess
    {
        // Dapper-запрос к бд для вывода информации на главное окно
        public List<AbonentViewModel> GetMainData()
        {
            using (IDbConnection connection = new SQLiteConnection(ApplicationContext.Connection()))
            {
                var query = connection.Query<Abonent, Address, PhoneNumber, AbonentViewModel>(
                    Queries.GetMainData(),
                    (a, ad, p) => { a.Address = ad; a.PhoneNumber = p; return new AbonentViewModel(a); },
                    splitOn: "address_id, phone_number_id");

                return query.ToList();
            }
        }

        // Dapper-запрос к бд для вывода информации на окно 'Улицы'
        public List<object> GetStreets()
        {
            using (IDbConnection connection = new SQLiteConnection(ApplicationContext.Connection()))
            {
                return connection.Query(Queries.GetStreets())
                .Select(x => new
                {
                    country = x.country,
                    city = x.city,
                    street = x.street,
                    AbonentCount = x.AbonentCount
                })
                .ToList<object>();
            }
        }

        // Dapper-запрос к бд для вывода найденной информации на главное окно
        public List<AbonentViewModel> GetAbonentsByPhone(string PhoneNumber)
        {
            using (IDbConnection connection = new SQLiteConnection(ApplicationContext.Connection()))
            {
                var query = connection.Query<Abonent, Address, PhoneNumber, AbonentViewModel>(
                    Queries.GetAbonentsByPhone(),
                    (a, ad, p) => { a.Address = ad; a.PhoneNumber = p; return new AbonentViewModel(a); },
                    new { phoneNumber = PhoneNumber },
                    splitOn: "address_id, phone_number_id");

                return query.ToList();
            }
        }
    }
}