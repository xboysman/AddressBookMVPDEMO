
namespace AddressBookMVPDEMO
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_Today = new System.Windows.Forms.Label();
            this.lbl_NearestBirthday = new System.Windows.Forms.Label();
            this.label_TodayDate = new System.Windows.Forms.Label();
            this.label_NearestBirthday = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.listBox_ListPersons = new System.Windows.Forms.ListBox();
            this.button_LoadList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(264, 118);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            // 
            // lbl_Today
            // 
            this.lbl_Today.AutoSize = true;
            this.lbl_Today.Location = new System.Drawing.Point(12, 9);
            this.lbl_Today.Name = "lbl_Today";
            this.lbl_Today.Size = new System.Drawing.Size(38, 15);
            this.lbl_Today.TabIndex = 1;
            this.lbl_Today.Text = "Today";
            // 
            // lbl_NearestBirthday
            // 
            this.lbl_NearestBirthday.AutoSize = true;
            this.lbl_NearestBirthday.Location = new System.Drawing.Point(12, 38);
            this.lbl_NearestBirthday.Name = "lbl_NearestBirthday";
            this.lbl_NearestBirthday.Size = new System.Drawing.Size(97, 15);
            this.lbl_NearestBirthday.TabIndex = 2;
            this.lbl_NearestBirthday.Text = "Nearest Birthday:";
            // 
            // label_TodayDate
            // 
            this.label_TodayDate.AutoSize = true;
            this.label_TodayDate.Location = new System.Drawing.Point(133, 9);
            this.label_TodayDate.Name = "label_TodayDate";
            this.label_TodayDate.Size = new System.Drawing.Size(73, 15);
            this.label_TodayDate.TabIndex = 3;
            this.label_TodayDate.Text = "Today\'s Date";
            // 
            // label_NearestBirthday
            // 
            this.label_NearestBirthday.AutoSize = true;
            this.label_NearestBirthday.Location = new System.Drawing.Point(133, 38);
            this.label_NearestBirthday.Name = "label_NearestBirthday";
            this.label_NearestBirthday.Size = new System.Drawing.Size(105, 15);
            this.label_NearestBirthday.TabIndex = 5;
            this.label_NearestBirthday.Text = "(Name) in (X) days";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Location = new System.Drawing.Point(264, 69);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(51, 15);
            this.lbl_Birthday.TabIndex = 7;
            this.lbl_Birthday.Text = "Birthday";
            // 
            // lbl_Age
            // 
            this.lbl_Age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(264, 94);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(28, 15);
            this.lbl_Age.TabIndex = 6;
            this.lbl_Age.Text = "Age";
            // 
            // label_Birthday
            // 
            this.label_Birthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(331, 69);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(51, 15);
            this.label_Birthday.TabIndex = 8;
            this.label_Birthday.Text = "Birthday";
            // 
            // label_Age
            // 
            this.label_Age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(331, 94);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(75, 15);
            this.label_Age.TabIndex = 9;
            this.label_Age.Text = "Age Number";
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Add.AutoSize = true;
            this.button_Add.Image = ((System.Drawing.Image)(resources.GetObject("button_Add.Image")));
            this.button_Add.Location = new System.Drawing.Point(12, 289);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(115, 40);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Remove.AutoSize = true;
            this.button_Remove.Image = ((System.Drawing.Image)(resources.GetObject("button_Remove.Image")));
            this.button_Remove.Location = new System.Drawing.Point(133, 289);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(115, 40);
            this.button_Remove.TabIndex = 11;
            this.button_Remove.Text = "Remove";
            this.button_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // listBox_ListPersons
            // 
            this.listBox_ListPersons.AllowDrop = true;
            this.listBox_ListPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ListPersons.FormattingEnabled = true;
            this.listBox_ListPersons.ItemHeight = 15;
            this.listBox_ListPersons.Location = new System.Drawing.Point(12, 69);
            this.listBox_ListPersons.Name = "listBox_ListPersons";
            this.listBox_ListPersons.Size = new System.Drawing.Size(236, 214);
            this.listBox_ListPersons.TabIndex = 12;
            this.listBox_ListPersons.SelectedIndexChanged += new System.EventHandler(this.listBox_ListPersons_SelectedIndexChanged);
            this.listBox_ListPersons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_ListPersons_MouseDoubleClick);
            // 
            // button_LoadList
            // 
            this.button_LoadList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LoadList.Location = new System.Drawing.Point(264, 289);
            this.button_LoadList.Name = "button_LoadList";
            this.button_LoadList.Size = new System.Drawing.Size(150, 40);
            this.button_LoadList.TabIndex = 13;
            this.button_LoadList.Text = "Load List";
            this.button_LoadList.UseVisualStyleBackColor = true;
            this.button_LoadList.Click += new System.EventHandler(this.button_LoadList_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 341);
            this.Controls.Add(this.button_LoadList);
            this.Controls.Add(this.listBox_ListPersons);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.label_Birthday);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.label_NearestBirthday);
            this.Controls.Add(this.label_TodayDate);
            this.Controls.Add(this.lbl_NearestBirthday);
            this.Controls.Add(this.lbl_Today);
            this.Controls.Add(this.monthCalendar1);
            this.MinimumSize = new System.Drawing.Size(465, 380);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontakty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_Today;
        private System.Windows.Forms.Label lbl_NearestBirthday;
        private System.Windows.Forms.Label label_TodayDate;
        private System.Windows.Forms.Label label_NearestBirthday;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.ListBox listBox_ListPersons;
        private System.Windows.Forms.Button button_LoadList;
    }
}

