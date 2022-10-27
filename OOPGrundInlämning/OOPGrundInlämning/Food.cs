using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGrundInlämning
{
    internal class Food : Item, iDBU
    {

        //Matklassen har en egen smak string tillsamman med drickaklassen.
        public string taste;

        //En lista för mat.
        public static List<Food> foods = new List<Food>();

        //Konstruktor
        public Food(string name, int price, string description, string taste) : base(name, price, description)
        {
            this.taste = taste;
            this.name = name;
            this.price = price;
            this.description = description;
        }

        //Metoder som ärvs från interfacet
        public void Description()
        {
            Console.WriteLine($"{description}. Tastes like {taste}.");
        }

        public void Buy()
        {
            Console.WriteLine($"You bought the {name}.");
        }

        public void Use()
        {
            Console.WriteLine($"You are now eating the {name}.");
        }
    }
}
