/*
 * Author: Richard Bach
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor's Soda drink
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Represents the Sailors Soda drink item keeping track of the price, calories, ingredients, size, 
    /// and any special instructions when making the drink. Also has the ToString() method overrided
    /// to return the name of the drink.
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        private double price = 1.42;
        /// <value>
        /// sets and returns the price of the Sailor's Soda
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
        private uint calories = 117;
        /// <value>
        /// sets and returns the calories of the Sailor's Soda
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        private SodaFlavor sodaFlavor = SodaFlavor.Cherry;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// sets and returns the soda flavor of the drink
        /// </value>
        public SodaFlavor SodaFlavor
        {
            get => sodaFlavor;
            set
            {
                sodaFlavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Soda Flavor"));
            }
        }
        /// <summary>
        /// overrides ToString() and returns the size, flavor, and name of the drink
        /// </summary>
        /// <returns>the size, flacor, and name of the drink</returns>
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
