using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // instantiate (create) a new sea monster
            //
            SeaMonster seymore = new SeaMonster();

            //
            // set the sea monsters atttibutes
            //
            seymore.Name = "Seymore the Sea Monster";
            seymore.Sea = "The Baltic Sea";
            seymore.Type = "Big, Slimy Fish";
            seymore.Gills = true;


            //
            // display the monsters' attributes
            //
            seymore.DisplaySeaMonsterInfo();


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
