namespace CarShopForm
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsdShowSelected = new System.Windows.Forms.ToolStripDropDownButton();
            this.aUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fURGONEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslMarca = new System.Windows.Forms.ToolStripLabel();
            this.tstMarca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonAddItem = new System.Windows.Forms.ToolStripSplitButton();
            this.nuovaAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaMotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoFurgoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVeicoli = new System.Windows.Forms.DataGridView();
            this.groupBoxVeicolo = new System.Windows.Forms.GroupBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbFurgoni = new System.Windows.Forms.RadioButton();
            this.rdbMoto = new System.Windows.Forms.RadioButton();
            this.rdbAuto = new System.Windows.Forms.RadioButton();
            this.chkAutomatica = new System.Windows.Forms.CheckBox();
            this.cmbAlimentazione = new System.Windows.Forms.ComboBox();
            this.dateImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.numPrezzo = new System.Windows.Forms.NumericUpDown();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblDataImmatricolazione = new System.Windows.Forms.Label();
            this.lblAlimentazione = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblTarga = new System.Windows.Forms.Label();
            this.lblColore = new System.Windows.Forms.Label();
            this.lblModello = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeicoli)).BeginInit();
            this.groupBoxVeicolo.SuspendLayout();
            this.grpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdShowSelected,
            this.toolStripSeparator1,
            this.tslMarca,
            this.tstMarca,
            this.toolStripSeparator2,
            this.toolStripSplitButtonAddItem});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(784, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsdShowSelected
            // 
            this.tsdShowSelected.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTOToolStripMenuItem,
            this.mOTOToolStripMenuItem,
            this.fURGONEToolStripMenuItem});
            this.tsdShowSelected.Image = ((System.Drawing.Image)(resources.GetObject("tsdShowSelected.Image")));
            this.tsdShowSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdShowSelected.Name = "tsdShowSelected";
            this.tsdShowSelected.Size = new System.Drawing.Size(66, 22);
            this.tsdShowSelected.Text = "AUTO";
            // 
            // aUTOToolStripMenuItem
            // 
            this.aUTOToolStripMenuItem.Name = "aUTOToolStripMenuItem";
            this.aUTOToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aUTOToolStripMenuItem.Text = "AUTO";
            this.aUTOToolStripMenuItem.Click += new System.EventHandler(this.aUTOToolStripMenuItem_Click);
            // 
            // mOTOToolStripMenuItem
            // 
            this.mOTOToolStripMenuItem.Name = "mOTOToolStripMenuItem";
            this.mOTOToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.mOTOToolStripMenuItem.Text = "MOTO";
            this.mOTOToolStripMenuItem.Click += new System.EventHandler(this.mOTOToolStripMenuItem_Click);
            // 
            // fURGONEToolStripMenuItem
            // 
            this.fURGONEToolStripMenuItem.Name = "fURGONEToolStripMenuItem";
            this.fURGONEToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fURGONEToolStripMenuItem.Text = "FURGONE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslMarca
            // 
            this.tslMarca.Name = "tslMarca";
            this.tslMarca.Size = new System.Drawing.Size(43, 22);
            this.tslMarca.Text = "Marca:";
            // 
            // tstMarca
            // 
            this.tstMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstMarca.Name = "tstMarca";
            this.tstMarca.Size = new System.Drawing.Size(100, 25);
            this.tstMarca.TextChanged += new System.EventHandler(this.tstMarca_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButtonAddItem
            // 
            this.toolStripSplitButtonAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonAddItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaAutoToolStripMenuItem,
            this.nuovaMotoToolStripMenuItem,
            this.nuovoFurgoneToolStripMenuItem});
            this.toolStripSplitButtonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonAddItem.Image")));
            this.toolStripSplitButtonAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonAddItem.Name = "toolStripSplitButtonAddItem";
            this.toolStripSplitButtonAddItem.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonAddItem.Text = "toolStripSplitButton1";
            this.toolStripSplitButtonAddItem.ButtonClick += new System.EventHandler(this.toolStripSplitButtonAddItem_ButtonClick);
            // 
            // nuovaAutoToolStripMenuItem
            // 
            this.nuovaAutoToolStripMenuItem.Name = "nuovaAutoToolStripMenuItem";
            this.nuovaAutoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuovaAutoToolStripMenuItem.Text = "Nuova Auto";
            this.nuovaAutoToolStripMenuItem.Click += new System.EventHandler(this.nuovaAutoToolStripMenuItem_Click);
            // 
            // nuovaMotoToolStripMenuItem
            // 
            this.nuovaMotoToolStripMenuItem.Name = "nuovaMotoToolStripMenuItem";
            this.nuovaMotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuovaMotoToolStripMenuItem.Text = "Nuova Moto";
            this.nuovaMotoToolStripMenuItem.Click += new System.EventHandler(this.nuovaMotoToolStripMenuItem_Click);
            // 
            // nuovoFurgoneToolStripMenuItem
            // 
            this.nuovoFurgoneToolStripMenuItem.Name = "nuovoFurgoneToolStripMenuItem";
            this.nuovoFurgoneToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuovoFurgoneToolStripMenuItem.Text = "Nuovo Furgone";
            // 
            // dgvVeicoli
            // 
            this.dgvVeicoli.AllowUserToAddRows = false;
            this.dgvVeicoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeicoli.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVeicoli.Location = new System.Drawing.Point(0, 25);
            this.dgvVeicoli.MultiSelect = false;
            this.dgvVeicoli.Name = "dgvVeicoli";
            this.dgvVeicoli.ReadOnly = true;
            this.dgvVeicoli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeicoli.Size = new System.Drawing.Size(784, 228);
            this.dgvVeicoli.TabIndex = 1;
            this.dgvVeicoli.SelectionChanged += new System.EventHandler(this.dgvVeicoli_SelectionChanged);
            // 
            // groupBoxVeicolo
            // 
            this.groupBoxVeicolo.Controls.Add(this.btnSalva);
            this.groupBoxVeicolo.Controls.Add(this.grpTipo);
            this.groupBoxVeicolo.Controls.Add(this.chkAutomatica);
            this.groupBoxVeicolo.Controls.Add(this.cmbAlimentazione);
            this.groupBoxVeicolo.Controls.Add(this.dateImmatricolazione);
            this.groupBoxVeicolo.Controls.Add(this.numPrezzo);
            this.groupBoxVeicolo.Controls.Add(this.lblPrezzo);
            this.groupBoxVeicolo.Controls.Add(this.lblDataImmatricolazione);
            this.groupBoxVeicolo.Controls.Add(this.lblAlimentazione);
            this.groupBoxVeicolo.Controls.Add(this.txtDescrizione);
            this.groupBoxVeicolo.Controls.Add(this.txtTarga);
            this.groupBoxVeicolo.Controls.Add(this.txtModello);
            this.groupBoxVeicolo.Controls.Add(this.txtColore);
            this.groupBoxVeicolo.Controls.Add(this.txtMarca);
            this.groupBoxVeicolo.Controls.Add(this.lblDescrizione);
            this.groupBoxVeicolo.Controls.Add(this.lblTarga);
            this.groupBoxVeicolo.Controls.Add(this.lblColore);
            this.groupBoxVeicolo.Controls.Add(this.lblModello);
            this.groupBoxVeicolo.Controls.Add(this.lblMarca);
            this.groupBoxVeicolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVeicolo.Location = new System.Drawing.Point(0, 253);
            this.groupBoxVeicolo.Name = "groupBoxVeicolo";
            this.groupBoxVeicolo.Size = new System.Drawing.Size(784, 281);
            this.groupBoxVeicolo.TabIndex = 2;
            this.groupBoxVeicolo.TabStop = false;
            this.groupBoxVeicolo.Text = "Veicolo";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(12, 246);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(307, 23);
            this.btnSalva.TabIndex = 14;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbFurgoni);
            this.grpTipo.Controls.Add(this.rdbMoto);
            this.grpTipo.Controls.Add(this.rdbAuto);
            this.grpTipo.Location = new System.Drawing.Point(344, 210);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(200, 42);
            this.grpTipo.TabIndex = 3;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdbFurgoni
            // 
            this.rdbFurgoni.AutoCheck = false;
            this.rdbFurgoni.AutoSize = true;
            this.rdbFurgoni.Location = new System.Drawing.Point(120, 16);
            this.rdbFurgoni.Name = "rdbFurgoni";
            this.rdbFurgoni.Size = new System.Drawing.Size(78, 17);
            this.rdbFurgoni.TabIndex = 2;
            this.rdbFurgoni.TabStop = true;
            this.rdbFurgoni.Text = "FURGONE";
            this.rdbFurgoni.UseVisualStyleBackColor = true;
            this.rdbFurgoni.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // rdbMoto
            // 
            this.rdbMoto.AutoCheck = false;
            this.rdbMoto.AutoSize = true;
            this.rdbMoto.Location = new System.Drawing.Point(61, 16);
            this.rdbMoto.Name = "rdbMoto";
            this.rdbMoto.Size = new System.Drawing.Size(57, 17);
            this.rdbMoto.TabIndex = 1;
            this.rdbMoto.TabStop = true;
            this.rdbMoto.Text = "MOTO";
            this.rdbMoto.UseVisualStyleBackColor = true;
            this.rdbMoto.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // rdbAuto
            // 
            this.rdbAuto.AutoCheck = false;
            this.rdbAuto.AutoSize = true;
            this.rdbAuto.Location = new System.Drawing.Point(4, 16);
            this.rdbAuto.Name = "rdbAuto";
            this.rdbAuto.Size = new System.Drawing.Size(55, 17);
            this.rdbAuto.TabIndex = 0;
            this.rdbAuto.TabStop = true;
            this.rdbAuto.Text = "AUTO";
            this.rdbAuto.UseVisualStyleBackColor = true;
            this.rdbAuto.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // chkAutomatica
            // 
            this.chkAutomatica.AutoSize = true;
            this.chkAutomatica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutomatica.Location = new System.Drawing.Point(446, 173);
            this.chkAutomatica.Name = "chkAutomatica";
            this.chkAutomatica.Size = new System.Drawing.Size(96, 17);
            this.chkAutomatica.TabIndex = 13;
            this.chkAutomatica.Text = "AUTOMATICA";
            this.chkAutomatica.UseVisualStyleBackColor = true;
            // 
            // cmbAlimentazione
            // 
            this.cmbAlimentazione.FormattingEnabled = true;
            this.cmbAlimentazione.Location = new System.Drawing.Point(417, 125);
            this.cmbAlimentazione.Name = "cmbAlimentazione";
            this.cmbAlimentazione.Size = new System.Drawing.Size(125, 21);
            this.cmbAlimentazione.TabIndex = 12;
            // 
            // dateImmatricolazione
            // 
            this.dateImmatricolazione.Location = new System.Drawing.Point(342, 80);
            this.dateImmatricolazione.Name = "dateImmatricolazione";
            this.dateImmatricolazione.Size = new System.Drawing.Size(200, 20);
            this.dateImmatricolazione.TabIndex = 11;
            // 
            // numPrezzo
            // 
            this.numPrezzo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrezzo.Location = new System.Drawing.Point(386, 23);
            this.numPrezzo.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numPrezzo.Name = "numPrezzo";
            this.numPrezzo.Size = new System.Drawing.Size(79, 20);
            this.numPrezzo.TabIndex = 10;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(341, 25);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(39, 13);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblDataImmatricolazione
            // 
            this.lblDataImmatricolazione.AutoSize = true;
            this.lblDataImmatricolazione.Location = new System.Drawing.Point(341, 64);
            this.lblDataImmatricolazione.Name = "lblDataImmatricolazione";
            this.lblDataImmatricolazione.Size = new System.Drawing.Size(111, 13);
            this.lblDataImmatricolazione.TabIndex = 4;
            this.lblDataImmatricolazione.Text = "Data Immatricolazione";
            // 
            // lblAlimentazione
            // 
            this.lblAlimentazione.AutoSize = true;
            this.lblAlimentazione.Location = new System.Drawing.Point(341, 128);
            this.lblAlimentazione.Name = "lblAlimentazione";
            this.lblAlimentazione.Size = new System.Drawing.Size(72, 13);
            this.lblAlimentazione.TabIndex = 5;
            this.lblAlimentazione.Text = "Alimentazione";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(74, 108);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(245, 82);
            this.txtDescrizione.TabIndex = 9;
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(219, 61);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(100, 20);
            this.txtTarga.TabIndex = 8;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(56, 61);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(100, 20);
            this.txtModello.TabIndex = 7;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(219, 23);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(56, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(6, 108);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(62, 13);
            this.lblDescrizione.TabIndex = 4;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblTarga
            // 
            this.lblTarga.AutoSize = true;
            this.lblTarga.Location = new System.Drawing.Point(176, 64);
            this.lblTarga.Name = "lblTarga";
            this.lblTarga.Size = new System.Drawing.Size(35, 13);
            this.lblTarga.TabIndex = 3;
            this.lblTarga.Text = "Targa";
            // 
            // lblColore
            // 
            this.lblColore.AutoSize = true;
            this.lblColore.Location = new System.Drawing.Point(176, 27);
            this.lblColore.Name = "lblColore";
            this.lblColore.Size = new System.Drawing.Size(37, 13);
            this.lblColore.TabIndex = 2;
            this.lblColore.Text = "Colore";
            // 
            // lblModello
            // 
            this.lblModello.AutoSize = true;
            this.lblModello.Location = new System.Drawing.Point(3, 64);
            this.lblModello.Name = "lblModello";
            this.lblModello.Size = new System.Drawing.Size(44, 13);
            this.lblModello.TabIndex = 1;
            this.lblModello.Text = "Modello";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(3, 27);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.groupBoxVeicolo);
            this.Controls.Add(this.dgvVeicoli);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormMain";
            this.Text = "RIVENDITA VEICOLI VALLAURI";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeicoli)).EndInit();
            this.groupBoxVeicolo.ResumeLayout(false);
            this.groupBoxVeicolo.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslMarca;
        private System.Windows.Forms.ToolStripTextBox tstMarca;
        private System.Windows.Forms.DataGridView dgvVeicoli;
        private System.Windows.Forms.ToolStripDropDownButton tsdShowSelected;
        private System.Windows.Forms.ToolStripMenuItem aUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fURGONEToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxVeicolo;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblTarga;
        private System.Windows.Forms.Label lblColore;
        private System.Windows.Forms.Label lblModello;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.CheckBox chkAutomatica;
        private System.Windows.Forms.ComboBox cmbAlimentazione;
        private System.Windows.Forms.DateTimePicker dateImmatricolazione;
        private System.Windows.Forms.NumericUpDown numPrezzo;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblDataImmatricolazione;
        private System.Windows.Forms.Label lblAlimentazione;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbFurgoni;
        private System.Windows.Forms.RadioButton rdbMoto;
        private System.Windows.Forms.RadioButton rdbAuto;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonAddItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaMotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoFurgoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnSalva;
    }
}

