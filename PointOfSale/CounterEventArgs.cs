using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public class CounterEventArgs : EventArgs
    {
        public bool AddorSub { get; private set; }
        public CounterEventArgs(string name)
        {
            if (name.Equals("plus"))
            {
                AddorSub = true;
            }
            else AddorSub = false;
        }
    }
}
