using System;
using System.Windows.Forms;
using System.ComponentModel;
using AddressBookMVPDEMO.Properties;
using AddressBookMVPDEMO.Views;
using AddressBookMVPDEMO.Models;
using AddressBookMVPDEMO.Presenters;


namespace AddressBookMVPDEMO
{
    public partial class Form_Main : Form, IMainView
    {
        private PersonPresenter presenter;

        public Form_Main()
        {
            InitializeComponent();
            presenter = new PersonPresenter(this);
            if (presenter.FileExists(presenter.FilePath))
                presenter.LoadXML(presenter.FilePath);
            presenter.UpdateUI();
        }

        #region View Properties

        public PersonModel SelectedPerson
        {
            get => (PersonModel)listBox_ListPersons.SelectedItem;
            set => listBox_ListPersons.SelectedItem = value;
        }
        public BindingList<PersonModel> Persons
        {
            set => listBox_ListPersons.DataSource = value;
        }
        public DateTime Birthday 
        { 
            set 
            {
                if (value == DateTime.MinValue)
                {
                    monthCalendar1.SetDate(DateTime.Today);
                    label_Birthday.Text = string.Empty;
                }
                else
                {
                    monthCalendar1.SetDate(value);
                    label_Birthday.Text = value.ToShortDateString();
                }
            }
        }
        public string TodayDate { set => label_TodayDate.Text = value; }
        public string NearestBirthday { set => label_NearestBirthday.Text = value; }
        public string Age { set => label_Age.Text = value; }

        #endregion

        #region Buttons

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Person addPerson = new Form_Person(presenter);
            addPerson.ShowDialog();
        }
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (this.SelectedPerson != null)
                presenter.RemovePerson(this.SelectedPerson);
        }
        private void button_LoadList_Click(object sender, EventArgs e)
        {
            if (OpenOpenFileDialog() == DialogResult.OK)
                presenter.LoadXML(ofd.FileName);
        }

        #endregion

        #region listBox

        private void listBox_ListPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.SelectedPerson = this.SelectedPerson;
        }
        private void listBox_ListPersons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form_Person editPerson = new Form_Person(presenter);
            editPerson.NameText = this.SelectedPerson.Name;
            editPerson.Birthday = this.SelectedPerson.Birthday;
            editPerson.ShowDialog();
        }

        #endregion

        #region Form

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (presenter.HasChanged && listBox_ListPersons.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Save list of people?", "Save"
                                                       , MessageBoxButtons.YesNoCancel
                                                       , MessageBoxIcon.Question
                                                       , MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                    presenter.SaveToXML(presenter.FilePath);
                else if (dr == DialogResult.No)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

        #endregion

        #region File Dialogs

        private OpenFileDialog ofd;
        private DialogResult OpenOpenFileDialog()
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "XML files(*.xml)|*.xml";
            ofd.InitialDirectory = presenter.SubFolderPath;
            return ofd.ShowDialog();
        }

        #endregion
    }
}
