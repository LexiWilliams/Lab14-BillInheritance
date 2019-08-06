using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_BillInherintance
{
    class TippableBill:Bill
    {
        public double Tip { get; set; }

        public TippableBill()
        {
        }

        public TippableBill(double tip, double subtotal, double taxRate):base(subtotal, taxRate)
        {
            Tip = tip;
            Subtotal = subtotal;
            TaxRate = taxRate;
        }
        public override double CalcTotal()
        {
            return (Tip + (Subtotal * (1 + TaxRate)));
        }
    }
}
