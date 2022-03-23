namespace CarShopForm
{
    partial class GroupBoxAuto
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAuto = new System.Windows.Forms.GroupBox();
            this.chkCabrio = new System.Windows.Forms.CheckBox();
            this.chkFendinebbia = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPorte = new System.Windows.Forms.NumericUpDown();
            this.numCerchi = new System.Windows.Forms.NumericUpDown();
            this.txtAllestimento = new System.Windows.Forms.TextBox();
            this.cmbTrazione = new System.Windows.Forms.ComboBox();
            this.grpAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCerchi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAuto
            // 
            this.grpAuto.Controls.Add(this.cmbTrazione);
            this.grpAuto.Controls.Add(this.txtAllestimento);
            this.grpAuto.Controls.Add(this.numCerchi);
            this.grpAuto.Controls.Add(this.numPorte);
            this.grpAuto.Controls.Add(this.label1);
            this.grpAuto.Controls.Add(this.label2);
            this.grpAuto.Controls.Add(this.label3);
            this.grpAuto.Controls.Add(this.label4);
            this.grpAuto.Controls.Add(this.chkFendinebbia);
            this.grpAuto.Controls.Add(this.chkCabrio);
            this.grpAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAuto.Location = new System.Drawing.Point(0, 0);
            this.grpAuto.Name = "grpAuto";
            this.grpAuto.Size = new System.Drawing.Size(172, 248);
            this.grpAuto.TabIndex = 0;
            this.grpAuto.TabStop = false;
            this.grpAuto.Text = "Auto";
            // 
            // chkCabrio
            // 
            this.chkCabrio.AutoSize = true;
            this.chkCabrio.Location = new System.Drawing.Point(6, 19);
            this.chkCabrio.Name = "chkCabrio";
            this.chkCabrio.Size = new System.Drawing.Size(56, 17);
            this.chkCabrio.TabIndex = 0;
            this.chkCabrio.Text = "Cabrio";
            this.chkCabrio.UseVisualStyleBackColor = true;
            // 
            // chkFendinebbia
            // 
            this.chkFendinebbia.AutoSize = true;
            this.chkFendinebbia.Location = new System.Drawing.Point(6, 42);
            this.chkFendinebbia.Name = "chkFendinebbia";
            this.chkFendinebbia.Size = new System.Drawing.Size(84, 17);
            this.chkFendinebbia.TabIndex = 1;
            this.chkFendinebbia.Text = "Fendinebbia";
            this.chkFendinebbia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diametro Cerchi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero Porte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Allestimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trazione:";
            // 
            // numPorte
            // 
            this.numPorte.Location = new System.Drawing.Point(94, 100);
            this.numPorte.Name = "numPorte";
            this.numPorte.Size = new System.Drawing.Size(68, 20);
            this.numPorte.TabIndex = 5;
            this.numPorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numCerchi
            // 
            this.numCerchi.Location = new System.Drawing.Point(94, 75);
            this.numCerchi.Name = "numCerchi";
            this.numCerchi.Size = new System.Drawing.Size(68, 20);
            this.numCerchi.TabIndex = 6;
            this.numCerchi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAllestimento
            // 
            this.txtAllestimento.Location = new System.Drawing.Point(6, 152);
            this.txtAllestimento.Multiline = true;
            this.txtAllestimento.Name = "txtAllestimento";
            this.txtAllestimento.Size = new System.Drawing.Size(156, 34);
            this.txtAllestimento.TabIndex = 7;
            // 
            // cmbTrazione
            // 
            this.cmbTrazione.FormattingEnabled = true;
            this.cmbTrazione.Location = new System.Drawing.Point(56, 214);
            this.cmbTrazione.Name = "cmbTrazione";
            this.cmbTrazione.Size = new System.Drawing.Size(106, 21);
            this.cmbTrazione.TabIndex = 8;
            // 
            // GroupBoxAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpAuto);
            this.Name = "GroupBoxAuto";
            this.Size = new System.Drawing.Size(172, 248);
            this.grpAuto.ResumeLayout(false);
            this.grpAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCerchi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAuto;
        private System.Windows.Forms.NumericUpDown numCerchi;
        private System.Windows.Forms.NumericUpDown numPorte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFendinebbia;
        private System.Windows.Forms.CheckBox chkCabrio;
        private System.Windows.Forms.ComboBox cmbTrazione;
        private System.Windows.Forms.TextBox txtAllestimento;
    }
}
