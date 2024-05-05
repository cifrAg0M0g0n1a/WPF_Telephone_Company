using DBAapp.Models;

namespace DBAapp.ViewModels
{
    internal class AbonentViewModel : BaseViewModel
    {
        private Abonent _abonent;

        public AbonentViewModel(string last_name, string first_name, string patronymic, string email, int phone_number_id, int address_id)
        {
            this.last_name = last_name;
            this.first_name = first_name;
            this.patronymic = patronymic;
            this.email = email;
            this.phone_number_id = phone_number_id;
            this.address_id = address_id;

            _abonent = new Abonent(last_name, first_name, patronymic, email, phone_number_id, address_id);
        }

        public AbonentViewModel(Abonent abonent)
        {
            _abonent = abonent;
        }

        public string last_name
        {
            get { return _abonent.last_name; }
            set
            {
                if (_abonent.last_name != value)
                {
                    _abonent.last_name = value;
                    OnPropertyChanged(nameof(last_name));
                }
            }
        }

        public string first_name
        {
            get { return _abonent.first_name; }
            set
            {
                if (_abonent.first_name != value)
                {
                    _abonent.first_name = value;
                    OnPropertyChanged(nameof(first_name));
                }
            }
        }

        public string patronymic
        {
            get { return _abonent.patronymic; }
            set
            {
                if (_abonent.patronymic != value)
                {
                    _abonent.patronymic = value;
                    OnPropertyChanged(nameof(patronymic));
                }
            }
        }

        public string email
        {
            get { return _abonent.email; }
            set
            {
                if (_abonent.email != value)
                {
                    _abonent.email = value;
                    OnPropertyChanged(nameof(email));
                }
            }
        }

        public int phone_number_id
        {
            get { return _abonent.phone_number_id; }
            set
            {
                if (_abonent.phone_number_id != value)
                {
                    _abonent.phone_number_id = value;
                    OnPropertyChanged(nameof(phone_number_id));
                }
            }
        }

        public int address_id
        {
            get { return _abonent.address_id; }
            set
            {
                if (_abonent.address_id != value)
                {
                    _abonent.address_id = value;
                    OnPropertyChanged(nameof(address_id));
                }
            }
        }

        public Address Address
        {
            get { return _abonent.Address; }
            set
            {
                if (_abonent.Address != value)
                {
                    _abonent.Address = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        public PhoneNumber PhoneNumber
        {
            get { return _abonent.PhoneNumber; }
            set
            {
                if (_abonent.PhoneNumber != value)
                {
                    _abonent.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }
    }
}