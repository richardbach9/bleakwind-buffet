/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            Assert.Equal(Size.Small, madOtarGrits.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = Size.Large;
            Assert.Equal(Size.Large, madOtarGrits.Size);
            madOtarGrits.Size = Size.Medium;
            Assert.Equal(Size.Medium, madOtarGrits.Size);
            madOtarGrits.Size = Size.Small;
            Assert.Equal(Size.Small, madOtarGrits.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            Assert.Empty(madOtarGrits.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = size;
            Assert.Equal(price, madOtarGrits.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = size;
            Assert.Equal(calories, madOtarGrits.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = size;
            Assert.Equal(name, madOtarGrits.ToString());
        }
    }
}