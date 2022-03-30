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

        UserControl groupBoxTipoSelezionato = new UserControl();

        public FormMain()
        {
            InitializeComponent();
            popolaComboAlimentazione();
        }

        private void popolaComboAlimentazione()
        {
            Array values = System.Enum.GetValues(typeof(EAlimentazione));
            foreach (var item in values)
            {
                cmbAlimentazione.Items.Add(item);
            }
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
                try
                {
                    dateImmatricolazione.Value = veicoloSelezionato.DataImmatricolazione;
                }
                catch (Exception)
                {
                    dateImmatricolazione.Value = DateTimePicker.MinimumDateTime;
                }
                chkAutomatica.Checked = veicoloSelezionato.IsAutomatico;
                cmbAlimentazione.SelectedItem = veicoloSelezionato.Alimentazione;
                rdbAuto.Checked = rdbMoto.Checked = false;
                rdbAuto.Checked = veicoloSelezionato is Auto;
                rdbMoto.Checked = veicoloSelezionato is Moto;
            }
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton myRadioButton = (RadioButton)sender;
            if (myRadioButton.Checked)
            {
                groupBoxVeicolo.Controls.Remove(groupBoxTipoSelezionato);
                if (myRadioButton.Text == "AUTO")
                {
                    groupBoxTipoSelezionato = new GroupBoxAuto(veicoloSelezionato);
                    groupBoxVeicolo.Controls.Add(groupBoxTipoSelezionato);
                }
                else if (myRadioButton.Text == "MOTO")
                {
                    groupBoxTipoSelezionato = new GroupBoxMoto(veicoloSelezionato);
                    groupBoxVeicolo.Controls.Add(groupBoxTipoSelezionato);
                }
                groupBoxTipoSelezionato.Top = 20;
                groupBoxTipoSelezionato.Left = 600;
            }
        }

        private void nuovaAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Auto> temp = getAuto(veicoli);
            temp.Add(new Auto());
            dgvVeicoli.DataSource = temp;
            dgvVeicoli.Rows[dgvVeicoli.RowCount - 1].Selected = true;
            txtMarca.Focus();
            tsdShowSelected.Text = "AUTO";
            tstMarca.Text = "";
        }

        private void toolStripSplitButtonAddItem_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButtonAddItem.ShowDropDown();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            copiaDatiDaControlli();
            Tools.SerializeToJson(veicoli, PATHDATA);

        }

        private void copiaDatiDaControlli()
        {
            if (dgvVeicoli.SelectedRows.Count > 0)
            {
                veicoloSelezionato = (Veicolo)dgvVeicoli.SelectedRows[0].DataBoundItem;
                veicoloSelezionato.Marca = txtMarca.Text;
                veicoloSelezionato.Modello = txtModello.Text;
                veicoloSelezionato.Colore = txtColore.Text;
                veicoloSelezionato.Targa = txtTarga.Text;
                veicoloSelezionato.Descrizione = txtDescrizione.Text;
                veicoloSelezionato.Prezzo = (double)numPrezzo.Value;
                veicoloSelezionato.DataImmatricolazione = dateImmatricolazione.Value;
                veicoloSelezionato.IsAutomatico = chkAutomatica.Checked;
                try
                {
                    veicoloSelezionato.Alimentazione = (EAlimentazione)cmbAlimentazione.SelectedItem;
                }
                catch (Exception)
                {
                    veicoloSelezionato.Alimentazione = EAlimentazione.NonDichiarata;
                }
                int nRigaSelezionata = dgvVeicoli.SelectedRows[0].Index;
                if (veicoloSelezionato is Auto)
                {
                    // Auto
                    Auto auto = (Auto)veicoloSelezionato;
                    GroupBoxAuto gbAuto = (GroupBoxAuto)groupBoxTipoSelezionato;
                    ComboBox cb = gbAuto.cmbTrazione;
                    try
                    {
                        auto.Trazione = (ETrazione)cb.SelectedItem;
                    }
                    catch (Exception)
                    {
                        auto.Trazione = ETrazione.NonDichiarata;
                    }
                    auto.IsCabrio = gbAuto.chkCabrio.Checked;
                    auto.HasFendinebbia = gbAuto.chkFendinebbia.Checked;
                    auto.DiametroCerchi = (int)gbAuto.numCerchi.Value;
                    auto.NPorte = (int)gbAuto.numPorte.Value;
                    auto.Allestimento = gbAuto.txtAllestimento.Text;
                    dgvVeicoli.DataSource = getAuto(veicoli);
                }
                else if (veicoloSelezionato is Moto)
                {
                    // Moto
                    Moto moto = (Moto)veicoloSelezionato;
                    GroupBoxMoto gbMoto = (GroupBoxMoto)groupBoxTipoSelezionato;
                    ComboBox cb = gbMoto.cmbTipo;
                    moto.Cilindri = (int)gbMoto.numCilindri.Value;
                    moto.Tempi = (int)gbMoto.numTempi.Value;
                    moto.HasAbs = gbMoto.chkAbs.Checked;
                    moto.HasCts = gbMoto.chkCts.Checked;
                    moto.HasBauletto = gbMoto.chkBauletto.Checked;
                    dgvVeicoli.DataSource = getMoto(veicoli);
                }
                else
                {
                    // Furgone
                }
                dgvVeicoli.Rows[nRigaSelezionata].Selected = true;
            }
        }
    }
}
