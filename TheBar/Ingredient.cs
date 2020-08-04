using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TheBar
{
   public class Ingredient
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int IngredientID { get; set; }
                      
        public string Name { get; set; }
          
        public IngredientType Type { get; set; }

        public Ingredient()
        {

        }

        public Ingredient(int ingredientID, string name, IngredientType type)
        {
            IngredientID = ingredientID;
            Name = name;
            Type = type;
        }

    }
}
