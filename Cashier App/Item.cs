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
            this.id = id;
            this.title = title;
            this.jumlah = jumlah;
            this.price = price;
            this.subtotal = 0;
            this.type = type;
        }

        public string getTtitle() => title;
        public int getJumlah() => jumlah;
        public string getType() => type;
        public double getPrice() => price;
        public double getSubtotal() => price * jumlah;
    }
}
