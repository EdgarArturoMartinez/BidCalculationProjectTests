
using BidCalculationProject.FeesCalculation;

namespace BidCalculationProject.Tests
{
    [TestClass]
    public class AssociationCostFeeTests
    {
        [TestMethod]
        public void CalculateFee_ReturnsCorrectFee_ForDifferentBasePrices()
        {
            // Arrange
            AssociationCostFee associationCostFee = new AssociationCostFee();

            // Act
            decimal fee1 = associationCostFee.CalculateFee(1, 400); // Between 1 and 500
            decimal fee2 = associationCostFee.CalculateFee(1, 800); // Between 500 and 1000
            decimal fee3 = associationCostFee.CalculateFee(1, 2000); // Between 1000 and 3000
            decimal fee4 = associationCostFee.CalculateFee(1, 3500); // Over 3000

            // Assert
            Assert.AreEqual(5.0m, fee1, "Fee for $400 should be $5.0");
            Assert.AreEqual(10.0m, fee2, "Fee for $800 should be $10.0");
            Assert.AreEqual(15.0m, fee3, "Fee for $2,000 should be $15.0");
            Assert.AreEqual(20.0m, fee4, "Fee for $3,500 should be $20.0");
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void CalculateFee_ThrowsNotImplementedException_ForInvalidBasePrice()
        {
            // Arrange
            AssociationCostFee associationCostFee = new AssociationCostFee();

            // Act & Assert
            decimal fee = associationCostFee.CalculateFee(1, -1); // Invalid base price should throw NotImplementedException
        }
    }
}