using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Figure
    {
            public string Name { get; private set; }
            public string Location  { get; private set; }
            public string Steps { get; private set; }

            public Figure(string name, string  location)
            {
                Name = name;
                Location = location;
            }
            public Figure(string name, string location, string steps) : this(name, location)
            {
                if (steps == "")
                    Steps = "";
                else
                    Steps = steps;
            }

            public virtual string Chess(Figure figure)
            {
                return $"Фигура {Name} ходит на {Steps }\n";
            }
            public virtual string Info()
            {
                return $"Фигура: {Name}\nНаходится на: {Location}\nХодит на: {Steps}\n";
            }
    }
}

