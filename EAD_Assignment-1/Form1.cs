namespace EAD_Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            if (txtFirstName.Text.Length == 0)
            {
                txtFirstNameEmpty.Visible = true;
                txtFirstNameEmpty.Text = "First name can't be empty";
            }

            else if (txtLastName.Text.Length == 0)
            {
                txtLastNameEmpty.Visible = true;
                txtLastNameEmpty.Text = "Last name can't be empty";
            }

            else if (chkAcceptance.Checked)
            {
                txtFirstNameEmpty.Visible = false;
                txtLastNameEmpty.Visible = false;
                textBoxAgreement.Visible = false;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                bool prerequisiteClear = chkAcceptance.Checked;
                List<String> subject_list = cmbSubjectSelection.Items.Cast<String>().ToList();

                listBoxResult.Items.Add($"First Name: {firstName}\n");
                listBoxResult.Items.Add($"Last Name: {lastName}\n");
                listBoxResult.Items.Add($"Selected Subjects: ");
                foreach (string subject in subject_list)
                {
                    listBoxResult.Items.Add($"{subject}\n");
                }
            }

            else
            {
                textBoxAgreement.Visible = true;
                textBoxAgreement.Text = "Please Accept the agreement";
            }
        }



        private void listBox1_Leave(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            cmbSubjectSelection.Items.Clear();
            foreach (var selected in listBox1.SelectedItems)
            {
                cmbSubjectSelection.Items.Add(selected.ToString());
            }
            cmbSubjectSelection.SelectedIndex = 0;
        }

        private void cmbSubjectSelection_DropDown(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }
    }
}