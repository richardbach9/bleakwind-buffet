/*
 * Author: Richard Bach
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Represents the Mad Otar Grits side item keeping track of the price, calories,
    /// and size. Also has the ToString() method overrided
    /// to return the name of the side.
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        private double price = 1.22;
        /// <value>
        /// returns the price of the Mad Otar Grits
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

        private uint calories = 105;
        /// <value>
        /// returns the calories of the Mad Otar Grits
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
                    Price = 1.22;
                    Calories = 105;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 1.58;
                    Calories = 142;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 1.93;
                    Calories = 179;
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
            sizeReturn += "Mad Otar Grits";
            return sizeReturn;
        }
    }
}
