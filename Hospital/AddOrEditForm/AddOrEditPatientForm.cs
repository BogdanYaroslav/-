using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using System;
using System.Windows.Forms;

namespace Hospital.AddOrEditForm
{
    public partial class AddOrEditPatientForm : Form
    {
        Patient _patient;
        public AddOrEditPatientForm(Patient patient = default)
        {
            InitializeComponent();
            if (!(patient is null)) _patient = patient;
        }

        private void AddOrEditPatientForm_Load(object sender, EventArgs e)
        {
            genderBox.DataSource = Enum.GetValues(typeof(Genders));
            if (!(_patient is null))
            {
                createButton.Text = "Изменить";
                AddBinding();
            }
        }
        private void AddBinding()
        {
            patientBindingSource.DataSource = _patient;

            idLabel.DataBindings.Add(new Binding("Text", patientBindingSource, "Id", true, DataSourceUpdateMode.Never));
            nameBox.DataBindings.Add(new Binding("Text", patientBindingSource, "Name", true, DataSourceUpdateMode.Never));
            surnameBox.DataBindings.Add(new Binding("Text", patientBindingSource, "Surname", true, DataSourceUpdateMode.Never));
            phoneBox.DataBindings.Add(new Binding("Text", patientBindingSource, "Phone", true, DataSourceUpdateMode.Never));
            dateBox.DataBindings.Add(new Binding("Text", patientBindingSource, "Birthday", true, DataSourceUpdateMode.Never));
            
            genderBox.SelectedItem = _patient.Gender;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Patient patient = new Patient(nameBox.Text, surnameBox.Text, (Genders)genderBox.SelectedItem, phoneBox.Text, dateBox.Value.Date);

                if (_patient is null) HospitalManager.GetInstance().PatientService.AddElement(patient);
                else HospitalManager.GetInstance().PatientService.EditElement(_patient.Id, patient);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
