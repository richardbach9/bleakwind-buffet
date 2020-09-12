/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dbwf);
        }
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dbwf);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dragonbornWaffleFries.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = Size.Large;
            Assert.Equal(Size.Large, dragonbornWaffleFries.Size);
            dragonbornWaffleFries.Size = Size.Medium;
            Assert.Equal(Size.Medium, dragonbornWaffleFries.Size);
            dragonbornWaffleFries.Size = Size.Small;
            Assert.Equal(Size.Small, dragonbornWaffleFries.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            Assert.Empty(dragonbornWaffleFries.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = size;
            Assert.Equal(price, dragonbornWaffleFries.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = size;
            Assert.Equal(calories, dragonbornWaffleFries.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = size;
            Assert.Equal(name, dragonbornWaffleFries.ToString());
        }
    }
}