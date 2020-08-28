/*
 * Author: Richard Bach
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    class AretinoAppleJuice
    {
        private double price = 0.62;
        /// <summary>
        /// sets and returns the price of the Aretino Apple Juice
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }
        private uint calories = 44;
        /// <summary>
        /// sets and returns the calories of the Aretino Apple Juice
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
                    Price = 0.62;
                    Calories = 44;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 0.87;
                    Calories = 88;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 1.01;
                    Calories = 132;
                }
                size = value;
            }
        }
        /// <summary>
        /// overrides ToString() and returns the size and name of the drink
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
            sizeReturn += "Aretino Apple Juice";
            return sizeReturn;
        }
    }
}
