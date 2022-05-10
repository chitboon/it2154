using System;
using System.Collections.Generic;
using System.Linq;

namespace q1
{

    class Program
    {
        static void Main(string[] args)
        {
            var stock = new List<Product>();
            
            stock.Add(new Product() { Id = 2, Name="orange", Qty=20});

            stock.Add(new Product() { Id = 1, Name = "apple", Qty = 20 });
            stock.Add(new Product() { Id = 2, Name = "orange", Qty = 8 });
            var to_be_restock = CheckStock(stock);
            foreach (var prod in to_be_restock) {
                Console.WriteLine($"product id = {prod}");
            }
        }

        public static List<int> CheckStock(List<Product> ps)
        {
            
            // var to_be_restock = new List<int>();
            // foreach (var p in ps)
            // {
            //     if (p.Qty <= 10)
            //     {
            //         to_be_restock.Add(p.Id);
            //     }
            // }
            // return to_be_restock;

            /* Linq method */
            List<int> to_be_restock = ps.Where( p => p.Qty <= 10).Select( p => p.Id).ToList();

            return to_be_restock;
            
            /* Linq query way */
            // var query = from p in ps where p.Qty <= 10 select p.Id;
            // var to_be_restock = query.ToList();
            // return to_be_restock;
        
        }
        
    }
}
