﻿/*
 * Author: Richard Bach
 * Class name: ThugTbone.cs
 * Purpose: Class used to represent the Thugs T-Bone entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Garden Orc Omelette entree item keeping track of the price, calories,
    /// and any special instructions when making the entree. Also has the ToString() method overrided
    /// to return the name of the entree.
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <value>
        /// returns the price of the Thugs T-Bone
        /// </value>
        public override double Price => 6.44;

        /// <value>
        /// returns the calories of the Thugs T-Bone
        /// </value>
        public override uint Calories => 982;

        /// <value>
        /// creates a list of special instruction for making the steak and returns it. It will always be empty
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// returns a string containing the name of the order
        /// </summary>
        /// <returns>the name of the order</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
        /// <summary>
        /// returns a description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Juicy T-Bone, not much else to say.";
            }
        }
    }
}
