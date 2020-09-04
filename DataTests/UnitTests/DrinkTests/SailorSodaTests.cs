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
        public void ShouldIncludeIceByDefault()
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            Assert.True(sailorsSoda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            Assert.Equal(Size.Small, sailorsSoda.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            Assert.Equal(SodaFlavor.Cherry, sailorsSoda.SodaFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            sailorsSoda.Ice = false;
            Assert.False(sailorsSoda.Ice);
            sailorsSoda.Ice = true;
            Assert.True(sailorsSoda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            sailorsSoda.Size = Size.Large;
            Assert.Equal(Size.Large, sailorsSoda.Size);
            sailorsSoda.Size = Size.Medium;
            Assert.Equal(Size.Medium, sailorsSoda.Size);
            sailorsSoda.Size = Size.Small;
            Assert.Equal(Size.Small, sailorsSoda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            sailorsSoda.SodaFlavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, sailorsSoda.SodaFlavor);
            sailorsSoda.SodaFlavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, sailorsSoda.SodaFlavor);
            sailorsSoda.SodaFlavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, sailorsSoda.SodaFlavor);
            sailorsSoda.SodaFlavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, sailorsSoda.SodaFlavor);
            sailorsSoda.SodaFlavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, sailorsSoda.SodaFlavor);
            sailorsSoda.SodaFlavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, sailorsSoda.SodaFlavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            sailorsSoda.Size = size;
            Assert.Equal(price, sailorsSoda.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            sailorsSoda.Size = size;
            Assert.Equal(cal, sailorsSoda.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorsSoda sailorsSoda = new SailorsSoda();
            sailorsSoda.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", sailorsSoda.SpecialInstructions);
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
            SailorsSoda sailorsSoda = new SailorsSoda();
            sailorsSoda.SodaFlavor = flavor;
            sailorsSoda.Size = size;
            Assert.Equal(name, sailorsSoda.ToString());
        }
    }
}
