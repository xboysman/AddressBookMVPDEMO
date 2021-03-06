using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using AddressBookMVPDEMO.Views;
using AddressBookMVPDEMO.Models;

namespace AddressBookMVPDEMO.Presenters
{
    public class MainPresenter 
    {
        #region File/Folder Settings
        private const string subFolderName = "AddressBook";
        private const string fileName = "Persons.txt";
        private static readonly string subFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), subFolderName);
        private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), subFolderName, fileName);

        public string SubFolderName { get => subFolderName; }
        public string FileName { get => fileName; }
        public string SubFolderPath { get => subFolderPath; }
        public string FilePath { get => filePath; }
        #endregion

        #region Properties & Fields
        private readonly IMainView mainView;
        private BindingList<PersonModel> personsModel;
        private PersonModel selectedPerson;
        private bool preparing;

        private BindingList<PersonModel> PersonsModel
        {
            get => this.personsModel;
            set => this.personsModel = value;
        }
        public PersonModel SelectedPerson
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
        public MainPresenter(IMainView view)
        {
            this.personsModel = new BindingList<PersonModel>();
            this.personsModel.ListChanged += PersonsModel_ListChanged;
            this.mainView = view;
            this.mainView.Persons = this.personsModel;
        }
        #endregion

        #region Methods
        public PersonModel FindNearest()
        {
            if (this.personsModel.Count <= 0)
                return null;

            if (this.personsModel.Count == 1)
                return personsModel[0];

            IEnumerable<PersonModel> sortedPersons = this.personsModel.OrderBy(o => o.RemainingDays());
            return NearestPositiveAge(sortedPersons, 0);
        }
        private PersonModel NearestPositiveAge(IEnumerable<PersonModel> sortedpersons, int index)
        {
            if (sortedpersons.ElementAt(index).CalculateAge() == -1 && sortedpersons.Count() > 1)
                return NearestPositiveAge(sortedpersons, ++index);

            return sortedpersons.ElementAt(index);
        }
        public void RemovePerson(PersonModel person)
        {
            this.personsModel.Remove(person);
            this.SelectedPerson = null;
        }
        public void UpdateUI()
        {
            this.mainView.Persons = this.PersonsModel;
            this.mainView.SelectedPerson = this.SelectedPerson;
            this.mainView.TodayDate = DateTime.Today.ToShortDateString();

            PersonModel nearestPerson = this.FindNearest();
            if (nearestPerson != null)
            {
                this.mainView.NearestBirthday = string.Format("{0} ({1} y.o.) in {2} days"
                                                            , nearestPerson.Name
                                                            , nearestPerson.CalculateAge()
                                                            , nearestPerson.RemainingDays());
            }
            else
                this.mainView.NearestBirthday = string.Empty;

            if (this.SelectedPerson != null && this.personsModel.Count > 0)
            {
                this.mainView.Birthday = this.SelectedPerson.Birthday;
                this.mainView.Age = this.SelectedPerson.CalculateAge().ToString();   
            }
            else
            {
                this.mainView.Birthday = DateTime.MinValue;
                this.mainView.Age = string.Empty;
            }
        }
        public void SaveToTxt(string pathfilename)
        {
            try
            {
                List<string> tempListOfPersons = new List<string>();
                foreach (var person in PersonsModel)
                    tempListOfPersons.Add(string.Format("{0};{1}", person.Name, person.Birthday.ToShortDateString()));

                File.WriteAllLines(pathfilename, tempListOfPersons);
            }
            catch (Exception exp)
            {
                throw new Exception("Unable to save!", exp);
            }
            
        }
        public void LoadTxt(string pathfilename)
        {
            this.preparing = true;
            try
            {
                string[] tempLinesOfTextFile = File.ReadAllLines(pathfilename);
                foreach (string line in tempLinesOfTextFile)
                {
                    string[] tempLine = line.Split(';');

                    PersonsModel.Add(new PersonModel(tempLine[0], Convert.ToDateTime(tempLine[1])));
                }
            }
            catch (Exception exp)
            {
                throw new Exception("Unable to load!", exp);
            }
            finally
            {
                this.preparing = false;
            }
        }
        private void PersonsModel_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (!this.preparing)
            {
                UpdateUI();
                HasChanged = true;
            }
        }
        public bool FileExists()
        {
            return File.Exists(filePath);
        }
        public bool FileExists(string filename)
        {
            return File.Exists(filename);
        }
        #endregion
    }

    public class PersonPresenter
    {
        #region Properties & Fields
        private readonly IPersonView personView;
        private readonly BindingList<PersonModel> personsModel;

        public PersonModel Person { get; set; }
        #endregion

        #region Constructor(s)
        public PersonPresenter(IPersonView view, BindingList<PersonModel> personsmodel)
        {
            this.personsModel = personsmodel;
            this.personView = view;
        }
        #endregion

        #region Methods
        public void AddPerson(string name, DateTime birthday)
        {
            PersonModel newPerson = new PersonModel(name, birthday);
            this.personsModel.Add(newPerson);
        }
        public void EditPerson(string nameText, DateTime birthday)
        {
            this.Person.Name = nameText;
            this.Person.Birthday = birthday;
        }
        public void UpdateUI()
        {
            if (this.Person != null)
            {
                this.personView.NameText = this.Person.Name;
                this.personView.Birthday = this.Person.Birthday;
            }
        }
        #endregion
    }
}
