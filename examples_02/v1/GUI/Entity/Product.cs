using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Entity
{
    class Product : IEntity
    {

        private int _stockAmount;

        public int Id { get; set; }
        public String Name { get; set; }
        public int StockAmount {
            get
            {
                return _stockAmount;
            }
            set
            {
                if (value < 5)
                    _action();
                _stockAmount = value;
            }
        }
        public double UnitPrice { get; set; }

        private event Action _action;

        public Product()
        {
            _action += () =>
            {
                MessageBox.Show($"id => {Id} {Name}, Stock amount under 5");
            };
        }

        public override string ToString()
        {
            return $"{Id} => {Name}";
        }


    }
}
