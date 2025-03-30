namespace PersonServiceClientDesktop.GuiLayer
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            listBoxPersons = new ListBox();
            buttonGetPersons = new Button();
            labelProcessText = new Label();
            groupBox2 = new GroupBox();
            textBoxFirstname = new TextBox();
            textBoxLastname = new TextBox();
            textBoxMobilePhone = new TextBox();
            buttonSavePerson = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelProcessText);
            groupBox1.Controls.Add(buttonGetPersons);
            groupBox1.Controls.Add(listBoxPersons);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Persons";
            // 
            // listBoxPersons
            // 
            listBoxPersons.FormattingEnabled = true;
            listBoxPersons.ItemHeight = 15;
            listBoxPersons.Location = new Point(6, 22);
            listBoxPersons.Name = "listBoxPersons";
            listBoxPersons.Size = new Size(305, 139);
            listBoxPersons.TabIndex = 0;
            // 
            // buttonGetPersons
            // 
            buttonGetPersons.Location = new Point(236, 177);
            buttonGetPersons.Name = "buttonGetPersons";
            buttonGetPersons.Size = new Size(75, 23);
            buttonGetPersons.TabIndex = 1;
            buttonGetPersons.Text = "Get Persons";
            buttonGetPersons.UseVisualStyleBackColor = true;
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(6, 181);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(0, 15);
            labelProcessText.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonSavePerson);
            groupBox2.Controls.Add(textBoxMobilePhone);
            groupBox2.Controls.Add(textBoxLastname);
            groupBox2.Controls.Add(textBoxFirstname);
            groupBox2.Location = new Point(404, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 219);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Person";
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(129, 44);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(100, 23);
            textBoxFirstname.TabIndex = 0;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(129, 101);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(100, 23);
            textBoxLastname.TabIndex = 1;
            // 
            // textBoxMobilePhone
            // 
            textBoxMobilePhone.Location = new Point(129, 155);
            textBoxMobilePhone.Name = "textBoxMobilePhone";
            textBoxMobilePhone.Size = new Size(100, 23);
            textBoxMobilePhone.TabIndex = 2;
            // 
            // buttonSavePerson
            // 
            buttonSavePerson.Location = new Point(265, 177);
            buttonSavePerson.Name = "buttonSavePerson";
            buttonSavePerson.Size = new Size(75, 23);
            buttonSavePerson.TabIndex = 3;
            buttonSavePerson.Text = "Save Person";
            buttonSavePerson.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 109);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 163);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Mobile Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 185);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelProcessText;
        private Button buttonGetPersons;
        private ListBox listBoxPersons;
        private GroupBox groupBox2;
        private Label label1;
        private Button buttonSavePerson;
        private TextBox textBoxMobilePhone;
        private TextBox textBoxLastname;
        private TextBox textBoxFirstname;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
