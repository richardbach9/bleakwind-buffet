/*
 * Author: Richard Bach
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class BriarheartBurger
    {
        /// <summary>
        /// returns the price of the Briarheart Burger
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// returns the calories of the Briarheart Burger
        /// </summary>
        public uint Calories => 743;

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
        /// set and returns the bool represnting whether or not the burger has cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
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
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
