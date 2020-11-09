﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTest
    {
        [Fact]
        public void ShouldContainEntree()
        {
            Assert.Collection<IOrderItem>(Menu.Entrees(), x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""));
        }
        [Fact]
        public void ShouldContainDrinks()
        {
            Assert.Collection<IOrderItem>(Menu.Drinks(), x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""));
        }
        [Fact]
        public void ShouldContainSides()
        {
            Assert.Collection<IOrderItem>(Menu.Sides(), x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""));
        }
        [Fact]
        public void ShouldContainFullMenu()
        {
            Assert.Collection<IOrderItem>(Menu.FullMenu(), x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""),
                                                          x => x.ToString().Equals(""));
        }
        [Fact]
        public void ShouldFilterCalories()
        {
            Assert.Collection<IOrderItem>(Menu.FilterByCalories(Menu.FullMenu(), null, null), x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""));
            Assert.Collection<IOrderItem>(Menu.FilterByCalories(Menu.FullMenu(), 900, null), x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""));
            Assert.Collection<IOrderItem>(Menu.FilterByCalories(Menu.FullMenu(), null, 1000), x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""));
        }
        [Fact]
        public void ShouldFilterPrice()
        {
            Assert.Collection<IOrderItem>(Menu.FilterByPrice(Menu.FullMenu(), null, null), x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""));
            Assert.Collection<IOrderItem>(Menu.FilterByPrice(Menu.FullMenu(), 8, null), x => x.ToString().Equals(""));
            Assert.Collection<IOrderItem>(Menu.FilterByPrice(Menu.FullMenu(), null, 10), x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""),
                                                                                                     x => x.ToString().Equals(""));
        }
    }
}
