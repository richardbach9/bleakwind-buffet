/*
 * Author: Richard Bach
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Fried Miraak side item keeping track of the price, calories, and sides. 
    /// Also has the ToString() method overrided to return the name of the side.
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        private double price = 1.78;
        /// <value>
        /// returns the price of the Fried Miraak
        /// </value>
        public override double Price
        {
            get => price;
            set => price = value;
        }

        private uint calories = 151;
        /// <value>
        /// returns the calories of the Fried Miraak 
        /// </value>
        public override uint Calories
        {
            get => calories;
            set => calories = value;
        }
        private Size size = Size.Small;
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
                    Price = 1.78;
                    Calories = 151;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 2.01;
                    Calories = 236;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 2.88;
                    Calories = 306;
                }
                size = value;
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
            sizeReturn += "Fried Miraak";
            return sizeReturn;
        }
    }
}
