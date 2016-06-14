namespace Przychodnia
{
    partial class frmBadania
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.datDataZleceniaBadania = new System.Windows.Forms.DateTimePicker();
            this.cmbStausBadania = new System.Windows.Forms.ComboBox();
            this.txtIDBadania = new System.Windows.Forms.TextBox();
            this.txtNazwiskoPacjent = new System.Windows.Forms.TextBox();
            this.txtImiePacjent = new System.Windows.Forms.TextBox();
            this.lblStatusBadania = new System.Windows.Forms.Label();
            this.lblDataZLeceniaBadania = new System.Windows.Forms.Label();
            this.lblIDBadania = new System.Windows.Forms.Label();
            this.lblNazwiskoPacjent = new System.Windows.Forms.Label();
            this.lblImiePacjent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZleceniaBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWykonaniaBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWykonaj = new System.Windows.Forms.Button();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSzukaj);
            this.panel1.Controls.Add(this.datDataZleceniaBadania);
            this.panel1.Controls.Add(this.cmbStausBadania);
            this.panel1.Controls.Add(this.txtIDBadania);
            this.panel1.Controls.Add(this.txtNazwiskoPacjent);
            this.panel1.Controls.Add(this.txtImiePacjent);
            this.panel1.Controls.Add(this.lblStatusBadania);
            this.panel1.Controls.Add(this.lblDataZLeceniaBadania);
            this.panel1.Controls.Add(this.lblIDBadania);
            this.panel1.Controls.Add(this.lblNazwiskoPacjent);
            this.panel1.Controls.Add(this.lblImiePacjent);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 119);
            this.panel1.TabIndex = 0;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.DarkGray;
            this.btnSzukaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(400, 84);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(119, 27);
            this.btnSzukaj.TabIndex = 8;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // datDataZleceniaBadania
            // 
            this.datDataZleceniaBadania.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datDataZleceniaBadania.Checked = false;
            this.datDataZleceniaBadania.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datDataZleceniaBadania.Location = new System.Drawing.Point(400, 46);
            this.datDataZleceniaBadania.Name = "datDataZleceniaBadania";
            this.datDataZleceniaBadania.Size = new System.Drawing.Size(184, 27);
            this.datDataZleceniaBadania.TabIndex = 4;
            // 
            // cmbStausBadania
            // 
            this.cmbStausBadania.DisplayMember = "1";
            this.cmbStausBadania.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStausBadania.FormattingEnabled = true;
            this.cmbStausBadania.ItemHeight = 19;
            this.cmbStausBadania.Items.AddRange(new object[] {
            "Zlecone",
            "Rozpoczęte",
            "Zakończone",
            "Anulowane"});
            this.cmbStausBadania.Location = new System.Drawing.Point(400, 11);
            this.cmbStausBadania.MaxDropDownItems = 5;
            this.cmbStausBadania.Name = "cmbStausBadania";
            this.cmbStausBadania.Size = new System.Drawing.Size(119, 27);
            this.cmbStausBadania.TabIndex = 1;
            this.cmbStausBadania.ValueMember = "1";
            // 
            // txtIDBadania
            // 
            this.txtIDBadania.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIDBadania.Location = new System.Drawing.Point(114, 84);
            this.txtIDBadania.MaxLength = 15;
            this.txtIDBadania.Name = "txtIDBadania";
            this.txtIDBadania.Size = new System.Drawing.Size(128, 27);
            this.txtIDBadania.TabIndex = 7;
            this.txtIDBadania.Text = "11300965";
            this.txtIDBadania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNazwiskoPacjent
            // 
            this.txtNazwiskoPacjent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwiskoPacjent.Location = new System.Drawing.Point(114, 44);
            this.txtNazwiskoPacjent.MaxLength = 15;
            this.txtNazwiskoPacjent.Name = "txtNazwiskoPacjent";
            this.txtNazwiskoPacjent.ReadOnly = true;
            this.txtNazwiskoPacjent.Size = new System.Drawing.Size(128, 27);
            this.txtNazwiskoPacjent.TabIndex = 6;
            this.txtNazwiskoPacjent.Text = "Kwiatkowski";
            // 
            // txtImiePacjent
            // 
            this.txtImiePacjent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImiePacjent.Location = new System.Drawing.Point(114, 8);
            this.txtImiePacjent.MaxLength = 15;
            this.txtImiePacjent.Name = "txtImiePacjent";
            this.txtImiePacjent.ReadOnly = true;
            this.txtImiePacjent.Size = new System.Drawing.Size(128, 27);
            this.txtImiePacjent.TabIndex = 5;
            this.txtImiePacjent.Text = "Jacek";
            // 
            // lblStatusBadania
            // 
            this.lblStatusBadania.AutoSize = true;
            this.lblStatusBadania.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusBadania.Location = new System.Drawing.Point(342, 14);
            this.lblStatusBadania.Name = "lblStatusBadania";
            this.lblStatusBadania.Size = new System.Drawing.Size(52, 19);
            this.lblStatusBadania.TabIndex = 4;
            this.lblStatusBadania.Text = "Status";
            // 
            // lblDataZLeceniaBadania
            // 
            this.lblDataZLeceniaBadania.AutoSize = true;
            this.lblDataZLeceniaBadania.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZLeceniaBadania.Location = new System.Drawing.Point(320, 52);
            this.lblDataZLeceniaBadania.Name = "lblDataZLeceniaBadania";
            this.lblDataZLeceniaBadania.Size = new System.Drawing.Size(74, 19);
            this.lblDataZLeceniaBadania.TabIndex = 4;
            this.lblDataZLeceniaBadania.Text = "Data zlec.";
            // 
            // lblIDBadania
            // 
            this.lblIDBadania.AutoSize = true;
            this.lblIDBadania.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDBadania.Location = new System.Drawing.Point(26, 87);
            this.lblIDBadania.Name = "lblIDBadania";
            this.lblIDBadania.Size = new System.Drawing.Size(82, 19);
            this.lblIDBadania.TabIndex = 4;
            this.lblIDBadania.Text = "ID Badania";
            // 
            // lblNazwiskoPacjent
            // 
            this.lblNazwiskoPacjent.AutoSize = true;
            this.lblNazwiskoPacjent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwiskoPacjent.Location = new System.Drawing.Point(35, 52);
            this.lblNazwiskoPacjent.Name = "lblNazwiskoPacjent";
            this.lblNazwiskoPacjent.Size = new System.Drawing.Size(73, 19);
            this.lblNazwiskoPacjent.TabIndex = 1;
            this.lblNazwiskoPacjent.Text = "Nazwisko";
            // 
            // lblImiePacjent
            // 
            this.lblImiePacjent.AutoSize = true;
            this.lblImiePacjent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImiePacjent.Location = new System.Drawing.Point(70, 16);
            this.lblImiePacjent.Margin = new System.Windows.Forms.Padding(0);
            this.lblImiePacjent.Name = "lblImiePacjent";
            this.lblImiePacjent.Size = new System.Drawing.Size(38, 19);
            this.lblImiePacjent.TabIndex = 0;
            this.lblImiePacjent.Text = "Imię";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBadania,
            this.kodBadania,
            this.nazwaBadania,
            this.statusBadania,
            this.dataZleceniaBadania,
            this.dataWykonaniaBadania,
            this.uwagiBadania});
            this.dataGridView1.Location = new System.Drawing.Point(15, 137);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(718, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // IDBadania
            // 
            this.IDBadania.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IDBadania.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDBadania.FillWeight = 90F;
            this.IDBadania.HeaderText = "ID Badania";
            this.IDBadania.Name = "IDBadania";
            this.IDBadania.ReadOnly = true;
            this.IDBadania.Width = 90;
            // 
            // kodBadania
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kodBadania.DefaultCellStyle = dataGridViewCellStyle3;
            this.kodBadania.FillWeight = 50F;
            this.kodBadania.HeaderText = "Kod";
            this.kodBadania.Name = "kodBadania";
            this.kodBadania.ReadOnly = true;
            this.kodBadania.Width = 50;
            // 
            // nazwaBadania
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nazwaBadania.DefaultCellStyle = dataGridViewCellStyle4;
            this.nazwaBadania.HeaderText = "Nazwa";
            this.nazwaBadania.Name = "nazwaBadania";
            this.nazwaBadania.ReadOnly = true;
            // 
            // statusBadania
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusBadania.DefaultCellStyle = dataGridViewCellStyle5;
            this.statusBadania.HeaderText = "Status";
            this.statusBadania.Name = "statusBadania";
            this.statusBadania.ReadOnly = true;
            // 
            // dataZleceniaBadania
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataZleceniaBadania.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataZleceniaBadania.HeaderText = "Data zlec.";
            this.dataZleceniaBadania.Name = "dataZleceniaBadania";
            this.dataZleceniaBadania.ReadOnly = true;
            // 
            // dataWykonaniaBadania
            // 
            this.dataWykonaniaBadania.HeaderText = "Data wyk.";
            this.dataWykonaniaBadania.Name = "dataWykonaniaBadania";
            this.dataWykonaniaBadania.ReadOnly = true;
            // 
            // uwagiBadania
            // 
            this.uwagiBadania.FillWeight = 150F;
            this.uwagiBadania.HeaderText = "Uwagi";
            this.uwagiBadania.Name = "uwagiBadania";
            this.uwagiBadania.ReadOnly = true;
            this.uwagiBadania.Width = 150;
            // 
            // btnWykonaj
            // 
            this.btnWykonaj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnWykonaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWykonaj.Location = new System.Drawing.Point(423, 393);
            this.btnWykonaj.Name = "btnWykonaj";
            this.btnWykonaj.Size = new System.Drawing.Size(152, 42);
            this.btnWykonaj.TabIndex = 2;
            this.btnWykonaj.Text = "Wykonaj";
            this.btnWykonaj.UseVisualStyleBackColor = false;
            this.btnWykonaj.Click += new System.EventHandler(this.btnWykonaj_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPokaz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokaz.Location = new System.Drawing.Point(581, 393);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(152, 42);
            this.btnPokaz.TabIndex = 3;
            this.btnPokaz.Text = "Pokaż";
            this.btnPokaz.UseVisualStyleBackColor = false;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // frmBadania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 442);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.btnWykonaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBadania";
            this.Text = "Badania";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZleceniaBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWykonaniaBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiBadania;
        private System.Windows.Forms.Button btnWykonaj;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.Label lblNazwiskoPacjent;
        private System.Windows.Forms.Label lblImiePacjent;
        private System.Windows.Forms.Label lblIDBadania;
        private System.Windows.Forms.Label lblStatusBadania;
        private System.Windows.Forms.Label lblDataZLeceniaBadania;
        private System.Windows.Forms.TextBox txtIDBadania;
        private System.Windows.Forms.TextBox txtNazwiskoPacjent;
        private System.Windows.Forms.TextBox txtImiePacjent;
        private System.Windows.Forms.ComboBox cmbStausBadania;
        private System.Windows.Forms.DateTimePicker datDataZleceniaBadania;
        private System.Windows.Forms.Button btnSzukaj;
    }
}