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
            // instantiate (create) a sea monster and call a method 
            // to set the attributes
            //
            SeaMonster seymore = new SeaMonster();
            SetSeaMonsterAttributes(seymore);

            //
            // instantiate (create) a sea monster and use an
            // object intializer to set the attributes
            //
            SeaMonster suzy = new SeaMonster
            {
                Name = "Suzy the Sea Monster",
                Type = "Big, Slimy Fish",
                Sea = "The Baltic Sea",
                HasGills = true,
                NumbeOfLegs = 8
            };

            //
            // instantiate (create) a space monster and use an
            // object intializer to set the attributes
            //
            SpaceMonster sid = new SpaceMonster
            {
                Name = "Sid the Space Monster",
                Type = "Billowng Floater",
                Planet = "The Gasous Giant Emcore",
                HasDeathRay = false,
                NumbeOfWings = 2
            };

            //
            // display the monsters' attributes
            //
            seymore.DisplaySeaMonsterInfo();
            Console.WriteLine();
            suzy.DisplaySeaMonsterInfo();
            Console.WriteLine();
            sid.DisplaySpaceMonsterInfo();

            //
            // pause the console window and wait for a keystroke
            //
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        /// <summary>
        /// set the monster attributes using a method
        /// </summary>
        /// <param name="monster"></param>
        private static void SetSeaMonsterAttributes(SeaMonster monster)
        {
            //
            // set the sea monsters atttibutes
            //
            monster.Name = "Seymore the Sea Monster";
            monster.Type = "Big, Slimy Fish";
            monster.Sea = "The Baltic Sea";
            monster.HasGills = true;
            monster.NumbeOfLegs = 7;
            monster.Friends[0] = "Suzy";
        }
    }
}
