
using System;

namespace Classwork_task_25._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Name = "HP";
            notebook1.BrandName = "__";
            notebook1.Price = 1800;

            Notebook notebook2 = new Notebook();
            notebook2.Name = "ASES";
            notebook2.BrandName = "vivobook15";
            notebook2.Price = 1600;

            Notebook notebook3 = new Notebook();
            notebook3.Name = "Lenovo";
            notebook3.BrandName = "..";
            notebook3.Price = 1900;

            double minPrice = 1000;
            double maxPrice = 3000;

            Notebook[] notebooks = new Notebook[] { notebook1, notebook2, notebook3 };

            foreach (var item in filtersNotebook(notebooks, minPrice, maxPrice))
            {

                Console.WriteLine($" bu markali {item.Name} ve {item.BrandName} bu komputerler bu araliga daxildir:{item.Price}");
            }



        }

        static Notebook[] filtersNotebook(Notebook[] notebooks
            , double minPrice, double maxPrice)

        {
            int count = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price > minPrice && maxPrice > notebooks[i].Price)
                {
                    count++;

                }

            }

            Notebook[] filterPrice = new Notebook[count];
            int j = 0;

            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price > minPrice && notebooks[i].Price < maxPrice)
                {
                    filterPrice[j] = notebooks[i];
                    j++;
                }



            }

            return filterPrice;
        }
    }
}


