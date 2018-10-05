using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMatchMaker
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Student_Create_Success()
        {
            // Given
            Student testStudent;
            string testNameExpected = "Jean";
            Boolean testIsCaptExpected = true;
            List<int> testListOfChoicesExpected = new List<int> { 1, 2, 3, 4 };

            // Then
            // Récupérer les valeurs
            testStudent = new Student(testNameExpected, testIsCaptExpected, testListOfChoicesExpected);

            // When
            // Comparer les valeurs
            Assert.AreEqual(testNameExpected, testStudent.Name);
            Assert.AreEqual(testIsCaptExpected, testStudent.IsCapt);
            Assert.AreEqual(testListOfChoicesExpected, testStudent.ListOfChoices.Count);
        }
    }
}
