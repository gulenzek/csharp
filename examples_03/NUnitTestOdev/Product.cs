using System;

namespace NUnitTestOdev
{
    public class Product
    {
        private double _unitPrice;
        private int _stockAmount;

        public int Id { get; set; }
        public String Name { get; set; }
        public double UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Value must be positive");
                _unitPrice = value;
            }
        }
        public int StockAmount
        {
            get { return _stockAmount; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Value must be positive and zero");
                _stockAmount = value;
            }
        }
    }
}