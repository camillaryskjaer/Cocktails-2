using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TheBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bartender bartender = new Bartender();

            bartender.GenerateIngredient();
            bartender.GenerateDrink();

            Console.WriteLine("drink done");
            Console.ReadKey();

        }
    }
}
