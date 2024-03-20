using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FridgeKursovaya.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Name {get; set;}
        public int Callor {  get; set;}
        public string dateTime { get; set;}

    }
}
