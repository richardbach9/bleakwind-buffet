/*
 * Author: Richard Bach
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Double Draugr entree item keeping track of the price, calories, ingredients,
    /// and any special instructions when making the entree. Also has the ToString() method overrided
    /// to return the name of the entree.
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem
    {
        /// <value>
        /// returns the price of the Double Draugr
        /// </value>
        public override double Price => 7.32;

        /// <value>
        /// returns the calories of the Double Draugr
        /// </value>
        public override uint Calories => 843;

        private bool ketchup = true;
        /// <value>
        /// sets and returns the bool representing whether or not the burger has ketchup
        /// </value>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        private bool bun = true;
        /// <value>
        /// sets and returns the bool representing whether or not the burger has a bun
        /// </value>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }

        private bool mustard = true;
        /// <value>
        /// sets and returns the bool representing whether or not the burger has mustard
        /// </value>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }
        private bool pickle = true;
        /// <value>
        /// sets and returns the bool representing whether or not the burger has pickles
        /// </value>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }
        private bool cheese = true;
        /// <value>
        /// sets and returns the bool representing whether or not the burger has cheese
        /// </value>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }
        private bool tomato = true;
        /// <value>
        /// sets and returns the bool representing whether or not the burger has tomato
        /// </value>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        private bool lettuce = true;
        /// <value>
        /// sets and returns the bool representing whether or not the burger has lettuce
        /// </value>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }
        private bool mayo = true;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// sets and returns the bool representing whether or not the burger has mayo
        /// </value>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }
        /// <value>
        /// creates a list of special instruction for making the burger and returns it
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>the name of the burger</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
        /// <summary>
        /// returns a description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
            }
        }
    }
}
