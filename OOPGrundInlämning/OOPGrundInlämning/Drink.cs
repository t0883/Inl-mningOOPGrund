using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGrundInlämning
{
    internal class Drink : Item , iDBU
    {
        //Den lokala variablen för smak :)
        public string taste;

        //Lista för dricka
        public static List<Drink> drinks = new List<Drink>();

        //Konstruktor
        public Drink(string name, int price, string description,string taste) : base (name, price, description)
        {
            this.taste = taste;
            this.name = name;
            this.price = price;
            this.description = description;
        }

        //Metoder
        public void Description()
        {
            Console.WriteLine($"The drink {taste} like. {description}.");
        }

        public void Buy()
        {
            Console.WriteLine($"You bought the {name}.");
        }

        public void Use()
        {
            Console.WriteLine($"You drank the {name}.");
        }

    }
}
