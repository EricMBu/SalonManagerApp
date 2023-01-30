using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Procedure : Product
    {
        public int _minutes { get; private set; }
        public Procedure(string name, string description, double price, int minutes) : base(name, description, price)
        {          
            this._name = name;
            this._description = description;
            this._price = price;
            this._minutes = minutes;    
        }
        public void SetMinutes(int setMinutes)
        {
            _minutes = setMinutes;
        }
        
    }
}
