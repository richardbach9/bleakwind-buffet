/*
 * Author: Richard Bach
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Philly Poacher entree item keeping track of the price, calories, ingredients,
    /// and any special instructions when making the entree. Also has the ToString() method overrided
    /// to return the name of the entree.
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <value>
        /// returns the price of the Philly Poacher
        /// </value>
        public override double Price => 7.23;

        /// <value>
        /// returns the calories of the Philly Poacher
        /// </value>
        public override uint Calories => 784;

        private bool sirloin = true;
        /// <value>
        /// sets and returns the bool representing whether or not the sandwich comes with sirloin
        /// </value>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
            }
        }

        private bool onions = true;
        /// <value>
        /// sets and returns the bool representing whether or not the sandwich comes with onions
        /// </value>
        public bool Onions
        {
            get => onions;
            set
            {
                onions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onions"));
            }
        }

        private bool roll = true;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// sets and returns the bool representing whether or not the sandwich comes with a roll
        /// </value>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
            }
        }
        /// <value>
        /// creates a list of special instruction for making the sandwich and returns it
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onions) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the order
        /// </summary>
        /// <returns>the name of the order</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
