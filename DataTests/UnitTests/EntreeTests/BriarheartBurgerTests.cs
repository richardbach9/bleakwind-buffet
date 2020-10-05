/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }
        [Fact]
        public void KetchupChangeShouldTriggerPropertyChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = false;
            });
        }
        [Fact]
        public void BunChangeShouldTriggerPropertyChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });
        }
        [Fact]
        public void MustardChangeShouldTriggerPropertyChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });
        }
        [Fact]
        public void PickleChangeShouldTriggerPropertyChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = false;
            });
        }
        [Fact]
        public void CheeseChangeShouldTriggerPropertyChange()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });
        }
        [Fact]
        public void ShouldBeINotifyPropertyChanged()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Bun = false;
            Assert.False(briarheartBurger.Bun);
            briarheartBurger.Bun = true;
            Assert.True(briarheartBurger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Ketchup = false;
            Assert.False(briarheartBurger.Ketchup);
            briarheartBurger.Ketchup = true;
            Assert.True(briarheartBurger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Mustard = false;
            Assert.False(briarheartBurger.Mustard);
            briarheartBurger.Mustard = true;
            Assert.True(briarheartBurger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Pickle = false;
            Assert.False(briarheartBurger.Pickle);
            briarheartBurger.Pickle = true;
            Assert.True(briarheartBurger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Cheese = false;
            Assert.False(briarheartBurger.Cheese);
            briarheartBurger.Cheese = true;
            Assert.True(briarheartBurger.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.Equal(6.32, briarheartBurger.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.Equal(743, (int)briarheartBurger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese
            };
            if (!includeBun) Assert.Contains("Hold bun", briarheartBurger.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", briarheartBurger.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", briarheartBurger.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", briarheartBurger.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", briarheartBurger.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", briarheartBurger.ToString());
        }
    }
}