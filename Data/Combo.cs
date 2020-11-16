using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class represents a combo containing a drink, entree, and side as well as total price, calories, and special instructions. 
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        private Drink drink = null;
        /// <summary>
        /// Represents the drink in the combo
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink == null)
                {
                    drink = value;
                    Price = Price + drink.Price;
                    Calories = Calories + drink.Calories;
                }
                else
                {
                    Price = Price - drink.Price;
                    Calories = Calories - drink.Calories;
                    drink = value;
                    Price = Price + drink.Price;
                    Calories = Calories + drink.Calories;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special Instructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
            }
        }
        private Side side = null;
        /// <summary>
        /// Represents the side in the combo
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side == null)
                {
                    side = value;
                    Price = Price + side.Price;
                    Calories = Calories + side.Calories;
                }
                else
                {
                    Price = Price - side.Price;
                    Calories = Calories - side.Calories;
                    side = value;
                    Price = Price + side.Price;
                    Calories = Calories + side.Calories;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special Instructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
            }
        }
        private Entree entree = null;
        /// <summary>
        /// Event handler for when properties change in the class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Represents the entree in the combo
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if(entree == null)
                {
                    entree = value;
                    Price = Price + entree.Price;
                    Calories = Calories + entree.Calories;

                }
                else
                {
                    Price = Price - entree.Price;
                    Calories = Calories - entree.Calories;
                    entree = value;
                    Price = Price + entree.Price;
                    Calories = Calories + entree.Calories;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special Instructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
            }
        }

        private double price = -1;
        /// <value>
        /// returns the price of the Order
        /// </value>
        public double Price
        {
            get => price;
            set
            {
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        private uint calories = 0;
        /// <value>
        /// returns the calories of the Order
        /// </value>
        public uint Calories
        {
            get => calories;
            set
            {
                calories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        /// <summary>
        /// Contains the special instructions for all items in the combo combined
        /// </summary>

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                
                if(entree != null)
                {
                    for (int i = 0; i < entree.SpecialInstructions.Count; i++)
                    {
                        instructions.Add(entree.SpecialInstructions[i]);
                    }
                }
                if (drink != null)
                {
                    for (int i = 0; i < drink.SpecialInstructions.Count; i++)
                    {
                        instructions.Add(drink.SpecialInstructions[i]);
                    }
                }
                if (side != null)
                {
                    for (int i = 0; i < side.SpecialInstructions.Count; i++)
                    {
                        instructions.Add(side.SpecialInstructions[i]);
                    }
                }
                return instructions;
            }
        }
        /// <summary>
        /// returns a string containing all items and special instructions in the combo
        /// </summary>
        /// <returns>string containing all items and special instructions in the combo</returns>
        public override string ToString()
        {
            string s = "";
            if(Entree != null)
            {
                s += (" " + Entree.ToString() + "\n" + "      - $" + String.Format("{0:0.##}", Entree.Price) + "\n");
                for (int i = 0; i < Entree.SpecialInstructions.Count; i++)
                {
                    s += ("      -" + Entree.SpecialInstructions[i] + "\n");
                }
            }
            if(Drink != null)
            {
                s += (" " + Drink.ToString() + "\n" + "      - $" + String.Format("{0:0.##}", Drink.Price) + "\n");
                for (int i = 0; i < Drink.SpecialInstructions.Count; i++)
                {
                    s += ("      -" + Drink.SpecialInstructions[i] + "\n");
                }
            }
            if(Side != null)
            {
                s += (" " + Side.ToString() + "\n" + "      - $" + String.Format("{0:0.##}", Side.Price) + "\n");
                for (int i = 0; i < Side.SpecialInstructions.Count; i++)
                {
                    s += ("      -" + Side.SpecialInstructions[i] + "\n");
                }
            }
            s += (" Combo Discount" + "\n" + "      - $1.00\n");
            return s;
        }
        /// <summary>
        /// returns a description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "A combination of a drink, side, and entree for a $1 discount.";
            }
        }
    }
}
