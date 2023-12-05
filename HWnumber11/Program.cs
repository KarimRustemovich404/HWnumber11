using HWnumber11.Classes;
using System;

namespace HWnumber11
{
    internal class Program
    {
        static void DZ_13_1()
        {
            Building myBuilding = new Building();
            myBuilding.BuildingNumber = 552;
            myBuilding.Height = 100;
            myBuilding.Floors = 23;
            myBuilding.AmountOfApartments = 230;
            myBuilding.AmountOfEntryways = 1;
        }
        static void DZ_13_2()
        {
            new Building { BuildingNumber = 1, Height = 10, Floors = 3, AmountOfApartments = 3, AmountOfEntryways = 1 };
            new Building { BuildingNumber = 2, Height = 14, Floors = 4, AmountOfApartments = 5, AmountOfEntryways = 2 };
            new Building { BuildingNumber = 3, Height = 25, Floors = 6, AmountOfApartments = 10, AmountOfEntryways = 4 };
            new Building { BuildingNumber = 4, Height = 10, Floors = 2, AmountOfApartments = 4, AmountOfEntryways = 5 };
            new Building { BuildingNumber = 5, Height = 228, Floors = 90, AmountOfApartments = 450, AmountOfEntryways = 7 };
            new Building { BuildingNumber = 6, Height = 45, Floors = 20, AmountOfApartments = 40, AmountOfEntryways = 9 };
            new Building { BuildingNumber = 7, Height = 76, Floors = 29, AmountOfApartments = 87, AmountOfEntryways = 1 };
            new Building { BuildingNumber = 8, Height = 89, Floors = 31, AmountOfApartments = 124, AmountOfEntryways = 3 };
            new Building { BuildingNumber = 9, Height = 552, Floors = 150, AmountOfApartments = 1350, AmountOfEntryways = 6 };
            new Building { BuildingNumber = 10, Height = 30, Floors = 6, AmountOfApartments = 12, AmountOfEntryways = 8 };
        }
        static void Main(string[] args)
        {
            DZ_13_1();
            DZ_13_2();
            Console.ReadKey();
        }
    }
}
