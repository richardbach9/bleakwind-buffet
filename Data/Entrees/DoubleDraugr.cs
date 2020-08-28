/*
 * Author: Richard Bach
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class DoubleDraugr
    {
        /// <summary>
        /// returns the price of the Double Draugr
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// returns the calories of the Double Draugr
        /// </summary>
        public uint Calories => 843;

        private bool ketchup = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;
        }

        private bool bun = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has a bun
        /// </summary>
        public bool Bun
        {
            get => bun;
            set => bun = value;
        }

        private bool mustard = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }
        private bool pickle = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has pickles
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }
        private bool cheese = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }
        private bool tomato = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }

        private bool lettuce = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has lettuce
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value;
        }
        private bool mayo = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has mayo
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set => mayo = value;
        }
        /// <summary>
        /// creates a list of special instruction for making the burger and returns it
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
