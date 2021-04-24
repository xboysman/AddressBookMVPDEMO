﻿using System;
using System.ComponentModel;
using AddressBookMVPDEMO.Models;

namespace AddressBookMVPDEMO.Views
{
    public interface IPersonView
    {
        string NameText { get; set; }
        DateTime Birthday { get; set; }
    }

    public interface IMainView 
    {
        BindingList<PersonModel> Persons { set; }
        PersonModel SelectedPerson { get; set; }
        DateTime Birthday { set; }
        string TodayDate { set; }
        string NearestBirthday { set; }
        string Age { set;  }
    }
}
