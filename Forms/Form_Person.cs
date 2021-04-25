using System;
using System.Windows.Forms;
using AddressBookMVPDEMO.Presenters;
using AddressBookMVPDEMO.Views;

namespace AddressBookMVPDEMO
{
    public partial class Form_Person : Form, IPersonView
    {
        #region Form
        #region Constructor(s)

        public Form_Person(PersonPresenter presenter)
        {
            InitializeComponent();
            p = presenter;
        }

        #endregion
        private void Form_Person_Shown(object sender, EventArgs e)
        {
            if (this.NameText == string.Empty)
                this.Text = "Add New Person";
            else
                this.Text = "Edit Person - " + p.SelectedPerson.Name;
        }
        #endregion

        #region Property & Fields
        private readonly PersonPresenter p;
        public string NameText 
        {
            get => this.textBox_Name.Text;
            set => this.textBox_Name.Text = value;
        }
        public DateTime Birthday 
        {
            get => this.dateTimePicker_Birthday.Value; 
            set => this.dateTimePicker_Birthday.Value = value; 
        }
        #endregion

        #region Buttons
        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                p.SelectedPerson = p.AddPerson(NameText, Birthday);
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
