using System;
using System.Runtime.Serialization;
using AddressBookMVPDEMO.Models.Interfaces;

namespace AddressBookMVPDEMO.Models
{
    [Serializable()]
    public class PersonModel : IPersonModel
    {
        #region Property Fields
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        #endregion

        #region Constructor(s)
        public PersonModel() { }
        public PersonModel(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
        public PersonModel(SerializationInfo info, StreamingContext context)
        {
            this.Name = (string)info.GetValue("Name", typeof(string));
            this.Birthday = (DateTime)info.GetValue("Birthday", typeof(DateTime));
        }
        #endregion

        public IPersonModel CreateNewPerson(string name, DateTime birthday)
        {
            PersonModel person = new PersonModel(name, birthday);
            return person;
        }
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
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
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Jmeno", this.Name);
            info.AddValue("Narozeniny", this.Birthday);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
