using DBAapp.Models;

namespace DBAapp.ViewModels
{
    internal class StreetViewModel : BaseViewModel
    {
        private Streets _streets;

        public StreetViewModel(string street, string city, string country, int abonent_id)
        {
            this.street = street;
            this.city = city;
            this.country = country;
            this.abonent_id = abonent_id;

            _streets = new Streets(street, city, country, abonent_id);
        }

        public StreetViewModel(Streets streets)
        {
            _streets = streets;
        }

        public string street
        {
            get { return _streets.street; }
            set
            {
                if (_streets.street != value)
                {
                    _streets.street = value;
                    OnPropertyChanged(nameof(street));
                }
            }
        }

        public string city
        {
            get { return _streets.city; }
            set
            {
                if (_streets.city != value)
                {
                    _streets.city = value;
                    OnPropertyChanged(nameof(city));
                }
            }
        }

        public string country
        {
            get { return _streets.country; }
            set
            {
                if (_streets.country != value)
                {
                    _streets.country = value;
                    OnPropertyChanged(nameof(country));
                }
            }
        }

        public int abonent_id
        {
            get { return _streets.abonent_id; }
            set
            {
                if (_streets.abonent_id != value)
                {
                    _streets.abonent_id = value;
                    OnPropertyChanged(nameof(abonent_id));
                }
            }
        }

        public Abonent Abonent
        {
            get { return _streets.Abonent; }
            set
            {
                if (_streets.Abonent != value)
                {
                    _streets.Abonent = value;
                    OnPropertyChanged(nameof(Abonent));
                }
            }
        }
    }
}
