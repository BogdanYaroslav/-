using HospitalBL.MainServices;
using HospitalBL.Model.Entities.Diagnosis;
using System;
using System.Windows.Forms;

namespace Hospital.AddOrEditForm
{
    public partial class AddOrEditTreatmentForm : Form
    {
        Treatment _treatment;
        Disease _disease;
        public AddOrEditTreatmentForm(Disease disease, Treatment treatment = default)
        {
            InitializeComponent();
            if (disease is null) throw new ArgumentException("Не указанно заболевание");
            if (!(treatment is null)) _treatment = treatment;
            _disease = disease;
        }

        private void AddOrEditDiseaseForm_Load(object sender, EventArgs e)
        {
            if(!(_treatment is null))
            {
                createButton.Text = "Изменить";
                idLabel.Text = _treatment.Id.ToString();
                nameBox.Text = _treatment.Name;
                descriptionBox.Text = _treatment.Description;
            }
            diseaseBox.Text = _disease.Name;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Treatment treament = new Treatment(nameBox.Text, _disease.Id, descriptionBox.Text);

                if (_treatment is null) HospitalManager.GetInstance().TreatmentService.AddElement(treament);
                else HospitalManager.GetInstance().TreatmentService.EditElement(_treatment.Id, treament);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
