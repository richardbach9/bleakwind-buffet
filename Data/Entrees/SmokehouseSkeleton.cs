/*
 * Author: Richard Bach
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Represents the Smokehouse Skeleton entree item keeping track of the price, calories,
    /// and any special instructions when making the entree. Also has the ToString() method overrided
    /// to return the name of the entree.
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <value>
        /// returns the price of the Smokehouse Skeleton
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// returns the calories of the Smokehouse Skeleton
        /// </value>
        public override uint Calories => 602;

        private bool sausageLink = true;
        /// <value>
        /// sets and returns the bool representing whether or not the dish comes with sausage links
        /// </value>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sausage Link"));
            }
        }

        private bool egg = true;
        /// <value>
        /// sets and returns the bool representing whether or not the dish comes with eggs
        /// </value>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }

        private bool hashBrowns = true;
        /// <value>
        /// sets and returns the bool representing whether or not the dish comes with hash browns
        /// </value>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hash Browns"));
            }

        }
        private bool pancake = true;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// sets and returns the bool representing whether or not the order includes pancakes
        /// </value>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
            }
        }
        /// <value>
        /// creates a list of special instruction for making the dish and returns it
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing the name of the order
        /// </summary>
        /// <returns>the name of the order</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
        /// <summary>
        /// returns a description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }
    }
}
