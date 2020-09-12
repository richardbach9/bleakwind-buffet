using System;
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
    }
}
