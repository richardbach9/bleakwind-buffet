using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTest
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }
        [Fact]
        public void ShouldBeINotifyPropertyChange()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }
        [Fact]
        public void PriceChangeShouldTriggerPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Price = 1000;
            });
        }
        [Fact]
        public void CalorieChangeShouldTriggerPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Calories = 1000;
            });
        }
        [Fact]
        public void DrinkChangeShouldTriggerDrinkPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = new AretinoAppleJuice();
            });
        }
        [Fact]
        public void DrinkChangeShouldTriggerPricePropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = new AretinoAppleJuice();
            });
        }
        [Fact]
        public void DrinkChangeShouldTriggerCaloriePropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = new AretinoAppleJuice();
            });
        }
        [Fact]
        public void DrinkChangeShouldTriggerSpecialInstructionsPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Special Instructions", () =>
            {
                combo.Drink = new AretinoAppleJuice();
            });
        }
        [Fact]
        public void EntreeChangeShouldTriggerDrinkPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void EntreeChangeShouldTriggerPricePropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void EntreeChangeShouldTriggerCaloriePropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void EntreeChangeShouldTriggerSpecialInstructionsPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Special Instructions", () =>
            {
                combo.Entree = new BriarheartBurger();
            });
        }
        [Fact]
        public void SideChangeShouldTriggerDrinkPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }
        [Fact]
        public void SideChangeShouldTriggerPricePropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }
        [Fact]
        public void SideChangeShouldTriggerCaloriePropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }
        [Fact]
        public void SideChangeShouldTriggerSpecialInstructionsPropertyChange()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Special Instructions", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }
    }
}
