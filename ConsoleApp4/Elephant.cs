using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Elephant : Figure
    {
       

        public Elephant(string name, string location, string steps)
            : base(name, location, steps) { }

       
        public override string Chess(Figure figure)
        {
            return $"Фигура {Name} находится на {Location} и ходит на {Steps}\n"; 
        }
    }
}
    

