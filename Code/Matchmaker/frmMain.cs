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
            string line;
            using (var reader = new System.IO.StreamReader("P:/ICT/226a/226a_Matchmaker/Doc/TestData.csv"))
            {
                line = reader.ReadLine();
            }
        }

        // Groupe Importer
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayGroup_TextChanged(object sender, EventArgs e)
        {
            Program program = new Program();
            string displayGroup;
            displayGroup = program.importCSV(line);
        }
    }
}
