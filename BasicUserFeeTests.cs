using BidCalculationProject.FeesCalculation;

namespace BidCalculationProject.Tests
{
    [TestClass]
    public class BasicUserFeeTests
    {
        [TestMethod]
        public void CalculateFee_ReturnsCorrectFee_ForCommonCar()
        {
            // Arrange
            BasicUserFee basicUserFee = new BasicUserFee();
            int vehicleType = 0; // Common Car
            decimal basePrice = 1000;

            // Act
            decimal fee = basicUserFee.CalculateFee(vehicleType, basePrice);

            // Assert
            Assert.AreEqual(BidProjectFees.CommonCarMaxBasicFee, fee, "Fee for Common Car should be $50.0");
        }

        [TestMethod]
        public void CalculateFee_ReturnsCorrectFee_ForLuxuryCar()
        {
            // Arrange
            BasicUserFee basicUserFee = new BasicUserFee();
            int vehicleType = 1; // Luxury Car
            decimal basePrice = 1000;

            // Act
            decimal fee = basicUserFee.CalculateFee(vehicleType, basePrice);

            // Assert
            Assert.AreEqual(100.0m, fee, "Fee for Luxury Car should be $100.0");
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void CalculateFee_ThrowsNotImplementedException_ForInvalidVehicleType()
        {
            // Arrange
            BasicUserFee basicUserFee = new BasicUserFee();
            int invalidVehicleType = 2;
            decimal basePrice = 1000;

            // Act & Assert
            decimal fee = basicUserFee.CalculateFee(invalidVehicleType, basePrice); // Invalid vehicle type should throw NotImplementedException
        }
    }
}
