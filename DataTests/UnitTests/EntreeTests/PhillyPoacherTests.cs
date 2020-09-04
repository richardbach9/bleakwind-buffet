/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Onions);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            phillyPoacher.Sirloin = false;
            Assert.False(phillyPoacher.Sirloin);
            phillyPoacher.Sirloin = true;
            Assert.True(phillyPoacher.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            phillyPoacher.Onions = false;
            Assert.False(phillyPoacher.Onions);
            phillyPoacher.Onions = true;
            Assert.True(phillyPoacher.Onions);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            phillyPoacher.Roll = false;
            Assert.False(phillyPoacher.Roll);
            phillyPoacher.Roll = true;
            Assert.True(phillyPoacher.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.Equal(7.23, phillyPoacher.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.Equal(784, (int)phillyPoacher.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onions = includeOnion,
                Roll = includeRoll
            };
            if (!includeSirloin) Assert.Contains("Hold sirloin", phillyPoacher.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onions", phillyPoacher.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", phillyPoacher.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.Equal("Philly Poacher", phillyPoacher.ToString());
        }
    }
}