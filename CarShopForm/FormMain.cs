using CarShopDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopForm
{
    public partial class FormMain : Form
    {

        string PATHDATA = Directory.GetCurrentDirectory() + "\\veicoli.json";

        List<Veicolo> veicoli;
        public Veicolo veicoloSelezionato;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(PATHDATA))
            {
                veicoli = Tools.DeserializeFromFile(PATHDATA);
                dgvVeicoli.DataSource = getAuto(veicoli);
                //bindData();
            }
            else
            {
                MessageBox.Show("Dati non disponibili");
            }
        }

        //private void bindData()
        //{
        //    txtMarca.DataBindings.Clear();
        //    txtMarca.DataBindings.Add("Text", veicoloSelezionato, "Marca");
        //}

        private List<Auto> getAuto(List<Veicolo> veicoli)
        {
            //IEnumerable<Auto> auto = veicoli.FindAll(v => v is Auto).Cast<Auto>();
            List<Auto> automobili = new List<Auto>();
            foreach (var item in veicoli)
            {
                if (item is Auto) automobili.Add(item as Auto);
            }
            return automobili;
        }

        private List<Moto> getMoto(List<Veicolo> veicoli)
        {
            List<Moto> moto = new List<Moto>();
            foreach (var item in veicoli)
            {
                if (item is Moto) moto.Add(item as Moto);
            }
            return moto;
        }

        private void aUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvVeicoli.DataSource = getAuto(veicoli);
            //bindData();
            tsdShowSelected.Text = "AUTO";
            tstMarca.Text = "";
        }

        private void mOTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvVeicoli.DataSource = getMoto(veicoli);
            //bindData();
            tsdShowSelected.Text = "MOTO";
            tstMarca.Text = "";
        }

        private void tstMarca_TextChanged(object sender, EventArgs e)
        {
            if (tsdShowSelected.Text == "AUTO")
            {
                List<Auto> auto = getAuto(veicoli);
                dgvVeicoli.DataSource = auto.FindAll(v => v.Marca.ToUpper().StartsWith(tstMarca.Text.ToUpper()));
            } else if (tsdShowSelected.Text == "MOTO")
            {
                List<Moto> moto = getMoto(veicoli);
                dgvVeicoli.DataSource = moto.FindAll(v => v.Marca.ToUpper().StartsWith(tstMarca.Text.ToUpper()));
            }
            //bindData();
        }

        private void dgvVeicoli_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVeicoli.SelectedRows.Count > 0)
            {
                veicoloSelezionato = (Veicolo)dgvVeicoli.SelectedRows[0].DataBoundItem;
                txtMarca.Text = veicoloSelezionato.Marca;
                txtModello.Text = veicoloSelezionato.Modello;
                txtColore.Text = veicoloSelezionato.Colore;
                txtTarga.Text = veicoloSelezionato.Targa;
                txtDescrizione.Text = veicoloSelezionato.Descrizione;
                numPrezzo.Value = (decimal)veicoloSelezionato.Prezzo;
                dateImmatricolazione.Value = veicoloSelezionato.DataImmatricolazione;
                chkAutomatica.Checked = veicoloSelezionato.IsAutomatico;
                cmbAlimentazione.SelectedValue = veicoloSelezionato.Alimentazione.ToString();
            }
        }
    }
}
