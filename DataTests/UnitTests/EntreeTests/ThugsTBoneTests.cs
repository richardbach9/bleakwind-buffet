﻿/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
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