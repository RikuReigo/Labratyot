using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.model;
using Autokauppa.controller;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
   
        KaupanLogiikka registerHandler;
        int makerId;
        List<string> PreviousEntry = new List<string>();
        List<string> NextEntry = new List<string>();


        public MainMenu()
        {
            InitializeComponent();
            registerHandler = new KaupanLogiikka();
            registerHandler.ShowDT();
            List<string> autonmerkki = registerHandler.getAllAutoMakers();
            foreach (string merkki in autonmerkki)
            {
                MerkkiBox.Items.Add(merkki);
            }

            List<string> autonvärit = registerHandler.getAutoColor();
            foreach(string väri in autonvärit)
            {
                VäriBox.Items.Add(väri);
            }

            List<string> autonpa = registerHandler.getAutoGas();
            foreach (string bensa in autonpa)
            {
                PABox.Items.Add(bensa);
            }
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testaaTietokantaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hintatextbox.Clear();
            MLtextbox.Clear();
            MTtextbox.Clear();
            MerkkiBox.ResetText();
            MalliBox.Items.Clear();
            MalliBox.ResetText();
            VäriBox.ResetText();
            PABox.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string valittuauto = MerkkiBox.SelectedItem.ToString();
            string valittubensa = PABox.SelectedItem.ToString();
            string valittuvari = VäriBox.SelectedItem.ToString();
            string valittumalli = MalliBox.SelectedItem.ToString();
            Auto newAuto = new Auto();
            newAuto.Mittarilukema = Convert.ToInt32(MLtextbox.Text);
            newAuto.Moottorin_Tilavuus = Convert.ToDecimal(MTtextbox.Text);
            newAuto.Hinta = Convert.ToDecimal(Hintatextbox.Text);
            newAuto.Rekisteri_Päivämäärä = Convert.ToDateTime(dateTimePicker1.Text);
            newAuto.VaritID = registerHandler.getVariId(valittuvari);
            newAuto.PolttoaineID = registerHandler.getBensaId(valittubensa);
            newAuto.AutonMalliID = registerHandler.getMalliId(valittumalli);
            newAuto.AutonMerkkiID = registerHandler.getModelID(valittuauto);
            

            registerHandler.saveAuto(newAuto);
        }

        private void HaeMalliBox(object sender, EventArgs e)
        {
            MalliBox.Items.Clear();
            MalliBox.ResetText();
            string valittuauto = MerkkiBox.SelectedItem.ToString();
            makerId = registerHandler.getModelID(valittuauto);
            List<string> autonmalli = registerHandler.getAutoModels(makerId);
            foreach (string malli in autonmalli)
            {
                MalliBox.Items.Add(malli);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
