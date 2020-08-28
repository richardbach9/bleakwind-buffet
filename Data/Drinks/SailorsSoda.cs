/*
 * Author: Richard Bach
 * Class name: SailorsSoda.cs
 * Purpose: Class used to represent the Sailor's Soda drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorsSoda
    {
        private double price = 1.42;
        /// <summary>
        /// sets and returns the price of the Sailor's Soda
        /// </summary>
        public double Price
        {
            get => price;
            set => price = value;
        }
        private uint calories = 117;
        /// <summary>
        /// sets and returns the calories of the Sailor's Soda
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
            set
            {
                if (value.Equals(Size.Small))
                {
                    Price = 1.42;
                    Calories = 117;
                }
                else if (value.Equals(Size.Medium))
                {
                    Price = 1.74;
                    Calories = 153;
                }
                else if (value.Equals(Size.Large))
                {
                    Price = 2.07;
                    Calories = 205;
                }
                size = value;
            }
        }
        private SodaFlavor sodaFlavor = SodaFlavor.Cherry;
        /// <summary>
        /// sets and returns the soda flavor of the drink
        /// </summary>
        public SodaFlavor SodaFlavor
        {
            get => sodaFlavor;
            set => sodaFlavor = value;
        }
        /// <summary>
        /// overrides ToString() and returns the size, flavor, and name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sizeReturn = "";
            switch(size)
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
            switch(sodaFlavor)
            {
                case SodaFlavor.Blackberry:
                    sizeReturn += "Blackberry ";
                    break;
                case SodaFlavor.Cherry:
                    sizeReturn += "Cherry ";
                    break;
                case SodaFlavor.Grapefruit:
                    sizeReturn += "Grapefruit ";
                    break;
                case SodaFlavor.Lemon:
                    sizeReturn += "Lemon ";
                    break;
                case SodaFlavor.Peach:
                    sizeReturn += "Peach ";
                    break;
                case SodaFlavor.Watermelon:
                    sizeReturn += "Watermelon ";
                    break;
            }
            sizeReturn += "Sailor Soda";
            return sizeReturn;
        }
    }
}
