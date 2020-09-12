/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda SailorSoda = new SailorSoda();
            Assert.True(SailorSoda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda SailorSoda = new SailorSoda();
            Assert.Equal(Size.Small, SailorSoda.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda SailorSoda = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, SailorSoda.SodaFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda SailorSoda = new SailorSoda();
            SailorSoda.Ice = false;
            Assert.False(SailorSoda.Ice);
            SailorSoda.Ice = true;
            Assert.True(SailorSoda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda SailorSoda = new SailorSoda();
            SailorSoda.Size = Size.Large;
            Assert.Equal(Size.Large, SailorSoda.Size);
            SailorSoda.Size = Size.Medium;
            Assert.Equal(Size.Medium, SailorSoda.Size);
            SailorSoda.Size = Size.Small;
            Assert.Equal(Size.Small, SailorSoda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda SailorSoda = new SailorSoda();
            SailorSoda.SodaFlavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, SailorSoda.SodaFlavor);
            SailorSoda.SodaFlavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, SailorSoda.SodaFlavor);
            SailorSoda.SodaFlavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, SailorSoda.SodaFlavor);
            SailorSoda.SodaFlavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, SailorSoda.SodaFlavor);
            SailorSoda.SodaFlavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, SailorSoda.SodaFlavor);
            SailorSoda.SodaFlavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, SailorSoda.SodaFlavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda SailorSoda = new SailorSoda();
            SailorSoda.Size = size;
            Assert.Equal(price, SailorSoda.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda SailorSoda = new SailorSoda();
            SailorSoda.Size = size;
            Assert.Equal(cal, SailorSoda.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda SailorSoda = new SailorSoda();
            SailorSoda.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", SailorSoda.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda SailorSoda = new SailorSoda();
            SailorSoda.SodaFlavor = flavor;
            SailorSoda.Size = size;
            Assert.Equal(name, SailorSoda.ToString());
        }
    }
}
