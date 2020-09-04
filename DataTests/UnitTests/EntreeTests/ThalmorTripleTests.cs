/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Bun = false;
            Assert.False(thalmorTriple.Bun);
            thalmorTriple.Bun = true;
            Assert.True(thalmorTriple.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Ketchup = false;
            Assert.False(thalmorTriple.Ketchup);
            thalmorTriple.Ketchup = true;
            Assert.True(thalmorTriple.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Mustard = false;
            Assert.False(thalmorTriple.Mustard);
            thalmorTriple.Mustard = true;
            Assert.True(thalmorTriple.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Pickle = false;
            Assert.False(thalmorTriple.Pickle);
            thalmorTriple.Pickle = true;
            Assert.True(thalmorTriple.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Cheese = false;
            Assert.False(thalmorTriple.Cheese);
            thalmorTriple.Cheese = true;
            Assert.True(thalmorTriple.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Tomato = false;
            Assert.False(thalmorTriple.Tomato);
            thalmorTriple.Tomato = true;
            Assert.True(thalmorTriple.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Lettuce = false;
            Assert.False(thalmorTriple.Lettuce);
            thalmorTriple.Lettuce = true;
            Assert.True(thalmorTriple.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Mayo = false;
            Assert.False(thalmorTriple.Mayo);
            thalmorTriple.Mayo = true;
            Assert.True(thalmorTriple.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Bacon = false;
            Assert.False(thalmorTriple.Bacon);
            thalmorTriple.Bacon = true;
            Assert.True(thalmorTriple.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Egg = false;
            Assert.False(thalmorTriple.Egg);
            thalmorTriple.Egg = true;
            Assert.True(thalmorTriple.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.Equal(8.32, thalmorTriple.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.Equal(943, (int)thalmorTriple.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Bun = includeBun;
            thalmorTriple.Ketchup = includeKetchup;
            thalmorTriple.Mustard = includeMustard;
            thalmorTriple.Pickle = includePickle;
            thalmorTriple.Cheese = includeCheese;
            thalmorTriple.Tomato = includeTomato;
            thalmorTriple.Lettuce = includeLettuce;
            thalmorTriple.Mayo = includeMayo;
            thalmorTriple.Bacon = includeBacon;
            thalmorTriple.Egg = includeEgg;
            if (!includeBun) Assert.Contains("Hold bun", thalmorTriple.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", thalmorTriple.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", thalmorTriple.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", thalmorTriple.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", thalmorTriple.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", thalmorTriple.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", thalmorTriple.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", thalmorTriple.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", thalmorTriple.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", thalmorTriple.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", thalmorTriple.ToString());
        }
    }
}