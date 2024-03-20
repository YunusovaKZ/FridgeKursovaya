using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeKursovaya.Models
{
    public class ProductDB
    {
        private readonly SQLiteConnection conn;

        public ProductDB(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Product>();
        }

        public List<Product> GetProduct()
        {
            return conn.Table<Product>().ToList();
        }

        public int SaveProduct(Product product)
        {
            if (product.Id != 0)
            {
                return conn.Update(product);
            }
            else
            {
                return conn.Insert(product);
            }

        }

    }
}
