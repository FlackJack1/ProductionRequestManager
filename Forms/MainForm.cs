using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProductionRequestManager.Models;
using ProductionRequestManager.Data;

namespace ProductionRequestManager
{
    public partial class MainForm : Form
    {
        private List<Request> requests = new List<Request>();

        public MainForm()
        {
            InitializeComponent();
            Database.Initialize();
            LoadRequests();

            cmbStatusFilter.Items.AddRange(new[] { "Все", "Новая", "В работе", "Завершена" });
            cmbStatusFilter.SelectedIndex = 0;
        }

        private void LoadRequests()
        {
            requests = Database.GetAllRequests();
            dataGridViewRequests.DataSource = new BindingSource { DataSource = requests };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Database.AddRequest(form.ResultRequest);
                LoadRequests();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.CurrentRow?.DataBoundItem is Request selected)
            {
                var form = new AddEditForm(new Request
                {
                    Id = selected.Id,
                    Client = selected.Client,
                    Description = selected.Description,
                    Status = selected.Status
                });

                if (form.ShowDialog() == DialogResult.OK)
                {
                    Database.UpdateRequest(form.ResultRequest);
                    LoadRequests();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.CurrentRow?.DataBoundItem is Request selected)
            {
                Database.DeleteRequest(selected.Id);
                LoadRequests();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files (*.xml)|*.xml";
            sfd.Title = "Сохранить заявки в XML";
            sfd.FileName = "requests.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var allRequests = requests.ToList();
                Utils.Exporter.ExportToXml(allRequests, sfd.FileName);
                MessageBox.Show("Заявки экспортированы в XML", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string status = cmbStatusFilter.SelectedItem.ToString();
            if (status == "Все")
            {
                LoadRequests();
            }
            else
            {
                var filtered = requests.Where(r => r.Status == status).ToList();
                dataGridViewRequests.DataSource = new BindingSource { DataSource = filtered };
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(query))
                return;

            var filtered = requests
                .Where(r => (r.Client?.ToLower().Contains(query) ?? false) ||
                            (r.Description?.ToLower().Contains(query) ?? false))
                .ToList();

            dataGridViewRequests.DataSource = new BindingSource { DataSource = filtered };
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadRequests();
        }
    }
}
