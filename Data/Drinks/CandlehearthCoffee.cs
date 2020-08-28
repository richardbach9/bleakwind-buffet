/*
 * Author: Richard Bach
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        private double price = 0.75;
        /// <summary>
        /// sets and returns the price of the Candlehearth Coffee
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }
        private uint calories = 7;
        /// <summary>
        /// sets and returns the calories of the Candlehearth Coffee
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
        private bool roomforcream = false;
        /// <summary>
        /// returns a bool representing whether or not the drink comes will cream
        /// </summary>
        public bool RoomForCream
        {
            get => roomforcream;
            set => roomforcream = value;
        }
        private bool decaf = false;
        /// <summary>
        /// returns a bool representing whether or not the drink will be decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set => decaf = value;
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
                if (RoomForCream) instructions.Add("Add cream");
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
                    Price = 0.75;
                    Calories = 7;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 1.25;
                    Calories = 10;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 1.75;
                    Calories = 20;
                }
                size = value;
            }
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
            if (Decaf) sizeReturn += "Decaf ";
            sizeReturn += "Candlehearth Coffee";
            return sizeReturn;
        }
    }
}
