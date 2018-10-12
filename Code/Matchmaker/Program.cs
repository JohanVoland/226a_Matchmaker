using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matchmaker
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        // Tableau qui contient le contenu du fichier csv
        /*public List<string> listName = new List<string>();
        public List<int> listCapt = new List<int>();
        public List<int> listChoice = new List<int>();*/
        string name;
        int isCapt;
        List<int> Choices = new List<int>();

        #region public methods
        public string importCSV(string file)
        {
            return file;
        }

        // Lecture du fichier csv
        public string ReadFile (string file)
        {
            using (var reader = new System.IO.StreamReader(file))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // Liste des noms
                    name = values[0];
                    
                    // Liste des capitaines
                    isCapt = Convert.ToInt32(values[1]);
                    
                    // Liste des choix
                    int i = 0;
                    for (i = 2; i < 21; i++)
                    {
                        Choices.Add(Convert.ToInt32(values[i]));
                    }

                    // Ajout des données dans Student
                    Student student = new Student();
                    student.addStudent(name, isCapt, Choices);
                }
            }

            return name;
        }
        #endregion
    }
}
