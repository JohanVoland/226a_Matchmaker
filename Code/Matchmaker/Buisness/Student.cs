using System;
using System.Collections.Generic;

namespace Matchmaker
{
    public class Student
    {
        #region private attributes
        private string name;
        private int isCapt;
        private List<int> listOfChoices = null;

        private List<string> Choix1 = null;
        private List<string> Choix2 = null;
        private List<string> Choix3 = null;
        private List<string> Choix4 = null;
        #endregion private attributes

        #region constructor
        // Création d'un élève
        public string addStudent(string name, int isCapt, List<int> listOfChoices)
        {
            // Récupérer les informations de l'utilisateur
            this.name = name;
            this.isCapt = isCapt;
            this.listOfChoices = listOfChoices;

            return name;
        }

        /*public Student(// Paramètres adaptés au fichier csv)
        {
            this.name = ???;
            this.isCapt = ???;
            this.listOfChoices = ???;
        }*/

        // Mettre les élèves dans les différents groupes
        
        #endregion constructor

        #region public accessors and mutators (get /set)
        public string Name
        {
            get { return this.name; }
        }

        public int IsCapt
        {
            get { return this.isCapt; }
        }

        public List<int> ListOfChoices
        {
            get { return this.ListOfChoices; }
        }
        #endregion public accessors and mutators (get /set)
    }
}
