using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShopDll;

namespace CarShopForm
{
    public partial class GroupBoxAuto : UserControl
    {
        public GroupBoxAuto(Veicolo veicoloSelezionato)
        {
            InitializeComponent();
            popolaComboTrazione();
            if (veicoloSelezionato is Auto)
            {
                Auto auto = (Auto)veicoloSelezionato;
                cmbTrazione.SelectedItem = auto.Trazione;
                chkCabrio.Checked = auto.IsCabrio;
                chkFendinebbia.Checked = auto.HasFendinebbia;
                numCerchi.Value = auto.DiametroCerchi;
                numPorte.Value = auto.NPorte;
                txtAllestimento.Text = auto.Allestimento;
            }
        }

        private void popolaComboTrazione()
        {
            Array values = System.Enum.GetValues(typeof(ETrazione));
            foreach (var item in values)
            {
                cmbTrazione.Items.Add(item);
            }
        }
    }
}
