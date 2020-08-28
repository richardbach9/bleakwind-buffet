/*
 * Author: Richard Bach
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class ThalmorTriple
    {
        /// <summary>
        /// returns the price of the Thalmor Triple
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// returns the calories of the Thalmor Triple
        /// </summary>
        public uint Calories => 943;

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
        private bool bacon = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has bacon
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set => bacon = value;
        }
        private bool egg = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the burger has egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set => egg = value;
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}

