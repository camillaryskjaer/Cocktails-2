using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TheBar
{
    public class Mixer
    {
        [Key]
        public int MixerID { get; set; }
               
        public int Amount { get; set; }
               
        public string Unit { get; set; }

                     
        public Ingredient Ingredient { get; set; }

        public Mixer()
        {

        }

        public Mixer(int mixerID, Ingredient ingredient, int amount, string unit)
        {
            MixerID = mixerID;
            Ingredient = ingredient;
            Amount = amount;
            Unit = unit;
        }
    }
}
