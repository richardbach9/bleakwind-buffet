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
    /// <summary>
    /// Represents the Candlehearth Coffee drink item keeping track of the price, calories, ice, cream, decaf, size,
    /// and any special instructions when making the drink. Also has the ToString() method overrided
    /// to return the name of the drink.
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        private double price = 0.75;
        /// <value>
        /// sets and returns the price of the Candlehearth Coffee
        /// </value>
        public override double Price
        {
            get => price;
            set => price = value;
        }
        private uint calories = 7;
        /// <value>
        /// sets and returns the calories of the Candlehearth Coffee
        /// </value>
        public override uint Calories
        {
            get => calories;
            set => calories = value;
        }

        private bool ice = false;
        /// <value>
        /// returns a bool representing whether or not the drink comes with ice
        /// </value>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }
        private bool roomforcream = false;
        /// <value>
        /// returns a bool representing whether or not the drink comes will cream
        /// </value>
        public bool RoomForCream
        {
            get => roomforcream;
            set => roomforcream = value;
        }
        private bool decaf = false;
        /// <value>
        /// returns a bool representing whether or not the drink will be decaf
        /// </value>
        public bool Decaf
        {
            get => decaf;
            set => decaf = value;
        }
        /// <value>
        /// creates a list of special instruction for making the drink and returns it
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <value>
        /// sets the size, price, and calories to their corresponding values given the size taken in. return the size of the drink
        /// </value>
        public override Size Size
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
        /// <returns>the size, caffination, name of the drink</returns>
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
