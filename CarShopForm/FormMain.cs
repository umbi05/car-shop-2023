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

        BindingList<Veicolo> veicoli;
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
                bindDataGridView("AUTO", veicoli);
            }
            else
            {
                MessageBox.Show("Dati non disponibili");
            }
        }

        private void bindDataGridView(string tipoVeicolo, BindingList<Veicolo> veicoli)
        {
            dgvVeicoli.DataSource = null;
            if (tipoVeicolo.ToUpper()=="AUTO")
            {
                dgvVeicoli.DataSource = getAuto(veicoli);
                columnDisplayOrder("Marca,Modello,Targa,Colore,Alimentazione,Prezzo,Trazione,Cilindrata,Potenza,DataImmatricolazione", dgvVeicoli);
            }
            else if (tipoVeicolo.ToUpper() == "MOTO")
            {
                dgvVeicoli.DataSource = getMoto(veicoli);
                columnDisplayOrder("Marca,Modello,Targa,Prezzo,Tipo,Colore", dgvVeicoli);
            }
        }

        //private void bindData()
        //{
        //    txtMarca.DataBindings.Clear();
        //    txtMarca.DataBindings.Add("Text", veicoloSelezionato, "Marca");
        //}

        private BindingList<Auto> getAuto(BindingList<Veicolo> veicoli)
        {
            //IEnumerable<Auto> auto = veicoli.FindAll(v => v is Auto).Cast<Auto>();
            BindingList<Auto> automobili = new BindingList<Auto>();
            foreach (var item in veicoli)
            {
                if (item is Auto) automobili.Add(item as Auto);
            }
            return automobili;
        }

        private BindingList<Moto> getMoto(BindingList<Veicolo> veicoli)
        {
            BindingList<Moto> moto = new BindingList<Moto>();
            foreach (var item in veicoli)
            {
                if (item is Moto) moto.Add(item as Moto);
            }
            return moto;
        }

        private void columnDisplayOrder(string columnList, DataGridView gridView)
        {
            var columnListArray = columnList.Split(',');
            for (var i = 0; i < columnListArray.Length; i++)
            {
                var gridViewColumn = gridView.Columns[columnListArray[i].Trim()];
                if (gridViewColumn != null)
                    gridViewColumn.DisplayIndex = i;
            }
        }

        private void aUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindDataGridView("AUTO", veicoli);
            tsdShowSelected.Text = "AUTO";
            tstMarca.Text = "";
        }

        private void mOTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindDataGridView("MOTO", veicoli);
            tsdShowSelected.Text = "MOTO";
            tstMarca.Text = "";
        }

        private void tstMarca_TextChanged(object sender, EventArgs e)
        {
            BindingList<Veicolo> filteredVeicoli = new BindingList<Veicolo>(veicoli.Where
                (v => v.Marca.ToUpper().StartsWith(tstMarca.Text.ToUpper())).ToList());
            if (tsdShowSelected.Text == "AUTO")
            {
                bindDataGridView("AUTO", filteredVeicoli);
            } else if (tsdShowSelected.Text == "MOTO")
            {
                bindDataGridView("MOTO", filteredVeicoli);
            }
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
            veicoli.Add(new Auto());
            bindDataGridView("AUTO", veicoli);
            dgvVeicoli.Rows[dgvVeicoli.RowCount - 1].Selected = true;
            txtMarca.Focus();
            tsdShowSelected.Text = "AUTO";
            tstMarca.Text = "";
        }

        private void nuovaMotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            veicoli.Add(new Moto());
            bindDataGridView("MOTO", veicoli);
            dgvVeicoli.Rows[dgvVeicoli.RowCount - 1].Selected = true;
            txtMarca.Focus();
            tsdShowSelected.Text = "MOTO";
            tstMarca.Text = "";
        }

        private void toolStripSplitButtonAddItem_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButtonAddItem.ShowDropDown();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtMarca.Text.Length == 0) ||
                (txtModello.Text.Length == 0))
            {
                MessageBox.Show("Inserire almeno Marca e Modello");
            }
            else
            {
                copiaDatiDaControlli();
                Tools.SerializeToJson(veicoli, PATHDATA);
                tstMarca.Text = "";
            }
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
                    bindDataGridView("AUTO", veicoli);
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
                    bindDataGridView("MOTO", veicoli);
                }
                else
                {
                    // Furgone
                }
                dgvVeicoli.Rows[nRigaSelezionata].Selected = true;
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Confermi di voler eliminare questo veicolo?", 
                "ELIMINA?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) 
                == DialogResult.Yes)
            {
                veicoli.Remove(veicoloSelezionato);
                Tools.SerializeToJson(veicoli, PATHDATA);
                if (veicoloSelezionato is Auto)
                    bindDataGridView("AUTO", veicoli);
                else
                    bindDataGridView("MOTO", veicoli);
                tstMarca.Text = "";
            }
        }
    }
}
