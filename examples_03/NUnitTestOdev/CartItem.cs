using System;

namespace NUnitTestOdev
{
    public class CartItem
    {
        private int _amount;
        public Product Product { get; set; }
        public int Amount { 
            get {
                return _amount;
            } 
            set {
                if (value < 1)
                    throw new ArgumentException("Value must be positive");
                _amount = value;
            
            } }
    }
}