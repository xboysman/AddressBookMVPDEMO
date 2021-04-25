using System;
using System.ComponentModel;

namespace AddressBookMVPDEMO.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Property & Fields
        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set 
            { 
                birthday = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Birthday)));
            }
        }

        #endregion

        #region Constructor(s)
        public PersonModel(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        #endregion

        #region Methods
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;

            if (today.Date == Birthday.Date)
                return 0;

            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;

            return age;
        }
        public int RemainingDays()
        {
            DateTime nextBirthday = Birthday.AddYears(CalculateAge() + 1);
            TimeSpan differenceBirthday = nextBirthday - DateTime.Today;

            return Convert.ToInt32(differenceBirthday.TotalDays);
        }
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
