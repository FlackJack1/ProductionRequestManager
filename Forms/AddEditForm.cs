using System;
using System.Windows.Forms;
using ProductionRequestManager.Models;

namespace ProductionRequestManager
{
    public partial class AddEditForm : Form
    {
        public Request ResultRequest { get; private set; }

        public AddEditForm(Request existingRequest = null)
        {
            InitializeComponent();

            cmbStatus.Items.AddRange(new[] { "Новая", "В работе", "Завершена" });

            if (existingRequest != null)
            {
                Text = "Редактировать заявку";
                txtClient.Text = existingRequest.Client;
                txtDescription.Text = existingRequest.Description;
                cmbStatus.SelectedItem = existingRequest.Status;
                ResultRequest = existingRequest;
            }
            else
            {
                Text = "Новая заявка";
                cmbStatus.SelectedIndex = 0;
                ResultRequest = new Request();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ResultRequest.Client = txtClient.Text;
            ResultRequest.Description = txtDescription.Text;
            ResultRequest.Status = cmbStatus.SelectedItem?.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
