using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = GetFigure(SpetialityType.Queen, "Королева", "E2", "две клетки вперёд");
            string q = figure.Chess(figure);
            string q1 = figure.Info();
            Console.WriteLine(q);
            Console.WriteLine(q1);
            Figure figure1 = GetFigure(SpetialityType.Elephant, "Слон", "А3", "три клетки влево по диагонали");
            string e = figure1.Chess(figure1);
            string e1 = figure1.Info();
            Console.WriteLine(e);
            Console.WriteLine(e1);
            Console.ReadKey();
        }

        private static Figure GetFigure(SpetialityType spetialityType, string name, string location, string steps)
        {
            switch (spetialityType)
            {
                case SpetialityType.Queen:
                    return new Queen(name, location, steps);

                case SpetialityType.Elephant:
                    return new Elephant(name, location, steps);

                default: throw new Exception("Неизвестная фигура");

            }

           

        }
        public enum SpetialityType
        {
            Queen = 1,
            Elephant = 2,


        }
    }
}
