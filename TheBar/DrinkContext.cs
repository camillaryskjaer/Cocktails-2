using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Text;

namespace TheBar
{
    public class DrinkContext : DbContext
    {
        public DrinkContext() : base("MyBar")
        {

            Database.SetInitializer<DrinkContext>(new CreateDatabaseIfNotExists<DrinkContext>());

            //Database.SetInitializer<DrinkContext>(new DropCreateDatabaseIfModelChanges<DrinkContext>());
            //Database.SetInitializer<DrinkContext>(new DropCreateDatabaseAlways<DrinkContext>());
            //Database.SetInitializer<DrinkContext>(new DrinkContext());
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Mixer> Mixers { get; set; }
        public DbSet<Drink> Drinks { get; set; }
    }
}
