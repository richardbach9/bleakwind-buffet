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
    /// <summary>
    /// Represents the Aretino Apple Juice drink item keeping track of the price, calories, ingredients, size,
    /// and any special instructions when making the drink. Also has the ToString() method overrided
    /// to return the name of the drink.
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        private double price = 0.62;
        /// <value>
        /// sets and returns the price of the Aretino Apple Juice
        /// </value>
        public override double Price
        {
            get => price;
            set => price = value;
        }
        private uint calories = 44;
        /// <value>
        /// sets and returns the calories of the Aretino Apple Juice
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
        /// <value>
        /// creates a list of special instruction for making the drink and returns it
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
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
        /// <returns>the size and name of the drink</returns>
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
