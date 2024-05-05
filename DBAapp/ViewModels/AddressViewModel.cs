using DBAapp.Models;

namespace DBAapp.ViewModels
{
    internal class AddressViewModel : BaseViewModel
    {
        private Address _address;

        public AddressViewModel(string street, int number, string city, string country)
        {
            this.street = street;
            this.number = number;
            this.city = city;
            this.country = country;

            _address = new Address(street, number, city, country);
        }

        public AddressViewModel(Address address)
        {
            _address = address;
        }

        public string street
        {
            get { return _address.street; }
            set
            {
                if (_address.street != value)
                {
                    _address.street = value;
                    OnPropertyChanged(nameof(street));
                }
            }
        }

        public int number
        {
            get { return _address.number; }
            set
            {
                if (_address.number != value)
                {
                    _address.number = value;
                    OnPropertyChanged(nameof(number));
                }
            }
        }

        public string city
        {
            get { return _address.city; }
            set
            {
                if (_address.city != value)
                {
                    _address.city = value;
                    OnPropertyChanged(nameof(city));
                }
            }
        }

        public string country
        {
            get { return _address.country; }
            set
            {
                if (_address.country != value)
                {
                    _address.country = value;
                    OnPropertyChanged(nameof(country));
                }
            }
        }
    }
}
