/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aaj);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            Assert.False(aretinoAppleJuice.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aretinoAppleJuice.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Ice = true;
            Assert.True(aretinoAppleJuice.Ice);
            aretinoAppleJuice.Ice = false;
            Assert.False(aretinoAppleJuice.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Size = Size.Large;
            Assert.Equal(Size.Large, aretinoAppleJuice.Size);
            aretinoAppleJuice.Size = Size.Medium;
            Assert.Equal(Size.Medium, aretinoAppleJuice.Size);
            aretinoAppleJuice.Size = Size.Small;
            Assert.Equal(Size.Small, aretinoAppleJuice.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Size = size;
            Assert.Equal(price, aretinoAppleJuice.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Size = size;
            Assert.Equal(cal, aretinoAppleJuice.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aretinoAppleJuice.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Size = size;
            Assert.Equal(name, aretinoAppleJuice.ToString());
        }
    }
}