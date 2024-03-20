using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FridgeKursovaya.Models
{
    public class BD
    {

        private readonly SQLiteConnection conn;

        public BD(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Recipe>();
        }

        public List<Recipe> GetRecipe()
        {
            return conn.Table<Recipe>().ToList();
        }

        public int SaveRecept(Recipe recipe)
        {
            if (recipe.ID != 0)
            {
                return conn.Update(recipe);
            }
            else
            {
                return conn.Insert(recipe);
            }
            
        }

        public int DeleteRecipe(Recipe recipe) 
        { 
            return conn.Delete(recipe);
        }

      
    }
}
