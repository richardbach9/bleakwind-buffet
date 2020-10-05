using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }
        [Fact]
        public void PriceChangeShouldTriggerPropertyChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Price = 0;
            });
        }
        [Fact]
        public void CaloriesChangeShouldTriggerPropertyChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Calories = 1;
            });
        }
        [Fact]
        public void SizeChangeShouldTriggerPropertyChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Medium;
            });
        }
        [Fact]
        public void IceChangeShouldTriggerPropertyChange()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }
        [Fact]
        public void ShouldBeINotifyPropertyChanged()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }
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
