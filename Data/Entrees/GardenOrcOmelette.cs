/*
 * Author: Richard Bach
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Garden Orc Omelette entree item keeping track of the price, calories, ingredients,
    /// and any special instructions when making the entree. Also has the ToString() method overrided
    /// to return the name of the entree.
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <value>
        /// returns the price of the Garden Orc Omelette
        /// </value>
        public override double Price => 4.57;

        /// <value>
        /// returns the calories of the Garden Orc Omelette
        /// </value>
        public override uint Calories => 404;

        private bool broccoli = true;
        /// <value>
        /// sets and returns the bool representing whether or not the dish comes with broccoli
        /// </value>
        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }

        private bool mushrooms = true;
        /// <value>
        /// sets and returns the bool representing whether or not the dish comes with mushrooms
        /// </value>
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;
        }

        private bool tomato = true;
        /// <value>
        /// sets and returns the bool representing whether or not the dish comes with tomatos
        /// </value>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }
        private bool cheddar = true;
        /// <value>
        /// sets and returns the bool representing whether or not the order includes cheddar
        /// </value>
        public bool Cheddar
        {
            get => cheddar;
            set => cheddar = value;
        }
        /// <value>
        /// creates a list of special instruction for making the dish and returns it
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the order
        /// </summary>
        /// <returns>the name of the order</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
