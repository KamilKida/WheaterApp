namespace WheaterAPP.Forms
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bS_History = new System.Windows.Forms.BindingSource(this.components);
            this.dGV_History = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bS_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_History)).BeginInit();
            this.SuspendLayout();
            // 
            // bS_History
            // 
            this.bS_History.DataSource = typeof(WheaterAPP.Models.WheaterInfoModel.root);
            // 
            // dGV_History
            // 
            this.dGV_History.AllowUserToAddRows = false;
            this.dGV_History.AllowUserToDeleteRows = false;
            this.dGV_History.AutoGenerateColumns = false;
            this.dGV_History.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dGV_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_History.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dateOfCreation,
            this.Show,
            this.Delete});
            this.dGV_History.DataSource = this.bS_History;
            this.dGV_History.Location = new System.Drawing.Point(40, 28);
            this.dGV_History.Name = "dGV_History";
            this.dGV_History.ReadOnly = true;
            this.dGV_History.Size = new System.Drawing.Size(714, 399);
            this.dGV_History.TabIndex = 0;
            this.dGV_History.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_History_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Miasto";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateOfCreation
            // 
            this.dateOfCreation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfCreation.DataPropertyName = "dateOfCreation";
            this.dateOfCreation.HeaderText = "Data zapisu";
            this.dateOfCreation.Name = "dateOfCreation";
            this.dateOfCreation.ReadOnly = true;
            // 
            // Show
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Show.DefaultCellStyle = dataGridViewCellStyle1;
            this.Show.HeaderText = "";
            this.Show.Name = "Show";
            this.Show.ReadOnly = true;
            this.Show.Text = "Pokaż";
            this.Show.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Usuń";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::WheaterAPP.Properties.Resources._52196025795_06f077377a_c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV_History);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.ShowIcon = false;
            this.Text = "Historia pogody";
            ((System.ComponentModel.ISupportInitialize)(this.bS_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_History)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bS_History;
        private System.Windows.Forms.DataGridView dGV_History;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCreation;
        private System.Windows.Forms.DataGridViewButtonColumn Show;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}