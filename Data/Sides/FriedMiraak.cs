/*
 * Author: Richard Bach
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class FriedMiraak
    {
        private double price = 1.78;
        /// <summary>
        /// returns the price of the Fried Miraak
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }

        private uint calories = 151;
        /// <summary>
        /// returns the calories of the Fried Miraak 
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
                    Price = 1.78;
                    Calories = 151;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 2.01;
                    Calories = 236;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 2.88;
                    Calories = 306;
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
            sizeReturn += "Fried Miraak";
            return sizeReturn;
        }
    }
}
