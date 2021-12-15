using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    public class Purchase
    {
        int id;
        double quantity;
        string description;

        public Purchase(int id, double quantity, string description) {
            this.id = id;
            this.quantity = quantity;
            this.description = description;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Descrption
        {
            get { return description; }
            set { description = value; }
        }

    }
}
