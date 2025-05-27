namespace ProductionRequestManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;

        private void InitializeComponent()
        {
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewRequests.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRequests.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewRequests.ReadOnly = true;
            this.dataGridViewRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(12, 270);

            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Location = new System.Drawing.Point(112, 270);

            this.btnDelete.Text = "Удалить";
            this.btnDelete.Location = new System.Drawing.Point(232, 270);

            this.btnExport.Text = "Экспорт XML";
            this.btnExport.Location = new System.Drawing.Point(332, 270);

            this.cmbStatusFilter.Location = new System.Drawing.Point(12, 310);
            this.cmbStatusFilter.Width = 120;

            this.btnFilter.Text = "Фильтр";
            this.btnFilter.Location = new System.Drawing.Point(150, 310);

            this.txtSearch.Location = new System.Drawing.Point(280, 310);
            this.txtSearch.Width = 200;

            this.btnSearch.Text = "Поиск";
            this.btnSearch.Location = new System.Drawing.Point(490, 310);

            this.btnClearSearch.Text = "Сброс";
            this.btnClearSearch.Location = new System.Drawing.Point(570, 310);

            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridViewRequests);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClearSearch);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
