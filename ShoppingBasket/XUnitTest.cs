using Xunit;
using ShoppingBasket;

namespace ShoppingBasket
{
    public class XUnitTest
    {
        [Fact]
        public void NormalScenario()
        {
            // Arrange
            string input = "apple,banana,melon,lime";
            Shop priceCalculator = new Shop();

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
            Shop priceCalculator = new Shop();

            // Act
            decimal totalPrice = priceCalculator.shoppingBasket(input);

            // Assert
            Assert.Equal(2.0m, totalPrice);
        }

    }
}


