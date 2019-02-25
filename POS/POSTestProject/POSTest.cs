using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS_Terminal;

namespace POSTestProject
{
    [TestClass]
    public class POSTest
    {
        ProductOrder productOrder;
        PointOfSaleTerminal terminal;

        [TestInitialize]
        public void Setup()
        {
            //Arrange
            this.productOrder = new ProductOrder();
            this.terminal = new PointOfSaleTerminal();
        }

        [TestMethod]
        public void Test_CalculateTotal()
        {
            //Test Case 1
            this.Perform_ATest("ABCDABA", 13.25);
            this.Setup();
            //Test Case 2
            this.Perform_ATest("CCCCCCC", 6.00);
            this.Setup();
            //Test Case 3
            this.Perform_ATest("ABCD", 7.25);
            this.Setup();
        }

        private void Perform_ATest(string productCode,double expected)
        {   //Arrange
            productOrder = terminal.Scan(productCode , productOrder);
            productOrder = terminal.SetPricing(productOrder);
            //Act
            double actual = terminal.CalculateTotal(productOrder);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
