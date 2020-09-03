/*
 * Author: Richard Bach
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Mad Otar Grits side item keeping track of the price, calories,
    /// and size. Also has the ToString() method overrided
    /// to return the name of the side.
    /// </summary>
    class MadOtarGrits
    {
        private double price = 1.22;
        /// <value>
        /// returns the price of the Mad Otar Grits
        /// </value>
        public double Price
        {
            get => price;
            set => price = value;
        }

        private uint calories = 105;
        /// <value>
        /// returns the calories of the Mad Otar Grits
        /// </value>
        public uint Calories
        {
            get => calories;
            set => calories = value;
        }
        private Size size = Size.Small;
        /// <value>
        /// sets the size, price, and calories to their corresponding values given the size taken in. return the size of the side
        /// </value>
        public Size Size
        {
            get => size;
            set
            {
                if (value.Equals(Size.Small))
                {
                    Price = 1.22;
                    Calories = 105;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 1.58;
                    Calories = 142;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 1.93;
                    Calories = 179;
                }
                size = value;
            }
        }

        /// <summary>
        /// overrides ToString() and returns the size and name of the side
        /// </summary>
        /// <returns>the size and name of the side</returns>
        public override string ToString()
        {
            string sizeReturn = "";
            switch (size)
            {
                case Size.Large:
                    sizeReturn += "Large ";
                    break;
                case Size.Medium:
                    sizeReturn += "Medium ";
                    break;
                case Size.Small:
                    sizeReturn += "Small ";
                    break;
            }
            sizeReturn += "Mad Otar Grits";
            return sizeReturn;
        }
    }
}
