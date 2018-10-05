using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matchmaker
{
    [TestClass]
    public class TestProgramm
    {
        #region private attributes
        private string testExtentionActual;
        private string testExtentionExpected;
        private string file;
        private Program testProgramm = null;
        #endregion private attributes 

        [TestInitialize]
        public void Init()
        {
            testProgramm = new Program();
            testExtentionActual = "";
        }

        [TestMethod]
        public void TestImportCSV()
        {
            // CSV file ?
            // Given
            file = "TestData.csv";
            testExtentionExpected = ".csv";

            // When
            testExtentionActual = System.IO.Path.GetExtension(testProgramm.importCSV(file));

            // Then
            Assert.AreEqual(testExtentionExpected, testExtentionActual);
        }

        [TestCleanup]
        public void CleanUp()
        {
            testExtentionActual = "";
        }
    }
}
