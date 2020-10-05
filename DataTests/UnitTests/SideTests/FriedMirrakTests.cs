/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
        }
        [Fact]
        public void ShouldBeINotifyPropertyChanged()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fm);
        }
        [Fact]
        public void SizeChangeShouldTriggerPropertyChange()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Size", () =>
            {
                fm.Size = Size.Small;
            });
        }
        [Fact]
        public void PriceChangeShouldTriggerPropertyChange()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Price", () =>
            {
                fm.Price = 0;
            });
        }
        [Fact]
        public void CaloriesChangeShouldTriggerPropertyChange()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Calories", () =>
            {
                fm.Calories = 0;
            });
        }
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            Assert.Equal(Size.Small, friedMiraak.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = Size.Large;
            Assert.Equal(Size.Large, friedMiraak.Size);
            friedMiraak.Size = Size.Medium;
            Assert.Equal(Size.Medium, friedMiraak.Size);
            friedMiraak.Size = Size.Small;
            Assert.Equal(Size.Small, friedMiraak.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            Assert.Empty(friedMiraak.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = size;
            Assert.Equal(price, friedMiraak.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = size;
            Assert.Equal(calories, friedMiraak.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = size;
            Assert.Equal(name, friedMiraak.ToString()) ;
        }
    }
}