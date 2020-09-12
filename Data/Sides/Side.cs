using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the side items
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Represents the size of the side
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// Represents the price of the side
        /// </summary>
        /// <value>In US Dollar</value> 
        public abstract double Price { get; set; }
        /// <summary>
        /// Represents the calories of the side
        /// </summary>
        public abstract uint Calories { get; set; }
        /// <summary>
        /// Represents the special instructions for the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
