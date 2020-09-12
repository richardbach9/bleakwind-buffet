/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            Assert.False(markarthMilk.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            Assert.Equal(Size.Small, markarthMilk.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Ice = true;
            Assert.True(markarthMilk.Ice);
            markarthMilk.Ice = false;
            Assert.False(markarthMilk.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = Size.Large;
            Assert.Equal(Size.Large, markarthMilk.Size);
            markarthMilk.Size = Size.Medium;
            Assert.Equal(Size.Medium, markarthMilk.Size);
            markarthMilk.Size = Size.Small;
            Assert.Equal(Size.Small, markarthMilk.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = size;
            Assert.Equal(price, markarthMilk.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = size;
            Assert.Equal(cal, markarthMilk.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", markarthMilk.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = size;
            Assert.Equal(name, markarthMilk.ToString());
        }
    }
}