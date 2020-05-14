using System;
using System.Windows.Forms;
using carShopDllProject;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        SerializableBindingList<Veicolo> bindingListVeicoli;

        public FormMain()
        {
            InitializeComponent();
            bindingListVeicoli = new SerializableBindingList<Veicolo>();
            listBoxVeicoli.DataSource = bindingListVeicoli;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CaricaDatiDiTest();
        }

        private void CaricaDatiDiTest()
        {
            Moto m = new Moto();
            bindingListVeicoli.Add(m);
            m = new Moto("Aprilia", "125", "Rosso", 600, 70, DateTime.Now, "si", "no", 0, "Harley Davison", 0);
            bindingListVeicoli.Add(m);

            Auto a = new Auto();
            a = new Auto("Audi", "A1", "Blu", 1400, 75, DateTime.Now, "si", "no", 0, 0, 0);
            bindingListVeicoli.Add(a);
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            frmAggiungiVeicolo dialogAggiungi = new frmAggiungiVeicolo(bindingListVeicoli);
            dialogAggiungi.ShowDialog();
        }

        private void eliminaToolStripButton_Click(object sender, EventArgs e)
        {
            bindingListVeicoli.RemoveAt(listBoxVeicoli.SelectedIndex);
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            //non funziona
            /*
            dbUtils.eliminaTabella("AUTO");
            dbUtils.eliminaTabella("MOTO");
            dbUtils.creaTabella("AUTO");
            dbUtils.creaTabella("MOTO");

            foreach (Auto auto in bindingListVeicoli.OfType<Auto>())
            {
                dbUtils.aggiungiItem("AUTO", auto.Marca, auto.Modello, auto.Colore, Convert.ToInt32(auto.Cilindrata),
                Convert.ToInt32(auto.PotenzaKw), Convert.ToDateTime(auto.Immatricolazione), auto.IsUsato.ToString(),
                auto.IsKmZero.ToString(), Convert.ToInt32(auto.KmPercorsi), Convert.ToInt32(auto.Prezzo),
                Convert.ToInt32(auto.NumAirbag), null);
            }

            foreach (Moto moto in bindingListVeicoli.OfType<Moto>())
            {
                dbUtils.aggiungiItem("MOTO", moto.Marca, moto.Modello, moto.Colore, Convert.ToInt32(moto.Cilindrata),
                Convert.ToInt32(moto.PotenzaKw), Convert.ToDateTime(moto.Immatricolazione), moto.IsUsato.ToString(),
                moto.IsKmZero.ToString(), Convert.ToInt32(moto.KmPercorsi), Convert.ToInt32(moto.Prezzo),
                0, moto.MarcaSella);
            }

            MessageBox.Show("Dati salvati correttamente");
            */
        }

        private void stampaToolStripButton_Click(object sender, EventArgs e)
        {
            string homepagePath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\WindowsFormsAppProject\\www\\index.html";
            string skeletonPath = $"{ Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\WindowsFormsAppProject\\www\\index-skeleton.html";
            Utils.createHtml(bindingListVeicoli, homepagePath, skeletonPath);
            Process.Start(homepagePath);
        }

        private void wordToolStripButton_Click(object sender, EventArgs e)
        {
            //non funziona
        }
    }
}