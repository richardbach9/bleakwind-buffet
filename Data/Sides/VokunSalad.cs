/*
 * Author: Richard Bach
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Vokun Salad side item keeping track of the price, calories,
    /// and size. Also has the ToString() method overrided
    /// to return the name of the side.
    /// </summary>
    public class VokunSalad : Side, IOrderItem
    {
        private double price = 0.93;
        /// <value>
        /// returns the price of the Vokun Salad
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

        private uint calories = 41;
        /// <value>
        /// returns the calories of the Vokun Salad
        /// </value>
        public override  uint Calories
        {
            get => calories;
            set
            {
                calories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        private Size size = Size.Small;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// sets the size, price, and calories to their corresponding values given the size taken in. return the size of the side
        /// </value>
        public override Size Size
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        /// <value>
        /// creates a list of special instruction and returns it
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
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
            sizeReturn += "Vokun Salad";
            return sizeReturn;
        }
        /// <summary>
        /// returns a description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
            }
        }
    }
}
