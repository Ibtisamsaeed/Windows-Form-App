namespace EAD_Assignment_1
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblSubjectSelection = new Label();
            cmbSubjectSelection = new ComboBox();
            chkAcceptance = new CheckBox();
            btnSubmit = new Button();
            lblResult = new Label();
            listBox1 = new ListBox();
            listBoxResult = new ListBox();
            textBoxAgreement = new TextBox();
            txtFirstNameEmpty = new TextBox();
            txtLastNameEmpty = new TextBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(45, 35);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(148, 35);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(231, 31);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(45, 136);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(148, 130);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(231, 31);
            txtLastName.TabIndex = 3;
            // 
            // lblSubjectSelection
            // 
            lblSubjectSelection.AutoSize = true;
            lblSubjectSelection.Location = new Point(45, 236);
            lblSubjectSelection.Name = "lblSubjectSelection";
            lblSubjectSelection.Size = new Size(146, 25);
            lblSubjectSelection.TabIndex = 4;
            lblSubjectSelection.Text = "Subject Selection";
            // 
            // cmbSubjectSelection
            // 
            cmbSubjectSelection.DropDownHeight = 1;
            cmbSubjectSelection.DropDownWidth = 1;
            cmbSubjectSelection.FormattingEnabled = true;
            cmbSubjectSelection.IntegralHeight = false;
            cmbSubjectSelection.Location = new Point(197, 236);
            cmbSubjectSelection.Name = "cmbSubjectSelection";
            cmbSubjectSelection.Size = new Size(182, 33);
            cmbSubjectSelection.TabIndex = 5;
            cmbSubjectSelection.DropDown += cmbSubjectSelection_DropDown;
            // 
            // chkAcceptance
            // 
            chkAcceptance.AutoSize = true;
            chkAcceptance.Location = new Point(47, 421);
            chkAcceptance.Name = "chkAcceptance";
            chkAcceptance.Size = new Size(200, 29);
            chkAcceptance.TabIndex = 6;
            chkAcceptance.Text = "Accept and continue";
            chkAcceptance.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(47, 503);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(47, 567);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 8;
            lblResult.Text = "Result";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(197, 275);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(182, 129);
            listBox1.TabIndex = 9;
            listBox1.Visible = false;
            listBox1.Leave += listBox1_Leave;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 25;
            listBoxResult.Location = new Point(47, 595);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(334, 179);
            listBoxResult.TabIndex = 10;
            // 
            // textBoxAgreement
            // 
            textBoxAgreement.ForeColor = Color.Red;
            textBoxAgreement.Location = new Point(45, 456);
            textBoxAgreement.Name = "textBoxAgreement";
            textBoxAgreement.Size = new Size(252, 31);
            textBoxAgreement.TabIndex = 11;
            textBoxAgreement.Visible = false;
            // 
            // txtFirstNameEmpty
            // 
            txtFirstNameEmpty.ForeColor = Color.Red;
            txtFirstNameEmpty.Location = new Point(151, 72);
            txtFirstNameEmpty.Name = "txtFirstNameEmpty";
            txtFirstNameEmpty.Size = new Size(228, 31);
            txtFirstNameEmpty.TabIndex = 12;
            txtFirstNameEmpty.Visible = false;
            // 
            // txtLastNameEmpty
            // 
            txtLastNameEmpty.ForeColor = Color.Red;
            txtLastNameEmpty.Location = new Point(148, 167);
            txtLastNameEmpty.Name = "txtLastNameEmpty";
            txtLastNameEmpty.Size = new Size(231, 31);
            txtLastNameEmpty.TabIndex = 13;
            txtLastNameEmpty.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 744);
            Controls.Add(txtLastNameEmpty);
            Controls.Add(txtFirstNameEmpty);
            Controls.Add(textBoxAgreement);
            Controls.Add(listBoxResult);
            Controls.Add(listBox1);
            Controls.Add(lblResult);
            Controls.Add(btnSubmit);
            Controls.Add(chkAcceptance);
            Controls.Add(cmbSubjectSelection);
            Controls.Add(lblSubjectSelection);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblSubjectSelection;
        private ComboBox cmbSubjectSelection;
        private CheckBox chkAcceptance;
        private Button btnSubmit;
        private Label lblResult;
        private ListBox listBox1;
        private ListBox listBoxResult;
        private TextBox textBoxAgreement;
        private TextBox txtFirstNameEmpty;
        private TextBox txtLastNameEmpty;
    }
}