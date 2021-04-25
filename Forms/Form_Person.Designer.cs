
namespace AddressBookMVPDEMO
{
    partial class Form_Person
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Birthday = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(33, 218);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(39, 15);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Location = new System.Drawing.Point(33, 249);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(51, 15);
            this.lbl_Birthday.TabIndex = 1;
            this.lbl_Birthday.Text = "Birthday";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(117, 277);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(106, 34);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(141, 215);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(179, 23);
            this.textBox_Name.TabIndex = 3;
            // 
            // dateTimePicker_Birthday
            // 
            this.dateTimePicker_Birthday.Location = new System.Drawing.Point(141, 243);
            this.dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            this.dateTimePicker_Birthday.Size = new System.Drawing.Size(179, 23);
            this.dateTimePicker_Birthday.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddressBookMVPDEMO.Properties.Resources.concact;
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker_Birthday);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Person";
            this.Shown += new System.EventHandler(this.Form_Person_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthday;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}