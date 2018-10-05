using System;
using System.Collections.Generic;

namespace TestMatchMaker
{
    public class Student
    {
        #region private attributes
        private string name;
        private Boolean isCapt;
        private List<int> listOfChoices = null;
        #endregion private attributes

        #region constructor
        public Student(string name, Boolean isCapt, List<int> listOfChoices)
        {
            this.name = name;
            this.isCapt = isCapt;
            this.listOfChoices = listOfChoices;
        }

        /*public Student(// Paramètres adaptés au fichier csv)
        {
            this.name = ???;
            this.isCapt = ???;
            this.listOfChoices = ???;
        }*/
        #endregion constructor

        #region public accessors and mutators (get /set)
        public string Name
        {
            get { return this.name; }
        }

        public Boolean IsCapt
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
