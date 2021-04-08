using HospitalBL.MainServices;
using HospitalBL.Model.Entities.Diagnosis;
using System;
using System.Windows.Forms;

namespace Hospital.AddOrEditForm
{
    public partial class AddOrEditDiseaseForm : Form
    {
        Disease _disease;
        public AddOrEditDiseaseForm(Disease disease = default)
        {
            InitializeComponent();
            if (!(disease is null)) _disease = disease;
        }

        private void AddOrEditDiseaseForm_Load(object sender, EventArgs e)
        {
            if(!(_disease is null))
            {
                createButton.Text = "Изменить";
                idLabel.Text = _disease.Id.ToString();
                nameBox.Text = _disease.Name;
                descriptionBox.Text = _disease.Description;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Disease disease = new Disease(nameBox.Text, descriptionBox.Text);

                if (_disease is null) HospitalManager.GetInstance().DiseaseService.AddElement(disease);
                else HospitalManager.GetInstance().DiseaseService.EditElement(_disease.Id, disease);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
