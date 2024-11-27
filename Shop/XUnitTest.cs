using Xunit;
using ShoppingBasket;
using Shop;

namespace ShoppingBasket
{
    public class XUnitTest
    {
        [Fact]
        public void NormalScenario()
        {
            // Arrange
            string input = "apple,banana,melon,lime";
            Shopping priceCalculator = new Shopping();

            // Act
            decimal totalPrice = priceCalculator.shoppingBasket(input);

            // Assert
            Assert.Equal(1.2m, totalPrice);
        }

        [Fact] // Test attribute in xUnit
        public void ScenarioForOffers()
        {
            
            // Arrange
            string input = "apple,banana,melon,melon,melon,lime,lime,lime,lime";
            Shopping priceCalculator = new Shopping();

            // Act
            decimal totalPrice = priceCalculator.shoppingBasket(input);

            // Assert
            Assert.Equal(2.0m, totalPrice);
        }

    }
}


