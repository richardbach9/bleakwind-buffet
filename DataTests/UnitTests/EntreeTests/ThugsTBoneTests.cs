/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(ttb);
        }
        [Fact]
        public void ShouldBeINotifyPropertyChanged()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ttb);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(ttb);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone thugsTBone = new ThugsTBone();
            Assert.Equal(6.44, thugsTBone.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone thugsTBone = new ThugsTBone();
            Assert.Equal(982, (int)thugsTBone.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone thugsTBone = new ThugsTBone();
            Assert.Empty(thugsTBone.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone thugsTBone = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", thugsTBone.ToString());
        }
    }
}