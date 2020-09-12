/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.False(candlehearthCoffee.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.False(candlehearthCoffee.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.False(candlehearthCoffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.Equal(Size.Small, candlehearthCoffee.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Ice = true;
            Assert.True(candlehearthCoffee.Ice);
            candlehearthCoffee.Ice = false;
            Assert.False(candlehearthCoffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Decaf = true;
            Assert.True(candlehearthCoffee.Decaf);
            candlehearthCoffee.Decaf = false;
            Assert.False(candlehearthCoffee.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.RoomForCream = true;
            Assert.True(candlehearthCoffee.RoomForCream);
            candlehearthCoffee.RoomForCream = false;
            Assert.False(candlehearthCoffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Size = size;
            Assert.Equal(price, candlehearthCoffee.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Size = size;
            Assert.Equal(cal, candlehearthCoffee.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream
            };
            if (includeIce) Assert.Contains("Add ice", candlehearthCoffee.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", candlehearthCoffee.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Decaf = decaf;
            candlehearthCoffee.Size = size;
            Assert.Equal(name, candlehearthCoffee.ToString());
        }
    }
}
