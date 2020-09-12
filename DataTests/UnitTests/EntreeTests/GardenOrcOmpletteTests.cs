/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            Assert.True(gardenOrcOmelette.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            Assert.True(gardenOrcOmelette.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            Assert.True(gardenOrcOmelette.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            Assert.True(gardenOrcOmelette.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            gardenOrcOmelette.Broccoli = false;
            Assert.False(gardenOrcOmelette.Broccoli);
            gardenOrcOmelette.Broccoli = true;
            Assert.True(gardenOrcOmelette.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            gardenOrcOmelette.Mushrooms = false;
            Assert.False(gardenOrcOmelette.Mushrooms);
            gardenOrcOmelette.Mushrooms = true;
            Assert.True(gardenOrcOmelette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            gardenOrcOmelette.Tomato = false;
            Assert.False(gardenOrcOmelette.Tomato);
            gardenOrcOmelette.Tomato = true;
            Assert.True(gardenOrcOmelette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            gardenOrcOmelette.Cheddar = false;
            Assert.False(gardenOrcOmelette.Cheddar);
            gardenOrcOmelette.Cheddar = true;
            Assert.True(gardenOrcOmelette.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            Assert.Equal(4.57, gardenOrcOmelette.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            Assert.Equal(404, (int)gardenOrcOmelette.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };
            if (!includeBroccoli) Assert.Contains("Hold broccoli", gardenOrcOmelette.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", gardenOrcOmelette.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", gardenOrcOmelette.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", gardenOrcOmelette.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette gardenOrcOmelette = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", gardenOrcOmelette.ToString());
        }
    }
}