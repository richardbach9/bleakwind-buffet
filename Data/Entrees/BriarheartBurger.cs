﻿/*
 * Author: Richard Bach
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Briarheart Burger entree item keeping track of the price, calories, ingredients,
    /// and any special instructions when making the entree. Also has the ToString() method overrided
    /// to return the name of the entree.
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
        /// <value>
        /// returns the price of the Briarheart Burger
        /// </value>
        public override double Price => 6.32;

        /// <value>
        /// returns the calories of the Briarheart Burger
        /// </value>
        public override uint Calories => 743;

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

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// set and returns the bool represnting whether or not the burger has cheese
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
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the burger
        /// </summary>
        /// <returns>the name of the burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
        /// <summary>
        /// returns a description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }
    }
}
