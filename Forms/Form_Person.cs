using System;
using System.ComponentModel;
using System.Windows.Forms;
using AddressBookMVPDEMO.Models;
using AddressBookMVPDEMO.Presenters;
using AddressBookMVPDEMO.Views;

namespace AddressBookMVPDEMO
{
    public partial class Form_Person : Form, IPersonView
    {
        #region Form
        #region Constructor(s)
        public Form_Person(BindingList<PersonModel> personsmodel)
        {
            InitializeComponent();

            this.presenter = new PersonPresenter(this, personsmodel)
            {
                Person = null
            };
        }
        public Form_Person(BindingList<PersonModel> personsmodel, PersonModel selectedperson)
        {
            InitializeComponent();
            this.presenter = new PersonPresenter(this, personsmodel)
            {
                Person = selectedperson
            };

            this.presenter.UpdateUI();
        }
        #endregion
        private void Form_Person_Shown(object sender, EventArgs e)
        {
            if (this.presenter.Person == null)
                this.Text = "Add New Person";
            else
                this.Text = "Edit Person - " + this.presenter.Person.Name;
        }
        #endregion

        #region Property & Fields
        private readonly PersonPresenter presenter;
        public string NameText 
        {
            get => this.textBox_Name.Text;
            set
            {
                if (presenter.Person != null)
                    this.textBox_Name.Text = presenter.Person.Name;

                this.textBox_Name.Text = value;
            }
        }
        public DateTime Birthday 
        {
            get => this.dateTimePicker_Birthday.Value;
            set
            {
                if (presenter.Person != null)
                    this.dateTimePicker_Birthday.Value = presenter.Person.Birthday;

                this.dateTimePicker_Birthday.Value = value;
            }
        }
        #endregion

        #region Buttons
        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.NameText == string.Empty)
                    throw new ArgumentException("Empty name textfield!");

                if (this.Birthday.Date > DateTime.Today.Date)
                    throw new ArgumentException("Birthday exceeds today's date!");

                if (this.presenter.Person == null)
                    this.presenter.AddPerson(NameText, Birthday);
                else
                    this.presenter.EditPerson(NameText, Birthday);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
