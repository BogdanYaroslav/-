using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using System;
using System.Windows.Forms;

namespace Hospital.AddOrEditForm
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddOrEditEmployeeForm_Load(object sender, EventArgs e)
        {
            genderBox.DataSource = Enum.GetValues(typeof(Genders));
            priorityBox.DataSource = Enum.GetValues(typeof(UserPriority));
            roleBox.DataSource = Enum.GetValues(typeof(UserRole));
            passwordBox.UseSystemPasswordChar = !showBox.Checked;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalManager.GetInstance().EmployeeService.AddElement(new Employee(
                    loginBox.Text, passwordBox.Text, (UserRole)roleBox.SelectedItem, nameBox.Text, surnameBox.Text,
                    (Genders)genderBox.SelectedItem, phoneBox.Text, dateBox.Value.Date,
                    (UserPriority)priorityBox.SelectedItem));
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !showBox.Checked;
        }
    }
}
