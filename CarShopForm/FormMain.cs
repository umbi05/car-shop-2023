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

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(PATHDATA))
            {
                veicoli = Tools.DeserializeFromFile(PATHDATA);
                lstVeicoli.DataSource = veicoli;
            }
            else
            {
                MessageBox.Show("Dati non disponibili");
            }
        }
    }
}
