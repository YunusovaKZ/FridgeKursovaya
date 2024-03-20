using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeKursovaya.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Desc { get; set; }

    }
}
