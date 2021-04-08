using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Diagnosis;
using HospitalBL.Model.Entities.Person;
using System;
using System.Windows.Forms;

namespace Hospital.AddOrEditForm
{
    public partial class AddOrEditDiagnosisForm : Form
    {
        Patient _patient;
        Employee _doctor;
        Diagnosis _diagnosis;
        Disease selectDisease;
        Treatment selectTreatment;
        public AddOrEditDiagnosisForm(Patient patient, Diagnosis diagnosis = default)
        {
            InitializeComponent();
            if (patient is null) throw new ArgumentNullException("Отсутсвует пациет");            
            _patient = patient;
            _doctor = HospitalManager.GetCurrentEmployee();
            if (_doctor is null) throw new ArgumentNullException("Отсутсвует врач");
            if (_doctor.Role != UserRole.Врач) throw new ArgumentException("Вы не врач!");
            if (!(diagnosis is null)) _diagnosis = diagnosis;
        }

        private void AddOrEditDiagnosisForm_Load(object sender, EventArgs e)
        {
            TreatmentSource.DataSource = HospitalManager.GetInstance().TreatmentService.GetElement();
            treatmentBox.DataSource = TreatmentSource;

            diseaseBox.DataSource = HospitalManager.GetInstance().DiseaseService.GetElement().OriginalList;

            patientBox.Text = _patient.FullName;
            doctorBox.Text = _doctor.FullName;
            dateBox.Text = DateTime.Today.ToLongDateString();

            if(!(_diagnosis is null))
            {
                createButton.Text = "Изменить";
                diseaseBox.SelectedItem = HospitalManager.GetInstance().DiagnosisService.GetDisease(_diagnosis.DiseaseID);
                treatmentBox.SelectedItem = HospitalManager.GetInstance().DiagnosisService.GetTreatment(_diagnosis.TreatmentID);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void diseaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(diseaseBox.SelectedItem is null))
            {
                selectDisease = diseaseBox.SelectedItem as Disease;
                HospitalManager.GetInstance().TreatmentService.FilterByDisease(selectDisease.Id, true);
            }
        }

        private void treatmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(treatmentBox.SelectedItem is null)) selectTreatment = treatmentBox.SelectedItem as Treatment;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnosis diagnosis = new Diagnosis(_patient.Id, _doctor.Id, selectDisease.Id, selectTreatment.Id, DateTime.Parse(dateBox.Text));

                if (_diagnosis is null) HospitalManager.GetInstance().DiagnosisService.AddElement(diagnosis);
                else HospitalManager.GetInstance().DiagnosisService.EditElement(_diagnosis.Id, diagnosis);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
