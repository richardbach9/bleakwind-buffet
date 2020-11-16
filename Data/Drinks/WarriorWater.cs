/*
 * Author: Richard Bach
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents the warrior water drink item keeping track of the price, calories, ingredients, size,
    /// and any special instructions when making the drink. Also has the ToString() method overrided
    /// to return the name of the drink.
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
        private double price = 0.00;
        /// <value>
        /// sets and returns the price of the Warrior Water
        /// </value>
        public override double Price
        {
            get => price;
            set
            {
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        private uint calories = 0;
        /// <value>
        /// sets and returns the calories of the Warrior Water
        /// </value>
        public override uint Calories
        {
            get => calories;
            set
            {
                calories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        private bool ice = true;
        /// <value>
        /// returns a bool representing whether or not the drink comes with ice
        /// </value>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }
        /// <value>
        /// creates a list of special instruction for making the drink and returns it
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        private Size size = Size.Small;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// sets the size, price, and calories to their corresponding values given the size taken in. return the size of the drink
        /// </value>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        /// <summary>
        /// overrides ToString() and returns the size, caffination, name of the drink
        /// </summary>
        /// <returns>the size, caffination, and name of the drink</returns>
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
            sizeReturn += "Warrior Water";
            return sizeReturn;
        }
        /// <summary>
        /// returns a description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "It's water. Just water.";
            }
        }
    }
}
