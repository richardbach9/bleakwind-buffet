/*
 * Author: Richard Bach
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    class WarriorWater
    {
        private double price = 0.00;
        /// <summary>
        /// sets and returns the price of the Warrior Water
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }
        private uint calories = 0;
        /// <summary>
        /// sets and returns the calories of the Warrior Water
        /// </summary>
        public uint Calories
        {
            get => calories;
            set => calories = value;
        }

        private bool ice = true;
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
                if (!Ice) instructions.Add("Hold ice");
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
            set => size = value;
        }
        /// <summary>
        /// overrides ToString() and returns the size, caffination, name of the drink
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
            sizeReturn += "Candlehearth Coffee";
            return sizeReturn;
        }
    }
}
