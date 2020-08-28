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
    class GardenOrcOmelette
    {
        /// <summary>
        /// returns the price of the Garden Orc Omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// returns the calories of the Garden Orc Omelette
        /// </summary>
        public uint Calories => 404;

        private bool broccoli = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the dish comes with broccoli
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }

        private bool mushrooms = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the dish comes with mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;
        }

        private bool tomato = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the dish comes with tomatos
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }
        private bool cheddar = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the order includes cheddar
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set => cheddar = value;
        }
        /// <summary>
        /// creates a list of special instruction for making the dish and returns it
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
