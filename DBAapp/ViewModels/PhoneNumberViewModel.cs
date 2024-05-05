using DBAapp.Models;

namespace DBAapp.ViewModels
{
    internal class PhoneNumberViewModel : BaseViewModel
    {
        private PhoneNumber _PhoneNumber;

        public PhoneNumberViewModel(string home_phone_number, string work_phone_number, string mobile_phone_number)
        {
            this.home_phone_number = home_phone_number;
            this.work_phone_number = work_phone_number;
            this.mobile_phone_number = mobile_phone_number;

            _PhoneNumber = new PhoneNumber(home_phone_number, work_phone_number, mobile_phone_number);
        }

        public PhoneNumberViewModel(PhoneNumber phoneNumber)
        {
            _PhoneNumber = phoneNumber;
        }

        public string home_phone_number
        {
            get { return _PhoneNumber.home_phone_number; }
            set
            {
                if (_PhoneNumber.home_phone_number != value)
                {
                    _PhoneNumber.home_phone_number = value;
                    OnPropertyChanged(nameof(home_phone_number));
                }
            }
        }

        public string work_phone_number
        {
            get { return _PhoneNumber.work_phone_number; }
            set
            {
                if (_PhoneNumber.work_phone_number != value)
                {
                    _PhoneNumber.work_phone_number = value;
                    OnPropertyChanged(nameof(work_phone_number));
                }
            }
        }

        public string mobile_phone_number
        {
            get { return _PhoneNumber.mobile_phone_number; }
            set
            {
                if (_PhoneNumber.mobile_phone_number != value)
                {
                    _PhoneNumber.mobile_phone_number = value;
                    OnPropertyChanged(nameof(mobile_phone_number));
                }
            }
        }
    }
}
