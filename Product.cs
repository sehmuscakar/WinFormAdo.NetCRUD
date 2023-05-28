using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetGiriş
{
    //stok takip Uygulaması 
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }//fiyat

        public int StockAmount{ get; set; } //stok miktarı

    }
}
