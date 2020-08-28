/*
 * Author: Richard Bach
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    class SmokehouseSkeleton
    {
        /// <summary>
        /// returns the price of the Smokehouse Skeleton
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// returns the calories of the Smokehouse Skeleton
        /// </summary>
        public uint Calories => 602;

        private bool sausageLink = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the dish comes with sausage links
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set => sausageLink = value;
        }

        private bool egg = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the dish comes with eggs
        /// </summary>
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }

        private bool hashBrowns = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the dish comes with hash browns
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set => hashBrowns = value;
        }
        private bool pancake = true;
        /// <summary>
        /// sets and returns the bool representing whether or not the order includes pancakes
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
        }
        /// <summary>
        /// creates a list of special instruction for making the dish and returns it
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
