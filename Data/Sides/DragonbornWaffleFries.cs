/*
 * Author: Richard Bach
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
    {
        private double price = 0.93;
        /// <summary>
        /// returns the price of the Dragonborn Waffle Fries
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }

        private uint calories = 41;
        /// <summary>
        /// returns the calories of the Dragonborn Waffle Fries
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
                    Price = 0.42;
                    Calories = 77;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 0.76;
                    Calories = 89;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 0.96;
                    Calories = 100;
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
            sizeReturn += "Dragonborn Waffle Fries";
            return sizeReturn;
        }
    }
}
