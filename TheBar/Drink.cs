using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TheBar
{
    public class Drink
    {

        [Key]
        public int DrinkID { get; set; }

        [Column("Name", TypeName = "VarChar")]
        [MaxLength(32)]
        public string Name { get; set; }
                        
        public Drink(int drinkID, string name, List<Mixer> mixer)
        {
            DrinkID = drinkID;
            Name = name;
            Mixers = mixer;
        }

        public List<Mixer> Mixers { get; set; } = new List<Mixer>();

        public Drink()
        {

        }

        public Drink(string name, List<Mixer> mixer)
        {
            Name = name;
            Mixers = mixer;
        }
    }
}
