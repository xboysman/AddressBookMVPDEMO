using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using AddressBookMVPDEMO.Models.Interfaces;
using AddressBookMVPDEMO.Views;
using AddressBookMVPDEMO.Models;
using System.Xml.Schema;
using System.Xml;

namespace AddressBookMVPDEMO.Presenters
{
    public class PersonPresenter
    {
        #region File/Folder Settings

        private const string subFolderName = "AddressBook";
        private const string fileName = "Friends.xml";
        private static readonly string subFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), subFolderName);
        private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), subFolderName, fileName);

        public string SubFolderName { get => subFolderName; }
        public string FileName { get => fileName; }
        public string SubFolderPath { get => subFolderPath; }
        public string FilePath { get => filePath; }
        #endregion

        #region Property Fields
        private readonly IMainView mainView;
        private BindingList<IPersonModel> personsModel;
        private IPersonModel selectedPerson;

        private BindingList<IPersonModel> PersonsModel
        {
            get => personsModel;
            set
            {
                this.personsModel = value;
                UpdateUI();
            }
        }
        public IPersonModel SelectedPerson
        {
            get => selectedPerson;
            set
            {
                this.selectedPerson = value;
                UpdateUI();
            }
        }
        public bool HasChanged { get; private set; } = false;
        #endregion

        #region Constructor(s)
        public PersonPresenter() { }
        public PersonPresenter(IMainView view)
        {
            this.personsModel = new BindingList<IPersonModel>();
            this.mainView = view;
            this.mainView.Persons = this.personsModel;
        }
        #endregion

        public IPersonModel AddPerson(string name, DateTime birthday)
        {
            if (name == string.Empty)
                throw new ArgumentException("Empty name textfield!");

            if (birthday.Date > DateTime.Today)
                throw new ArgumentException("Birthday exceeds today's date!");

            IPersonModel o = new PersonModel(name, birthday);
            this.personsModel.Add(o);

            HasChanged = true;
            return o;
        }
        public IPersonModel FindClosest()
        {
            IEnumerable<IPersonModel> sortedPersons = this.personsModel.OrderBy(o => o.RemainingDays());
            if (sortedPersons.First().CalculateAge() == -1 && sortedPersons.Count() > 1)
                return sortedPersons.ElementAt(1);

            return sortedPersons.First();
        }
        public void RemovePerson(IPersonModel person)
        {
            this.personsModel.Remove(person);
            this.SelectedPerson = null;

            HasChanged = true;
        }
        public void UpdateUI()
        {
            this.mainView.Persons = this.PersonsModel;
            this.mainView.SelectedPerson = this.SelectedPerson;
            this.mainView.TodayDate = DateTime.Today.ToShortDateString();
            if (this.SelectedPerson != null && this.personsModel.Count > 0)
            {
                this.mainView.Birthday = this.SelectedPerson.Birthday;
                this.mainView.Age = this.SelectedPerson.CalculateAge().ToString();
                this.mainView.NearestBirthday = string.Format("{0} ({1} y.o.) in {2} days"
                                                                , this.FindClosest().Name
                                                                , this.FindClosest().CalculateAge()
                                                                , this.FindClosest().RemainingDays());
            }
            else
            {
                this.mainView.Birthday = DateTime.MinValue;
                this.mainView.NearestBirthday = string.Empty;
                this.mainView.Age = string.Empty;
            }
        }
        public void SaveToXML(string pathfilename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(IPersonModel));
            using (FileStream fStream = File.Create(pathfilename))
                serializer.Serialize(fStream, PersonsModel);
        }
        public void LoadXML(string pathfilename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(IPersonModel));
            using (FileStream fStream = File.OpenRead(pathfilename))
                PersonsModel = (BindingList<IPersonModel>)serializer.Deserialize(fStream);

            HasChanged = false;
        }
        public bool FileExists()
        {
            return File.Exists(filePath);
        }
        public bool FileExists(string filename)
        {
            return File.Exists(filename);
        }
    }
}
