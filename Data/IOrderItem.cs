using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface representing an item's ability to be ordered and the properties associated with that
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Represents the price of the item
        /// </summary>
        double Price { get;}
        /// <summary>
        /// Represents the calories of the item
        /// </summary>
        uint Calories { get;}
        /// <summary>
        /// Represents the special instructions for the item
        /// </summary>
        List<string> SpecialInstructions { get; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}
