/*
 * Author: Richard Bach
 * Class name: ThugTbone.cs
 * Purpose: Class used to represent the Thugs T-Bone entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        /// <summary>
        /// returns the price of the Thugs T-Bone
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// returns the calories of the Thugs T-Bone
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// creates a list of special instruction for making the steak and returns it. It will always be empty
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
