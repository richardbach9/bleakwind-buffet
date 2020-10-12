using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.ObjectModel;
namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing an order 
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>, ICollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged
    {
        /// <summary>
        /// Represents the order number for the next order
        /// </summary>
        private static int nextOrderNumber = 1;
        /// <summary>
        /// Represents the order number for this order
        /// </summary>
        public int Number;
        /// <summary>
        /// private list containing entree items
        /// </summary>
        public List<IOrderItem> list = new List<IOrderItem>();
        /// <summary>
        /// private double representing the sales tax rate
        /// </summary>
        private double salesTaxRate = 0.12;
        /// <summary>
        /// constructor for the order class
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }
        /// <summary>
        /// private backing variable holding the subtotal of the order
        /// </summary>
        private double subtotal = 0;
        /// <summary>
        /// represents the subtotal of the order
        /// </summary>
        public double Subtotal
        {
            get => subtotal;
            
            set
            {
                subtotal = value;
                Tax = subtotal * SalesTaxRate;
                Total = subtotal + Tax;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
        /// <summary>
        /// private backing variable representing the tax
        /// </summary>
        private double tax = 0;
        /// <summary>
        /// represents the tax value added to the subtotal
        /// </summary>
        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            }
        }
        /// <summary>
        /// private backing variable representing the total cost of the order
        /// </summary>
        private double total = 0;
        /// <summary>
        /// represents the total cost of the order
        /// </summary>
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }

        }
        /// <summary>
        /// getter and setter of the sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
            }
        }
        /// <summary>
        /// represents the size of the collection
        /// </summary>
        public int Count
        {
            get
            {
                return list.Count;
            }
        }
        /// <summary>
        /// not implemented
        /// </summary>
        public bool IsReadOnly => throw new NotImplementedException();
        /// <summary>
        /// property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// collection changed event handler
        /// </summary>
        public override event NotifyCollectionChangedEventHandler CollectionChanged;
        /// <summary>
        /// private backing variable for the calories of the order
        /// </summary>
        private uint calories = 0;
        /// <summary>
        /// getter and setter of the calories of the order
        /// </summary>
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        /// <summary>
        /// adds an item into the collection
        /// </summary>
        /// <param name="item">a menu item</param>
        public void Add(IOrderItem item)
        {
            list.Add(item);
            Calories = Calories + item.Calories;
            Subtotal = Subtotal + item.Price;
            
        }
        /// <summary>
        /// not implemented
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <param name="item">menu item</param>
        /// <returns>true or false</returns>
        public bool Contains(IOrderItem item)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <param name="array">not implemented</param>
        /// <param name="arrayIndex">not implemented</param>
        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <returns>not implemented</returns>
        public IEnumerator<IOrderItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <param name="item">menu item</param>
        /// <returns>true of false</returns>
        public bool Remove(IOrderItem item)
        {
            Calories = Calories - item.Calories;
            Subtotal += -1 * item.Price;
            return list.Remove(item);
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <returns>not implemented</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(IOrderItem item in list)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(IOrderItem item in list)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
            }
        }
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
            else if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
