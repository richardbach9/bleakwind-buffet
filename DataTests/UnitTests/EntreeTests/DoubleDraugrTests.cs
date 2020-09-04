/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
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