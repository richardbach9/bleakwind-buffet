/*
 * Author: Richard Bach
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class MarkarthMilk
    {
        private double price = 1.05;
        /// <summary>
        /// sets and returns the price of the Markarth Milk
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }
        private uint calories = 56;
        /// <summary>
        /// sets and returns the calories of the Markarth Milk
        /// </summary>
        public uint Calories
        {
            get => calories;
            set => calories = value;
        }

        private bool ice = false;
        /// <summary>
        /// returns a bool representing whether or not the drink comes with ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }
        /// <summary>
        /// creates a list of special instruction for making the drink and returns it
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// sets the size, price, and calories to their corresponding values given the size taken in. return the size of the drink
        /// </summary>
        public Size Size
        {
            get => size;
            set
            {
                if (value.Equals(Size.Small))
                {
                    Price = 1.05;
                    Calories = 56;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 1.11;
                    Calories = 72;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 1.22;
                    Calories = 93;
                }
                size = value;
            }
        }
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
            sizeReturn += "Markarth Milk";
            return sizeReturn;
        }
    }
}
