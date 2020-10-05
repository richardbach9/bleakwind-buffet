/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }
        [Fact]
        public void ShouldBeINotifyPropertyChanged()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }
        [Fact]
        public void SausageLinkChangeShouldTriggerPropertyChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Sausage Link", () =>
            {
                ss.SausageLink = false;
            });
        }
        [Fact]
        public void EggChangeShouldTriggerPropertyChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = false;
            });
        }
        [Fact]
        public void HashBrownChangeShouldTriggerPropertyChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Hash Browns", () =>
            {
                ss.HashBrowns = false;
            });
        }
        [Fact]
        public void PancakeChangeShouldTriggerPropertyChange()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = false;
            });
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldIncludeSausageByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.SausageLink);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.SausageLink = false;
            Assert.False(smokehouseSkeleton.SausageLink);
            smokehouseSkeleton.SausageLink = true;
            Assert.True(smokehouseSkeleton.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.Egg = false;
            Assert.False(smokehouseSkeleton.Egg);
            smokehouseSkeleton.Egg = true;
            Assert.True(smokehouseSkeleton.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.HashBrowns = false;
            Assert.False(smokehouseSkeleton.HashBrowns);
            smokehouseSkeleton.HashBrowns = true;
            Assert.True(smokehouseSkeleton.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.Pancake = false;
            Assert.False(smokehouseSkeleton.Pancake);
            smokehouseSkeleton.Pancake = true;
            Assert.True(smokehouseSkeleton.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.Equal(5.62, smokehouseSkeleton.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.Equal(602, (int)smokehouseSkeleton.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };
            if (!includeSausage) Assert.Contains("Hold sausage", smokehouseSkeleton.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", smokehouseSkeleton.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", smokehouseSkeleton.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", smokehouseSkeleton.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", smokehouseSkeleton.ToString());
        }
    }
}