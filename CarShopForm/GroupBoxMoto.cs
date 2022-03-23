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
    public partial class GroupBoxMoto : UserControl
    {
        public GroupBoxMoto(Veicolo veicoloSelezionato)
        {
            InitializeComponent();
            popolaComboTipo();
            if (veicoloSelezionato is Moto)
            {
                Moto moto = (Moto)veicoloSelezionato;
                cmbTipo.SelectedItem = moto.Tipo;
                numCilindri.Value = moto.Cilindri;
                numTempi.Value = moto.Tempi;
                chkAbs.Checked = moto.HasAbs;
                chkCts.Checked = moto.HasCts;
                chkBauletto.Checked = moto.HasBauletto;
            }
        }

        private void popolaComboTipo()
        {
            Array values = System.Enum.GetValues(typeof(ETipoMoto));
            foreach (var item in values)
            {
                cmbTipo.Items.Add(item);
            }
        }

    }
}
