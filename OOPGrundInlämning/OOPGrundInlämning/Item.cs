using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGrundInlämning
{
    internal class Item
    {

        //Alla saker i maksinen har ett namn
        public string name;
        //ett pris
        public int price;
        //och en beskrivning.
        public string description;


        //Konstruktor
        public Item(string name, int price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

    }
}
