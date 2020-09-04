using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater warriorWater = new WarriorWater();
            Assert.True(warriorWater.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater warriorWater = new WarriorWater();
            Assert.Equal(Size.Small, warriorWater.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Ice = true;
            Assert.True(warriorWater.Ice);
            warriorWater.Ice = false;
            Assert.False(warriorWater.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = Size.Large;
            Assert.Equal(Size.Large, warriorWater.Size);
            warriorWater.Size = Size.Medium;
            Assert.Equal(Size.Medium, warriorWater.Size);
            warriorWater.Size = Size.Small;
            Assert.Equal(Size.Small, warriorWater.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = size;
            Assert.Equal(price, warriorWater.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = size;
            Assert.Equal(cal, warriorWater.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", warriorWater.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = size;
            Assert.Equal(name, warriorWater.ToString());
        }
    }
}
