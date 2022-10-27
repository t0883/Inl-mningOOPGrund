using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGrundInlämning
{
    internal class Clothes : Item, iDBU
    {
        //Lokal variabel för kläder
        public string color;

        //Lista som kan fyllas på och objekt kan tas bort från listan
        public static List<Clothes> garnments = new List<Clothes>();

        //Konstruktor
        public Clothes(string name, int price, string description, string color) : base(name, price, description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.color = color;
        }

        //Metoder
        public void Description()
        {
            Console.WriteLine($"{description} and has the color {color}");
        }

        public void Buy()
        {
            Console.WriteLine($"You bought the {name}.");
        }

        public void Use()
        {
            Console.WriteLine($"You are using the {name}.");
        }

    }
}
