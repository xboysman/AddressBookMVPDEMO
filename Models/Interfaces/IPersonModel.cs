using System;
using System.Runtime.Serialization;

namespace AddressBookMVPDEMO.Models.Interfaces
{
    public interface IPersonModel : ISerializable
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public IPersonModel CreateNewPerson(string name, DateTime birthday);
        public int CalculateAge();
        public int RemainingDays();
    }
}
