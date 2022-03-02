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
            this.lstVeicoli = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVeicoli
            // 
            this.lstVeicoli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVeicoli.FormattingEnabled = true;
            this.lstVeicoli.Location = new System.Drawing.Point(0, 0);
            this.lstVeicoli.Name = "lstVeicoli";
            this.lstVeicoli.Size = new System.Drawing.Size(784, 461);
            this.lstVeicoli.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lstVeicoli);
            this.Name = "FormMain";
            this.Text = "RIVENDITA VEICOLI VALLAURI";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeicoli;
    }
}

