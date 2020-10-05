using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// An abstract class serving as a base class for all entree classes
    /// </summary>
    public abstract class Entree: INotifyPropertyChanged
    {
        /// <summary>
        /// Represents the price of the entree
        /// </summary>
        /// <value>In US Dollars</value>
        public abstract double Price { get; }
        /// <summary>
        /// Represents the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Represents the special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
