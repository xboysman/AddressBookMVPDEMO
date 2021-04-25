using System;

namespace AddressBookMVPDEMO.Models
{
    public class PersonModel
    {
        #region Property & Fields
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
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
