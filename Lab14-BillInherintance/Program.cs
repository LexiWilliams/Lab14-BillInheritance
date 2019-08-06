using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_BillInherintance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill(15.80, 0.06);
            TippableBill tippableBill = new TippableBill(2.0, 8.50, 0.06);

            Pay(bill);
            Pay(tippableBill);
        }
        public static void Pay(Bill bill)
        {
            Console.WriteLine($"${bill.CalcTotal()}");
        }
    }
}
