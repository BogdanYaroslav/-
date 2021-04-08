using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Entities.Visit;
using System;
using System.Windows.Forms;

namespace Hospital.AddOrEditForm
{
    public partial class AddOrdEditVisitForm : Form
    {
        Patient _patient;
        Employee _doctor;
        Visit _visit;
        public AddOrdEditVisitForm(Patient customer, Visit visit = default)
        {
            InitializeComponent();
            if (visit is null)
            {
                if (customer is null) throw new ArgumentException("Ошибка привязки пациента");
                _patient = customer;
            }
            else
            {
                _visit = visit;
                _patient = HospitalManager.GetInstance().VisitService.GetPatient(_visit.Patient);
            }

        }

        private void AddOrdEditVisitForm_Load(object sender, EventArgs e)
        {
            patientBox.Text = _patient.FullName;
            BindingDoctor();
            if(!(_visit is null))
            {
                createButton.Text = "Изменить";
                idLabel.Text = _visit.Id.ToString();
                dateBox.Value = _visit.Date;
                timeBox.Value = new DateTime(_visit.Date.Year, _visit.Date.Month, _visit.Date.Day, _visit.Time.Hours, _visit.Time.Minutes, _visit.Time.Seconds);
                patientBox.Text = HospitalManager.GetInstance().VisitService.GetPatient(_visit.Patient).FullName;
                doctorBox.Text = HospitalManager.GetInstance().VisitService.GetDoctore(_visit.Doctor).FullName;
            }
        }

        #region Doctor
        private void BindingDoctor()
        {
            DoctorGridView.AutoGenerateColumns = false;
            AddColumnDoctor();

            profileBindingSource.DataSource = typeof(Employee);

            DoctorSource.DataSource = HospitalManager.GetInstance().EmployeeService.GetElement();
            DoctorSource.RemoveFilter();
            HospitalManager.GetInstance().EmployeeService.FilterByRole(UserRole.Врач, true);
            DoctorNavigator.BindingSource = DoctorSource;
            DoctorGridView.DataSource = DoctorSource;

            viewProfile_CheckedChanged(null, null);
            AddBindingDataDoctor();
        }

        private void AddColumnDoctor()
        {
            DataGridViewTextBoxColumn idCColumn = new DataGridViewTextBoxColumn();
            idCColumn.Name = "Id";
            idCColumn.HeaderText = "Номер доктора";
            idCColumn.DataPropertyName = "Id";
            idCColumn.ReadOnly = true;

            DataGridViewTextBoxColumn nameCColumn = new DataGridViewTextBoxColumn();
            nameCColumn.Name = "FullName";
            nameCColumn.HeaderText = "Имя доктора";
            nameCColumn.DataPropertyName = "FullName";
            nameCColumn.ReadOnly = true;

            DataGridViewTextBoxColumn phoneCColumn = new DataGridViewTextBoxColumn();
            phoneCColumn.Name = "Phone";
            phoneCColumn.HeaderText = "Номер телефона";
            phoneCColumn.DataPropertyName = "Phone";
            phoneCColumn.ReadOnly = true;


            DoctorGridView.Columns.Add(idCColumn);
            DoctorGridView.Columns.Add(nameCColumn);
            DoctorGridView.Columns.Add(phoneCColumn);
        }

        private void AddBindingDataDoctor()
        {
            nameLabel.DataBindings.Add(new Binding("Text", profileBindingSource, "FullName", true, DataSourceUpdateMode.Never));
            phoneLabel.DataBindings.Add(new Binding("Text", profileBindingSource, "Phone", true, DataSourceUpdateMode.Never));
            genderLabel.DataBindings.Add(new Binding("Text", profileBindingSource, "Gender", true, DataSourceUpdateMode.Never));
            birthdayLabel.DataBindings.Add(new Binding("Text", profileBindingSource, "Birthday", true, DataSourceUpdateMode.Never));
            ageLabel.DataBindings.Add(new Binding("Text", profileBindingSource, "Age", true, DataSourceUpdateMode.Never));            

            doctorBox.DataBindings.Add(new Binding("Text", profileBindingSource, "FullName", true, DataSourceUpdateMode.Never));
        }

        private void DoctorSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Refresh();
        }

        private void DoctorGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DoctorGridView.SelectedRows.Count > 0)
            {
                int doctorId = (int)DoctorGridView.SelectedRows[0].Cells["Id"].Value;
                _doctor = HospitalManager.GetInstance().EmployeeService.FindById(doctorId);
                profileBindingSource.DataSource = _doctor;
            }
        }

        private void searchDoctorBox_TextChanged(object sender, EventArgs e)
        {
            removeSorted.PerformClick();
            if (string.IsNullOrWhiteSpace(searchDoctorBox.Text)) HospitalManager.GetInstance().EmployeeService.FilterByRole(UserRole.Врач, true);
            else HospitalManager.GetInstance().EmployeeService.FilterByName(UserRole.Врач, searchDoctorBox.Text, true);
        }

        private void viewProfile_CheckedChanged(object sender, EventArgs e)
        {
            DoctorSplitContainer.Panel2Collapsed = !viewProfile.Checked;
            Refresh();
        }

        private void removeSorted_Click(object sender, EventArgs e)
        {
            DoctorSource.RemoveSort();
        }

        #endregion
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Visit visit = new Visit(_doctor.Id, _patient.Id, dateBox.Value.Date, timeBox.Value.TimeOfDay);

                if (_visit is null) HospitalManager.GetInstance().VisitService.AddElement(visit);
                else HospitalManager.GetInstance().VisitService.EditElement(_visit.Id, visit);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
