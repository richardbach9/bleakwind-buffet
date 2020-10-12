using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;
using System.Collections.Specialized;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTest
    {
        [Fact]
        public void ShouldBeICollection()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(order);
        }
        [Fact]
        public void ShouldBeINotifyCollectionChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }
        [Fact]
        public void ShouldBeINotifyPropertyChange()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }
        [Fact]
        public void AddItemShouldTriggerPropertyChange()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
        }
        [Fact]
        public void RemoveItemShouldTriggerPropertyChange()
        {
            Order order = new Order();
            order.Add(new AretinoAppleJuice());
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(new AretinoAppleJuice());
            });
            order.Add(new AretinoAppleJuice());
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(new AretinoAppleJuice());
            });
            order.Add(new AretinoAppleJuice());
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(new AretinoAppleJuice());
            });
            order.Add(new AretinoAppleJuice());
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(new AretinoAppleJuice());
            });
        }
    }
}
