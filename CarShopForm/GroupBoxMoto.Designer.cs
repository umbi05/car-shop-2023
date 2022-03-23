namespace CarShopForm
{
    partial class GroupBoxMoto
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
            this.grpMoto = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.numCilindri = new System.Windows.Forms.NumericUpDown();
            this.numTempi = new System.Windows.Forms.NumericUpDown();
            this.chkAbs = new System.Windows.Forms.CheckBox();
            this.chkCts = new System.Windows.Forms.CheckBox();
            this.chkBauletto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpMoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCilindri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMoto
            // 
            this.grpMoto.Controls.Add(this.label3);
            this.grpMoto.Controls.Add(this.label2);
            this.grpMoto.Controls.Add(this.label1);
            this.grpMoto.Controls.Add(this.chkBauletto);
            this.grpMoto.Controls.Add(this.chkCts);
            this.grpMoto.Controls.Add(this.chkAbs);
            this.grpMoto.Controls.Add(this.numTempi);
            this.grpMoto.Controls.Add(this.numCilindri);
            this.grpMoto.Controls.Add(this.cmbTipo);
            this.grpMoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMoto.Location = new System.Drawing.Point(0, 0);
            this.grpMoto.Name = "grpMoto";
            this.grpMoto.Size = new System.Drawing.Size(172, 248);
            this.grpMoto.TabIndex = 0;
            this.grpMoto.TabStop = false;
            this.grpMoto.Text = "Moto";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(45, 41);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // numCilindri
            // 
            this.numCilindri.Location = new System.Drawing.Point(65, 83);
            this.numCilindri.Name = "numCilindri";
            this.numCilindri.Size = new System.Drawing.Size(75, 20);
            this.numCilindri.TabIndex = 1;
            this.numCilindri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numTempi
            // 
            this.numTempi.Location = new System.Drawing.Point(65, 121);
            this.numTempi.Name = "numTempi";
            this.numTempi.Size = new System.Drawing.Size(75, 20);
            this.numTempi.TabIndex = 2;
            this.numTempi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkAbs
            // 
            this.chkAbs.AutoSize = true;
            this.chkAbs.Location = new System.Drawing.Point(9, 161);
            this.chkAbs.Name = "chkAbs";
            this.chkAbs.Size = new System.Drawing.Size(47, 17);
            this.chkAbs.TabIndex = 3;
            this.chkAbs.Text = "ABS";
            this.chkAbs.UseVisualStyleBackColor = true;
            // 
            // chkCts
            // 
            this.chkCts.AutoSize = true;
            this.chkCts.Location = new System.Drawing.Point(9, 193);
            this.chkCts.Name = "chkCts";
            this.chkCts.Size = new System.Drawing.Size(47, 17);
            this.chkCts.TabIndex = 4;
            this.chkCts.Text = "CTS";
            this.chkCts.UseVisualStyleBackColor = true;
            // 
            // chkBauletto
            // 
            this.chkBauletto.AutoSize = true;
            this.chkBauletto.Location = new System.Drawing.Point(9, 225);
            this.chkBauletto.Name = "chkBauletto";
            this.chkBauletto.Size = new System.Drawing.Size(65, 17);
            this.chkBauletto.TabIndex = 5;
            this.chkBauletto.Text = "Bauletto";
            this.chkBauletto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cilindri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempi:";
            // 
            // GroupBoxMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMoto);
            this.Name = "GroupBoxMoto";
            this.Size = new System.Drawing.Size(172, 248);
            this.grpMoto.ResumeLayout(false);
            this.grpMoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCilindri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMoto;
        private System.Windows.Forms.CheckBox chkBauletto;
        private System.Windows.Forms.CheckBox chkCts;
        private System.Windows.Forms.CheckBox chkAbs;
        private System.Windows.Forms.NumericUpDown numTempi;
        private System.Windows.Forms.NumericUpDown numCilindri;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
