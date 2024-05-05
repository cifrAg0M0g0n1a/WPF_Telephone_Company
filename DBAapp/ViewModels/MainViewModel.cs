using DBAapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DBAapp.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private DataAccess dataAccess = new DataAccess();

        private List<AbonentViewModel> _abonents;
        private List<object> _streets;

        public List<AbonentViewModel> Abonents
        {
            get { return _abonents; }
            set
            {
                _abonents = value;
                OnPropertyChanged(nameof(Abonents));
            }
        }
        public List<object> Streets
        {
            get { return _streets; }
            set
            {
                _streets = value;
                OnPropertyChanged(nameof(Streets));
            }
        }

        public List<AbonentViewModel> GetMainData()
        {
            Abonents = new List<AbonentViewModel>(dataAccess.GetMainData());

            return Abonents;
        }

        public List<AbonentViewModel> GetMainDataByPhone(string phoneNumber)
        {
            Abonents = new List<AbonentViewModel>(dataAccess.GetAbonentsByPhone(phoneNumber));

            return Abonents;
        }

        public List<object> GetStreets()
        {
            Streets = new List<object>(dataAccess.GetStreets());

            return Streets;
        }
    }
}