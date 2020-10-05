/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }
        [Fact]
        public void KetchupChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
        }
        [Fact]
        public void BunChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });
        }
        [Fact]
        public void MustardChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });
        }
        [Fact]
        public void PickleChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });
        }
        [Fact]
        public void CheeseChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });
        }
        [Fact]
        public void TomatoChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
        }
        [Fact]
        public void LettuceChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });
        }
        [Fact]
        public void MayoChangeShouldTriggerPropertyChange()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });
        }
        [Fact]
        public void ShouldBeINotifyPropertyChanged()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Bun = false;
            Assert.False(doubleDraugr.Bun);
            doubleDraugr.Bun = true;
            Assert.True(doubleDraugr.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Ketchup = false;
            Assert.False(doubleDraugr.Ketchup);
            doubleDraugr.Ketchup = true;
            Assert.True(doubleDraugr.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Mustard = false;
            Assert.False(doubleDraugr.Mustard);
            doubleDraugr.Mustard = true;
            Assert.True(doubleDraugr.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Pickle = false;
            Assert.False(doubleDraugr.Pickle);
            doubleDraugr.Pickle = true;
            Assert.True(doubleDraugr.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Cheese = false;
            Assert.False(doubleDraugr.Cheese);
            doubleDraugr.Cheese = true;
            Assert.True(doubleDraugr.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Tomato = false;
            Assert.False(doubleDraugr.Tomato);
            doubleDraugr.Tomato = true;
            Assert.True(doubleDraugr.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Lettuce = false;
            Assert.False(doubleDraugr.Lettuce);
            doubleDraugr.Lettuce = true;
            Assert.True(doubleDraugr.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Mayo = false;
            Assert.False(doubleDraugr.Mayo);
            doubleDraugr.Mayo = true;
            Assert.True(doubleDraugr.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.Equal(7.32, doubleDraugr.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.Equal(843, (int)doubleDraugr.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };
            if (!includeBun) Assert.Contains("Hold bun", doubleDraugr.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", doubleDraugr.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", doubleDraugr.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", doubleDraugr.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", doubleDraugr.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", doubleDraugr.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", doubleDraugr.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", doubleDraugr.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.Equal("Double Draugr", doubleDraugr.ToString());
        }
    }
}