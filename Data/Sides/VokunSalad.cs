/*
 * Author: Richard Bach
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
    {
        private double price = 0.93;
        /// <summary>
        /// returns the price of the Vokun Salad
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }

        private uint calories = 41;
        /// <summary>
        /// returns the calories of the Vokun Salad
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
                    Price = 0.93;
                    Calories = 41;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 1.28;
                    Calories = 52;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 1.82;
                    Calories = 73;
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
            sizeReturn += "Vokun Salad";
            return sizeReturn;
        }
    }
}
