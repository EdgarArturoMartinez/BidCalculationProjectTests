

using BidCalculationProject.FeesCalculation;

namespace BidCalculationProject.Tests
{
    [TestClass]
    public class SellerSpecialFeeTests
    {
        [TestMethod]
        public void CalculateFee_ReturnsCorrectFee_ForDifferentVehicleTypes()
        {
            // Arrange
            SellerSpecialFee sellerSpecialFee = new SellerSpecialFee();
            decimal basePrice = 1000;

            // Act
            decimal fee1 = sellerSpecialFee.CalculateFee(0, basePrice); // Common vehicle type
            decimal fee2 = sellerSpecialFee.CalculateFee(1, basePrice); // Luxury vehicle type

            // Assert
            Assert.AreEqual(basePrice * BidProjectFees.CommonSellerSpecialFee, fee1, "Fee for Common vehicle type should be $20.0");
            Assert.AreEqual(basePrice * BidProjectFees.LuxurySellerSpecialFee, fee2, "Fee for Luxury vehicle type should be %40.0");
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void CalculateFee_ThrowsNotImplementedException_ForInvalidVehicleType()
        {
            // Arrange
            SellerSpecialFee sellerSpecialFee = new SellerSpecialFee();
            decimal basePrice = 1000;

            // Act & Assert
            decimal fee = sellerSpecialFee.CalculateFee(2, basePrice); // Invalid vehicle type should throw NotImplementedException
        }
    }
}
