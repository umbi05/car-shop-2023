using CarShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWinForm
{
    public partial class FormMain : Form
    {
        List<Veicolo> parcoMezzi;
        DbTools dbTools;
        public FormMain()
        {
            InitializeComponent();
            dbTools = new DbTools(AppDomain.CurrentDomain.BaseDirectory + "ParcoMezzi.mdf");
            parcoMezzi = dbTools.CaricaDati();
            lbxVeicoli.DataSource = parcoMezzi;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbxVeicoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            Veicolo selezionato = (Veicolo)lbxVeicoli.SelectedItem;
            txtMarca.Text = selezionato.Marca;
            txtModello.Text = selezionato.Modello;
            if(selezionato is Auto)
            {
                Auto a = (Auto)selezionato;
                numPorte.Value = a.NumPorte;
                numCerchi.Value = a.DimCerchi;
            }
            else if(selezionato is Moto)
            {
                Moto m = (Moto)selezionato;
                cmbTipologia.SelectedItem = m.Tipo;
             //   numTempi = m.NumTempi;
            }
        }
    }
}
