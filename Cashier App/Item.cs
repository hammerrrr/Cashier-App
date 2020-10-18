using System;
using System.Collections.Generic;
using System.Text;

namespace Cashier_App
{
    class Item
    {
        private int id;
        public string title { get; set; }
        public int jumlah { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;

        public Item(int id, string title, int jumlah, string type, double price)
        {

        }
    }
}
