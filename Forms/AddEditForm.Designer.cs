namespace ProductionRequestManager
{
    partial class AddEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelClient.Text = "Клиент:";
            this.labelClient.Location = new System.Drawing.Point(12, 15);

            this.txtClient.Location = new System.Drawing.Point(100, 12);
            this.txtClient.Width = 250;

            this.labelDescription.Text = "Описание:";
            this.labelDescription.Location = new System.Drawing.Point(12, 45);

            this.txtDescription.Location = new System.Drawing.Point(100, 42);
            this.txtDescription.Multiline = true;
            this.txtDescription.Width = 250;
            this.txtDescription.Height = 60;

            this.labelStatus.Text = "Статус:";
            this.labelStatus.Location = new System.Drawing.Point(12, 115);

            this.cmbStatus.Location = new System.Drawing.Point(100, 112);
            this.cmbStatus.Width = 250;

            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(100, 150);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Отмена";
            this.btnCancel.Location = new System.Drawing.Point(200, 150);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.ClientSize = new System.Drawing.Size(370, 200);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
