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
    /// <summary>
    /// Represents the Dragonborn Waffle Fries side item keeping track of the price, calories, and size.
    /// Also has the ToString() method overrided to return the name of the side.
    /// </summary>
    public class DragonbornWaffleFries
    {
        private double price = 0.93;
        /// <value>
        /// returns the price of the Dragonborn Waffle Fries
        /// </value>
        public double Price
        {
            get => price;
            set => price = value;
        }

        private uint calories = 41;
        /// <value>
        /// returns the calories of the Dragonborn Waffle Fries
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
            sizeReturn += "Dragonborn Waffle Fries";
            return sizeReturn;
        }
    }
}
