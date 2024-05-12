namespace WheaterAPP
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lT_Search = new System.Windows.Forms.Label();
            this.tB_Schearch = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.lT_Description = new System.Windows.Forms.Label();
            this.lT_Temperature = new System.Windows.Forms.Label();
            this.l_DesValue = new System.Windows.Forms.Label();
            this.l_TempValue = new System.Windows.Forms.Label();
            this.b_MoreInfo = new System.Windows.Forms.Button();
            this.pB_Wheater = new System.Windows.Forms.PictureBox();
            this.b_Forcast = new System.Windows.Forms.Button();
            this.b_History = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Wheater)).BeginInit();
            this.SuspendLayout();
            // 
            // lT_Search
            // 
            this.lT_Search.BackColor = System.Drawing.Color.Transparent;
            this.lT_Search.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lT_Search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lT_Search.Location = new System.Drawing.Point(8, 9);
            this.lT_Search.Name = "lT_Search";
            this.lT_Search.Size = new System.Drawing.Size(147, 36);
            this.lT_Search.TabIndex = 0;
            this.lT_Search.Text = "Szukaj :";
            this.lT_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_Schearch
            // 
            this.tB_Schearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_Schearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_Schearch.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_Schearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tB_Schearch.Location = new System.Drawing.Point(139, 17);
            this.tB_Schearch.Name = "tB_Schearch";
            this.tB_Schearch.Size = new System.Drawing.Size(242, 28);
            this.tB_Schearch.TabIndex = 1;
            this.tB_Schearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.Transparent;
            this.bt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Search.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Search.Location = new System.Drawing.Point(397, 12);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(108, 36);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Szukaj";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // lT_Description
            // 
            this.lT_Description.AutoSize = true;
            this.lT_Description.BackColor = System.Drawing.Color.Transparent;
            this.lT_Description.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lT_Description.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lT_Description.Location = new System.Drawing.Point(254, 219);
            this.lT_Description.Name = "lT_Description";
            this.lT_Description.Size = new System.Drawing.Size(89, 35);
            this.lT_Description.TabIndex = 3;
            this.lT_Description.Text = "Opis :";
            // 
            // lT_Temperature
            // 
            this.lT_Temperature.AutoSize = true;
            this.lT_Temperature.BackColor = System.Drawing.Color.Transparent;
            this.lT_Temperature.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lT_Temperature.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lT_Temperature.Location = new System.Drawing.Point(254, 128);
            this.lT_Temperature.Name = "lT_Temperature";
            this.lT_Temperature.Size = new System.Drawing.Size(194, 35);
            this.lT_Temperature.TabIndex = 4;
            this.lT_Temperature.Text = "Temperatura :";
            // 
            // l_DesValue
            // 
            this.l_DesValue.AutoSize = true;
            this.l_DesValue.BackColor = System.Drawing.Color.SteelBlue;
            this.l_DesValue.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_DesValue.ForeColor = System.Drawing.SystemColors.Info;
            this.l_DesValue.Location = new System.Drawing.Point(275, 271);
            this.l_DesValue.Name = "l_DesValue";
            this.l_DesValue.Size = new System.Drawing.Size(0, 35);
            this.l_DesValue.TabIndex = 5;
            // 
            // l_TempValue
            // 
            this.l_TempValue.AutoSize = true;
            this.l_TempValue.BackColor = System.Drawing.Color.SteelBlue;
            this.l_TempValue.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_TempValue.ForeColor = System.Drawing.SystemColors.Info;
            this.l_TempValue.Location = new System.Drawing.Point(275, 175);
            this.l_TempValue.Name = "l_TempValue";
            this.l_TempValue.Size = new System.Drawing.Size(0, 35);
            this.l_TempValue.TabIndex = 6;
            // 
            // b_MoreInfo
            // 
            this.b_MoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.b_MoreInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_MoreInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_MoreInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_MoreInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_MoreInfo.Location = new System.Drawing.Point(14, 240);
            this.b_MoreInfo.Name = "b_MoreInfo";
            this.b_MoreInfo.Size = new System.Drawing.Size(105, 52);
            this.b_MoreInfo.TabIndex = 10;
            this.b_MoreInfo.Text = "Więcej\r\nInformacji\r\n";
            this.b_MoreInfo.UseVisualStyleBackColor = false;
            this.b_MoreInfo.Visible = false;
            this.b_MoreInfo.Click += new System.EventHandler(this.b_MoreInfo_Click);
            // 
            // pB_Wheater
            // 
            this.pB_Wheater.BackColor = System.Drawing.Color.Transparent;
            this.pB_Wheater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_Wheater.Location = new System.Drawing.Point(88, 128);
            this.pB_Wheater.Name = "pB_Wheater";
            this.pB_Wheater.Size = new System.Drawing.Size(97, 89);
            this.pB_Wheater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Wheater.TabIndex = 9;
            this.pB_Wheater.TabStop = false;
            this.pB_Wheater.WaitOnLoad = true;
            // 
            // b_Forcast
            // 
            this.b_Forcast.BackColor = System.Drawing.Color.Transparent;
            this.b_Forcast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_Forcast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Forcast.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.b_Forcast.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Forcast.Location = new System.Drawing.Point(141, 240);
            this.b_Forcast.Name = "b_Forcast";
            this.b_Forcast.Size = new System.Drawing.Size(105, 52);
            this.b_Forcast.TabIndex = 11;
            this.b_Forcast.Text = "Prognoza Pogody\r\n";
            this.b_Forcast.UseVisualStyleBackColor = false;
            this.b_Forcast.Visible = false;
            this.b_Forcast.Click += new System.EventHandler(this.b_Forcast_Click);
            // 
            // b_History
            // 
            this.b_History.BackColor = System.Drawing.Color.Transparent;
            this.b_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_History.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.b_History.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_History.Location = new System.Drawing.Point(141, 299);
            this.b_History.Name = "b_History";
            this.b_History.Size = new System.Drawing.Size(105, 52);
            this.b_History.TabIndex = 13;
            this.b_History.Text = "Historia\r\nPogody\r\n";
            this.b_History.UseVisualStyleBackColor = false;
            this.b_History.Visible = false;
            this.b_History.Click += new System.EventHandler(this.b_History_Click);
            // 
            // b_Save
            // 
            this.b_Save.BackColor = System.Drawing.Color.Transparent;
            this.b_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Save.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_Save.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_Save.Location = new System.Drawing.Point(14, 299);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(105, 52);
            this.b_Save.TabIndex = 12;
            this.b_Save.Text = "Zapisz";
            this.b_Save.UseVisualStyleBackColor = false;
            this.b_Save.Visible = false;
            this.b_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WheaterAPP.Properties.Resources._52196025795_06f077377a_c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 363);
            this.Controls.Add(this.b_History);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.b_Forcast);
            this.Controls.Add(this.b_MoreInfo);
            this.Controls.Add(this.pB_Wheater);
            this.Controls.Add(this.l_TempValue);
            this.Controls.Add(this.l_DesValue);
            this.Controls.Add(this.lT_Temperature);
            this.Controls.Add(this.lT_Description);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tB_Schearch);
            this.Controls.Add(this.lT_Search);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Pogoda";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Wheater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lT_Search;
        private System.Windows.Forms.TextBox tB_Schearch;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label lT_Description;
        private System.Windows.Forms.Label lT_Temperature;
        private System.Windows.Forms.Label l_DesValue;
        private System.Windows.Forms.Label l_TempValue;
        private System.Windows.Forms.PictureBox pB_Wheater;
        private System.Windows.Forms.Button b_MoreInfo;
        private System.Windows.Forms.Button b_Forcast;
        private System.Windows.Forms.Button b_History;
        private System.Windows.Forms.Button b_Save;
    }
}

