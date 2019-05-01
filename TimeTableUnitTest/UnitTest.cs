using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeTable;
using System.Windows.Forms;
using SwissTransport;

namespace TimeTableUnitTest
{
    [TestClass]
    public class UnitTest
    {
        //Public Functions in TimeTable
        [TestMethod]
        public void getStationBoardTest()
        {
            //arrange
            TableForm mainFormTest = new TableForm();
            Transport transportTest = new Transport();
            //act
            var result = mainFormTest.GetStationBoard("Sursee");
            var expectedResult = transportTest.GetStationBoard("Sursee", "8502007");
            //assert
            Assert.AreNotEqual(result, expectedResult);
        }
    }
}
