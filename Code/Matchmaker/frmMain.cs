using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matchmaker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Fenêtre
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Bouton Importer
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Select and import the csv file
            string file;
            file = "P:/ICT/226a/226a_Matchmaker/Doc/TestData.csv";
            Program program = new Program();
            program.importCSV(file);

            // Read the csv file
            program.ReadFile(file);

            // Affiche pour le moment tout le fichier csv
            textBox1.Text = "P:/ICT/226a/226a_Matchmaker/Doc/TestData.csv";
        }

        // Groupe Importer
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // TextBox qui affiche le chemin du fichier importé
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Affichage du résultat
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
