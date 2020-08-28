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
    class MadOtarGrits
    {
        private double price = 1.22;
        /// <summary>
        /// returns the price of the Mad Otar Grits
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }

        private uint calories = 105;
        /// <summary>
        /// returns the calories of the Mad Otar Grits
        /// </summary>
        public uint Calories
        {
            get => calories;
            set => calories = value;
        }
        private Size size = Size.Small;
        /// <summary>
        /// sets the size, price, and calories to their corresponding values given the size taken in. return the size of the side
        /// </summary>
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
        /// <returns></returns>
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
