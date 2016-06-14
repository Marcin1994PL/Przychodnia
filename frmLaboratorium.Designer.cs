namespace Przychodnia
{
    partial class frmLaboratorium
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabLekarz = new System.Windows.Forms.TabPage();
            this.txtKodBadaniaLekarz = new System.Windows.Forms.TextBox();
            this.btnWYbierzKodBadaniaLekarz = new System.Windows.Forms.Button();
            this.lblStatusBadaniaLekarz = new System.Windows.Forms.Label();
            this.txtNazwaBadaniaLekarz = new System.Windows.Forms.TextBox();
            this.lblNazwaBadaniaLekarz = new System.Windows.Forms.Label();
            this.txtStatusBadaniaLekarz = new System.Windows.Forms.TextBox();
            this.lblKodBadaniaLekarz = new System.Windows.Forms.Label();
            this.txtIDBadaniaLekarz = new System.Windows.Forms.TextBox();
            this.lblIDBadaniaLekarz = new System.Windows.Forms.Label();
            this.lblUwagiLekarz = new System.Windows.Forms.Label();
            this.btnZlecLekarz = new System.Windows.Forms.Button();
            this.charCounterLekarz = new System.Windows.Forms.Label();
            this.txtUwagiLekarz = new System.Windows.Forms.TextBox();
            this.tabLab = new System.Windows.Forms.TabPage();
            this.txtKodBadaniaLab = new System.Windows.Forms.TextBox();
            this.lblStatusBadaniaLab = new System.Windows.Forms.Label();
            this.txtNazwaBadaniaLab = new System.Windows.Forms.TextBox();
            this.lblNazwaBadaniaLab = new System.Windows.Forms.Label();
            this.txtStatusBadaniaLab = new System.Windows.Forms.TextBox();
            this.lblKodBadaniaLab = new System.Windows.Forms.Label();
            this.txtIDBadaniaLab = new System.Windows.Forms.TextBox();
            this.lblIDBadaniaLab = new System.Windows.Forms.Label();
            this.lblWynikiLab = new System.Windows.Forms.Label();
            this.btnZatwierdzLab = new System.Windows.Forms.Button();
            this.btnAnulujLab = new System.Windows.Forms.Button();
            this.charCounterLab = new System.Windows.Forms.Label();
            this.txtWynikiLab = new System.Windows.Forms.TextBox();
            this.tabKlab = new System.Windows.Forms.TabPage();
            this.lblInfoBadanie = new System.Windows.Forms.Label();
            this.lblUwagiKLab = new System.Windows.Forms.Label();
            this.btnZatwierdzKLab = new System.Windows.Forms.Button();
            this.btnAnulujKLab = new System.Windows.Forms.Button();
            this.charCounterKLab = new System.Windows.Forms.Label();
            this.txtUwagiKLab = new System.Windows.Forms.TextBox();
            this.Tab.SuspendLayout();
            this.tabLekarz.SuspendLayout();
            this.tabLab.SuspendLayout();
            this.tabKlab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabLekarz);
            this.Tab.Controls.Add(this.tabLab);
            this.Tab.Controls.Add(this.tabKlab);
            this.Tab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tab.ItemSize = new System.Drawing.Size(200, 28);
            this.Tab.Location = new System.Drawing.Point(10, 12);
            this.Tab.Margin = new System.Windows.Forms.Padding(1);
            this.Tab.Name = "Tab";
            this.Tab.Padding = new System.Drawing.Point(3, 3);
            this.Tab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(606, 238);
            this.Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabLekarz.BackColor = System.Drawing.Color.LightGray;
            this.tabLekarz.Controls.Add(this.txtKodBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.btnWYbierzKodBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.lblStatusBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.txtNazwaBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.lblNazwaBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.txtStatusBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.lblKodBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.txtIDBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.lblIDBadaniaLekarz);
            this.tabLekarz.Controls.Add(this.lblUwagiLekarz);
            this.tabLekarz.Controls.Add(this.btnZlecLekarz);
            this.tabLekarz.Controls.Add(this.charCounterLekarz);
            this.tabLekarz.Controls.Add(this.txtUwagiLekarz);
            this.tabLekarz.Location = new System.Drawing.Point(4, 32);
            this.tabLekarz.Name = "tabPage1";
            this.tabLekarz.Padding = new System.Windows.Forms.Padding(3);
            this.tabLekarz.Size = new System.Drawing.Size(598, 202);
            this.tabLekarz.TabIndex = 0;
            this.tabLekarz.Text = "Lekarz";
            // 
            // txtKodBadaniaLekarz
            // 
            this.txtKodBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKodBadaniaLekarz.Location = new System.Drawing.Point(110, 47);
            this.txtKodBadaniaLekarz.MaxLength = 15;
            this.txtKodBadaniaLekarz.Name = "txtKodBadaniaLekarz";
            this.txtKodBadaniaLekarz.ReadOnly = true;
            this.txtKodBadaniaLekarz.Size = new System.Drawing.Size(88, 27);
            this.txtKodBadaniaLekarz.TabIndex = 30;
            this.txtKodBadaniaLekarz.Text = "Bx0045";
            // 
            // btnWYbierzKodBadaniaLekarz
            // 
            this.btnWYbierzKodBadaniaLekarz.Location = new System.Drawing.Point(204, 47);
            this.btnWYbierzKodBadaniaLekarz.Name = "btnWYbierzKodBadaniaLekarz";
            this.btnWYbierzKodBadaniaLekarz.Size = new System.Drawing.Size(34, 27);
            this.btnWYbierzKodBadaniaLekarz.TabIndex = 29;
            this.btnWYbierzKodBadaniaLekarz.Text = "...";
            this.btnWYbierzKodBadaniaLekarz.UseVisualStyleBackColor = true;
            this.btnWYbierzKodBadaniaLekarz.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblStatusBadaniaLekarz
            // 
            this.lblStatusBadaniaLekarz.AutoSize = true;
            this.lblStatusBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusBadaniaLekarz.Location = new System.Drawing.Point(55, 116);
            this.lblStatusBadaniaLekarz.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusBadaniaLekarz.Name = "lblStatusBadaniaLekarz";
            this.lblStatusBadaniaLekarz.Size = new System.Drawing.Size(52, 19);
            this.lblStatusBadaniaLekarz.TabIndex = 28;
            this.lblStatusBadaniaLekarz.Text = "Status";
            // 
            // txtNazwaBadaniaLekarz
            // 
            this.txtNazwaBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaBadaniaLekarz.Location = new System.Drawing.Point(110, 80);
            this.txtNazwaBadaniaLekarz.MaxLength = 15;
            this.txtNazwaBadaniaLekarz.Name = "txtNazwaBadaniaLekarz";
            this.txtNazwaBadaniaLekarz.Size = new System.Drawing.Size(128, 27);
            this.txtNazwaBadaniaLekarz.TabIndex = 27;
            this.txtNazwaBadaniaLekarz.Text = "Rezonans";
            // 
            // lblNazwaBadaniaLekarz
            // 
            this.lblNazwaBadaniaLekarz.AutoSize = true;
            this.lblNazwaBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaBadaniaLekarz.Location = new System.Drawing.Point(53, 83);
            this.lblNazwaBadaniaLekarz.Margin = new System.Windows.Forms.Padding(0);
            this.lblNazwaBadaniaLekarz.Name = "lblNazwaBadaniaLekarz";
            this.lblNazwaBadaniaLekarz.Size = new System.Drawing.Size(54, 19);
            this.lblNazwaBadaniaLekarz.TabIndex = 26;
            this.lblNazwaBadaniaLekarz.Text = "Nazwa";
            // 
            // txtStatusBadaniaLekarz
            // 
            this.txtStatusBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStatusBadaniaLekarz.Location = new System.Drawing.Point(110, 113);
            this.txtStatusBadaniaLekarz.MaxLength = 15;
            this.txtStatusBadaniaLekarz.Name = "txtStatusBadaniaLekarz";
            this.txtStatusBadaniaLekarz.Size = new System.Drawing.Size(128, 27);
            this.txtStatusBadaniaLekarz.TabIndex = 25;
            this.txtStatusBadaniaLekarz.Text = "Rozpoczęte";
            // 
            // lblKodBadaniaLekarz
            // 
            this.lblKodBadaniaLekarz.AutoSize = true;
            this.lblKodBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodBadaniaLekarz.Location = new System.Drawing.Point(71, 50);
            this.lblKodBadaniaLekarz.Margin = new System.Windows.Forms.Padding(0);
            this.lblKodBadaniaLekarz.Name = "lblKodBadaniaLekarz";
            this.lblKodBadaniaLekarz.Size = new System.Drawing.Size(36, 19);
            this.lblKodBadaniaLekarz.TabIndex = 24;
            this.lblKodBadaniaLekarz.Text = "Kod";
            // 
            // txtIDBadaniaLekarz
            // 
            this.txtIDBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIDBadaniaLekarz.Location = new System.Drawing.Point(110, 14);
            this.txtIDBadaniaLekarz.MaxLength = 15;
            this.txtIDBadaniaLekarz.Name = "txtIDBadaniaLekarz";
            this.txtIDBadaniaLekarz.Size = new System.Drawing.Size(128, 27);
            this.txtIDBadaniaLekarz.TabIndex = 23;
            this.txtIDBadaniaLekarz.Text = "13009543";
            // 
            // lblIDBadaniaLekarz
            // 
            this.lblIDBadaniaLekarz.AutoSize = true;
            this.lblIDBadaniaLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDBadaniaLekarz.Location = new System.Drawing.Point(25, 17);
            this.lblIDBadaniaLekarz.Margin = new System.Windows.Forms.Padding(0);
            this.lblIDBadaniaLekarz.Name = "lblIDBadaniaLekarz";
            this.lblIDBadaniaLekarz.Size = new System.Drawing.Size(82, 19);
            this.lblIDBadaniaLekarz.TabIndex = 22;
            this.lblIDBadaniaLekarz.Text = "ID Badania";
            // 
            // lblUwagiLekarz
            // 
            this.lblUwagiLekarz.AutoSize = true;
            this.lblUwagiLekarz.Location = new System.Drawing.Point(338, 18);
            this.lblUwagiLekarz.Name = "lblUwagiLekarz";
            this.lblUwagiLekarz.Size = new System.Drawing.Size(64, 23);
            this.lblUwagiLekarz.TabIndex = 21;
            this.lblUwagiLekarz.Text = "Uwagi:";
            // 
            // btnZlecLekarz
            // 
            this.btnZlecLekarz.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZlecLekarz.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnZlecLekarz.FlatAppearance.BorderSize = 3;
            this.btnZlecLekarz.Location = new System.Drawing.Point(98, 150);
            this.btnZlecLekarz.Name = "btnZlecLekarz";
            this.btnZlecLekarz.Size = new System.Drawing.Size(140, 38);
            this.btnZlecLekarz.TabIndex = 20;
            this.btnZlecLekarz.Text = "Zaleć";
            this.btnZlecLekarz.UseVisualStyleBackColor = false;
            // 
            // charCounterLekarz
            // 
            this.charCounterLekarz.AutoSize = true;
            this.charCounterLekarz.Location = new System.Drawing.Point(498, 165);
            this.charCounterLekarz.Name = "charCounterLekarz";
            this.charCounterLekarz.Size = new System.Drawing.Size(76, 23);
            this.charCounterLekarz.TabIndex = 19;
            this.charCounterLekarz.Text = "23 / 150";
            // 
            // txtUwagiLekarz
            // 
            this.txtUwagiLekarz.BackColor = System.Drawing.SystemColors.Window;
            this.txtUwagiLekarz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUwagiLekarz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUwagiLekarz.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUwagiLekarz.Location = new System.Drawing.Point(342, 44);
            this.txtUwagiLekarz.MaxLength = 150;
            this.txtUwagiLekarz.Multiline = true;
            this.txtUwagiLekarz.Name = "txtUwagiLekarz";
            this.txtUwagiLekarz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUwagiLekarz.Size = new System.Drawing.Size(232, 118);
            this.txtUwagiLekarz.TabIndex = 18;
            this.txtUwagiLekarz.Text = "Pacjenta boli noga.";
            // 
            // tabPage2
            // 
            this.tabLab.BackColor = System.Drawing.Color.LightGray;
            this.tabLab.Controls.Add(this.txtKodBadaniaLab);
            this.tabLab.Controls.Add(this.lblStatusBadaniaLab);
            this.tabLab.Controls.Add(this.txtNazwaBadaniaLab);
            this.tabLab.Controls.Add(this.lblNazwaBadaniaLab);
            this.tabLab.Controls.Add(this.txtStatusBadaniaLab);
            this.tabLab.Controls.Add(this.lblKodBadaniaLab);
            this.tabLab.Controls.Add(this.txtIDBadaniaLab);
            this.tabLab.Controls.Add(this.lblIDBadaniaLab);
            this.tabLab.Controls.Add(this.lblWynikiLab);
            this.tabLab.Controls.Add(this.btnZatwierdzLab);
            this.tabLab.Controls.Add(this.btnAnulujLab);
            this.tabLab.Controls.Add(this.charCounterLab);
            this.tabLab.Controls.Add(this.txtWynikiLab);
            this.tabLab.Location = new System.Drawing.Point(4, 32);
            this.tabLab.Name = "tabPage2";
            this.tabLab.Padding = new System.Windows.Forms.Padding(3);
            this.tabLab.Size = new System.Drawing.Size(598, 202);
            this.tabLab.TabIndex = 1;
            this.tabLab.Text = "Laborant";
            // 
            // txtKodBadaniaLab
            // 
            this.txtKodBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKodBadaniaLab.Location = new System.Drawing.Point(116, 45);
            this.txtKodBadaniaLab.MaxLength = 15;
            this.txtKodBadaniaLab.Name = "txtKodBadaniaLab";
            this.txtKodBadaniaLab.Size = new System.Drawing.Size(128, 27);
            this.txtKodBadaniaLab.TabIndex = 18;
            this.txtKodBadaniaLab.Text = "Bx0098";
            // 
            // lblStatusBadaniaLab
            // 
            this.lblStatusBadaniaLab.AutoSize = true;
            this.lblStatusBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusBadaniaLab.Location = new System.Drawing.Point(61, 114);
            this.lblStatusBadaniaLab.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusBadaniaLab.Name = "lblStatusBadaniaLab";
            this.lblStatusBadaniaLab.Size = new System.Drawing.Size(52, 19);
            this.lblStatusBadaniaLab.TabIndex = 17;
            this.lblStatusBadaniaLab.Text = "Status";
            // 
            // txtNazwaBadaniaLab
            // 
            this.txtNazwaBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaBadaniaLab.Location = new System.Drawing.Point(116, 78);
            this.txtNazwaBadaniaLab.MaxLength = 15;
            this.txtNazwaBadaniaLab.Name = "txtNazwaBadaniaLab";
            this.txtNazwaBadaniaLab.Size = new System.Drawing.Size(128, 27);
            this.txtNazwaBadaniaLab.TabIndex = 16;
            this.txtNazwaBadaniaLab.Text = "Rezonans";
            // 
            // lblNazwaBadaniaLab
            // 
            this.lblNazwaBadaniaLab.AutoSize = true;
            this.lblNazwaBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaBadaniaLab.Location = new System.Drawing.Point(59, 81);
            this.lblNazwaBadaniaLab.Margin = new System.Windows.Forms.Padding(0);
            this.lblNazwaBadaniaLab.Name = "lblNazwaBadaniaLab";
            this.lblNazwaBadaniaLab.Size = new System.Drawing.Size(54, 19);
            this.lblNazwaBadaniaLab.TabIndex = 15;
            this.lblNazwaBadaniaLab.Text = "Nazwa";
            // 
            // txtStatusBadaniaLab
            // 
            this.txtStatusBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStatusBadaniaLab.Location = new System.Drawing.Point(116, 111);
            this.txtStatusBadaniaLab.MaxLength = 15;
            this.txtStatusBadaniaLab.Name = "txtStatusBadaniaLab";
            this.txtStatusBadaniaLab.Size = new System.Drawing.Size(128, 27);
            this.txtStatusBadaniaLab.TabIndex = 14;
            this.txtStatusBadaniaLab.Text = "Rozpoczęte";
            // 
            // lblKodBadaniaLab
            // 
            this.lblKodBadaniaLab.AutoSize = true;
            this.lblKodBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodBadaniaLab.Location = new System.Drawing.Point(77, 48);
            this.lblKodBadaniaLab.Margin = new System.Windows.Forms.Padding(0);
            this.lblKodBadaniaLab.Name = "lblKodBadaniaLab";
            this.lblKodBadaniaLab.Size = new System.Drawing.Size(36, 19);
            this.lblKodBadaniaLab.TabIndex = 13;
            this.lblKodBadaniaLab.Text = "Kod";
            // 
            // txtIDBadaniaLab
            // 
            this.txtIDBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIDBadaniaLab.Location = new System.Drawing.Point(116, 12);
            this.txtIDBadaniaLab.MaxLength = 15;
            this.txtIDBadaniaLab.Name = "txtIDBadaniaLab";
            this.txtIDBadaniaLab.Size = new System.Drawing.Size(128, 27);
            this.txtIDBadaniaLab.TabIndex = 12;
            this.txtIDBadaniaLab.Text = "13009543";
            // 
            // lblIDBadaniaLab
            // 
            this.lblIDBadaniaLab.AutoSize = true;
            this.lblIDBadaniaLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDBadaniaLab.Location = new System.Drawing.Point(31, 15);
            this.lblIDBadaniaLab.Margin = new System.Windows.Forms.Padding(0);
            this.lblIDBadaniaLab.Name = "lblIDBadaniaLab";
            this.lblIDBadaniaLab.Size = new System.Drawing.Size(82, 19);
            this.lblIDBadaniaLab.TabIndex = 10;
            this.lblIDBadaniaLab.Text = "ID Badania";
            // 
            // lblWynikiLab
            // 
            this.lblWynikiLab.AutoSize = true;
            this.lblWynikiLab.Location = new System.Drawing.Point(344, 16);
            this.lblWynikiLab.Name = "lblWynikiLab";
            this.lblWynikiLab.Size = new System.Drawing.Size(70, 23);
            this.lblWynikiLab.TabIndex = 9;
            this.lblWynikiLab.Text = "Wyniki:";
            // 
            // btnZatwierdzLab
            // 
            this.btnZatwierdzLab.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZatwierdzLab.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnZatwierdzLab.FlatAppearance.BorderSize = 3;
            this.btnZatwierdzLab.Location = new System.Drawing.Point(35, 148);
            this.btnZatwierdzLab.Name = "btnZatwierdzLab";
            this.btnZatwierdzLab.Size = new System.Drawing.Size(140, 38);
            this.btnZatwierdzLab.TabIndex = 8;
            this.btnZatwierdzLab.Text = "Zatwierdź";
            this.btnZatwierdzLab.UseVisualStyleBackColor = false;
            // 
            // btnAnulujLab
            // 
            this.btnAnulujLab.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnulujLab.Location = new System.Drawing.Point(181, 148);
            this.btnAnulujLab.Name = "btnAnulujLab";
            this.btnAnulujLab.Size = new System.Drawing.Size(140, 38);
            this.btnAnulujLab.TabIndex = 7;
            this.btnAnulujLab.Text = "Anuluj";
            this.btnAnulujLab.UseVisualStyleBackColor = false;
            // 
            // charCounterLab
            // 
            this.charCounterLab.AutoSize = true;
            this.charCounterLab.Location = new System.Drawing.Point(504, 163);
            this.charCounterLab.Name = "charCounterLab";
            this.charCounterLab.Size = new System.Drawing.Size(76, 23);
            this.charCounterLab.TabIndex = 6;
            this.charCounterLab.Text = "23 / 150";
            // 
            // txtWynikiLab
            // 
            this.txtWynikiLab.BackColor = System.Drawing.SystemColors.Window;
            this.txtWynikiLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWynikiLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWynikiLab.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtWynikiLab.Location = new System.Drawing.Point(348, 42);
            this.txtWynikiLab.MaxLength = 150;
            this.txtWynikiLab.Multiline = true;
            this.txtWynikiLab.Name = "txtWynikiLab";
            this.txtWynikiLab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWynikiLab.Size = new System.Drawing.Size(232, 118);
            this.txtWynikiLab.TabIndex = 5;
            this.txtWynikiLab.Text = "Przeprowadzono badanie.";
            this.txtWynikiLab.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabPage3
            // 
            this.tabKlab.BackColor = System.Drawing.Color.LightGray;
            this.tabKlab.Controls.Add(this.lblInfoBadanie);
            this.tabKlab.Controls.Add(this.lblUwagiKLab);
            this.tabKlab.Controls.Add(this.btnZatwierdzKLab);
            this.tabKlab.Controls.Add(this.btnAnulujKLab);
            this.tabKlab.Controls.Add(this.charCounterKLab);
            this.tabKlab.Controls.Add(this.txtUwagiKLab);
            this.tabKlab.Location = new System.Drawing.Point(4, 32);
            this.tabKlab.Name = "tabPage3";
            this.tabKlab.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlab.Size = new System.Drawing.Size(598, 202);
            this.tabKlab.TabIndex = 2;
            this.tabKlab.Text = "K. Lab.";
            // 
            // lblInfoBadanie
            // 
            this.lblInfoBadanie.AutoSize = true;
            this.lblInfoBadanie.Location = new System.Drawing.Point(83, 44);
            this.lblInfoBadanie.Name = "lblInfoBadanie";
            this.lblInfoBadanie.Size = new System.Drawing.Size(194, 46);
            this.lblInfoBadanie.TabIndex = 5;
            this.lblInfoBadanie.Text = "Badanie nr. 2300456\r\nRezonans magnetyczny";
            this.lblInfoBadanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUwagiKLab
            // 
            this.lblUwagiKLab.AutoSize = true;
            this.lblUwagiKLab.Location = new System.Drawing.Point(347, 19);
            this.lblUwagiKLab.Name = "lblUwagiKLab";
            this.lblUwagiKLab.Size = new System.Drawing.Size(64, 23);
            this.lblUwagiKLab.TabIndex = 4;
            this.lblUwagiKLab.Text = "Uwagi:";
            // 
            // btnZatwierdzKLab
            // 
            this.btnZatwierdzKLab.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZatwierdzKLab.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnZatwierdzKLab.FlatAppearance.BorderSize = 3;
            this.btnZatwierdzKLab.Location = new System.Drawing.Point(21, 105);
            this.btnZatwierdzKLab.Name = "btnZatwierdzKLab";
            this.btnZatwierdzKLab.Size = new System.Drawing.Size(140, 58);
            this.btnZatwierdzKLab.TabIndex = 3;
            this.btnZatwierdzKLab.Text = "Zatwierdź";
            this.btnZatwierdzKLab.UseVisualStyleBackColor = false;
            // 
            // btnAnulujKLab
            // 
            this.btnAnulujKLab.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnulujKLab.Location = new System.Drawing.Point(184, 105);
            this.btnAnulujKLab.Name = "btnAnulujKLab";
            this.btnAnulujKLab.Size = new System.Drawing.Size(140, 58);
            this.btnAnulujKLab.TabIndex = 2;
            this.btnAnulujKLab.Text = "Anuluj";
            this.btnAnulujKLab.UseVisualStyleBackColor = false;
            // 
            // charCounterKLab
            // 
            this.charCounterKLab.AutoSize = true;
            this.charCounterKLab.Location = new System.Drawing.Point(507, 166);
            this.charCounterKLab.Name = "charCounterKLab";
            this.charCounterKLab.Size = new System.Drawing.Size(76, 23);
            this.charCounterKLab.TabIndex = 1;
            this.charCounterKLab.Text = "19 / 150";
            // 
            // txtUwagiKLab
            // 
            this.txtUwagiKLab.BackColor = System.Drawing.SystemColors.Window;
            this.txtUwagiKLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUwagiKLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUwagiKLab.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUwagiKLab.Location = new System.Drawing.Point(351, 45);
            this.txtUwagiKLab.MaxLength = 150;
            this.txtUwagiKLab.Multiline = true;
            this.txtUwagiKLab.Name = "txtUwagiKLab";
            this.txtUwagiKLab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUwagiKLab.Size = new System.Drawing.Size(232, 118);
            this.txtUwagiKLab.TabIndex = 0;
            this.txtUwagiKLab.Text = "Nieczytelne wyniki.";
            this.txtUwagiKLab.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmLaboratorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 262);
            this.Controls.Add(this.Tab);
            this.Name = "frmLaboratorium";
            this.Text = "Laboratorium";
            this.Tab.ResumeLayout(false);
            this.tabLekarz.ResumeLayout(false);
            this.tabLekarz.PerformLayout();
            this.tabLab.ResumeLayout(false);
            this.tabLab.PerformLayout();
            this.tabKlab.ResumeLayout(false);
            this.tabKlab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabLekarz;
        private System.Windows.Forms.TabPage tabLab;
        private System.Windows.Forms.TabPage tabKlab;
        private System.Windows.Forms.TextBox txtUwagiKLab;
        private System.Windows.Forms.Label charCounterKLab;
        private System.Windows.Forms.Button btnZatwierdzKLab;
        private System.Windows.Forms.Button btnAnulujKLab;
        private System.Windows.Forms.Label lblUwagiKLab;
        private System.Windows.Forms.Label lblInfoBadanie;
        private System.Windows.Forms.Label lblWynikiLab;
        private System.Windows.Forms.Button btnZatwierdzLab;
        private System.Windows.Forms.Button btnAnulujLab;
        private System.Windows.Forms.Label charCounterLab;
        private System.Windows.Forms.TextBox txtWynikiLab;
        private System.Windows.Forms.TextBox txtIDBadaniaLab;
        private System.Windows.Forms.Label lblIDBadaniaLab;
        private System.Windows.Forms.TextBox txtKodBadaniaLab;
        private System.Windows.Forms.Label lblStatusBadaniaLab;
        private System.Windows.Forms.TextBox txtNazwaBadaniaLab;
        private System.Windows.Forms.Label lblNazwaBadaniaLab;
        private System.Windows.Forms.TextBox txtStatusBadaniaLab;
        private System.Windows.Forms.Label lblKodBadaniaLab;
        private System.Windows.Forms.Label lblStatusBadaniaLekarz;
        private System.Windows.Forms.TextBox txtNazwaBadaniaLekarz;
        private System.Windows.Forms.Label lblNazwaBadaniaLekarz;
        private System.Windows.Forms.TextBox txtStatusBadaniaLekarz;
        private System.Windows.Forms.Label lblKodBadaniaLekarz;
        private System.Windows.Forms.TextBox txtIDBadaniaLekarz;
        private System.Windows.Forms.Label lblIDBadaniaLekarz;
        private System.Windows.Forms.Label lblUwagiLekarz;
        private System.Windows.Forms.Button btnZlecLekarz;
        private System.Windows.Forms.Label charCounterLekarz;
        private System.Windows.Forms.TextBox txtUwagiLekarz;
        private System.Windows.Forms.TextBox txtKodBadaniaLekarz;
        private System.Windows.Forms.Button btnWYbierzKodBadaniaLekarz;
    }
}