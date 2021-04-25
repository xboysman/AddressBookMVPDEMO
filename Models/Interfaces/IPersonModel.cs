using System;

namespace AddressBookMVPDEMO.Models.Interfaces
{
    public interface IPersonModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int CalculateAge();
        public int RemainingDays();
    }
}
