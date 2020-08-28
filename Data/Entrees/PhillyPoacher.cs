/*
 * Author: Richard Bach
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        /// <summary>
        /// returns the price of the Philly Poacher
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// returns the calories of the Philly Poacher
        /// </summary>
        public uint Calories => 784;

        private bool sirloin = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the sandwich comes with sirloin
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set => sirloin = value;
        }

        private bool onions = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the sandwich comes with onions
        /// </summary>
        public bool Onions
        {
            get => onions;
            set => onions = value;
        }

        private bool roll = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the sandwich comes with a roll
        /// </summary>
        public bool Roll
        {
            get => roll;
            set => roll = value;
        }
        /// <summary>
        /// creates a list of special instruction for making the sandwich and returns it
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
