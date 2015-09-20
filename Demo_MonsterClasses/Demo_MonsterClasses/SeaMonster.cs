using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MonsterClasses
{
    class SeaMonster
    {

        #region ENUMERABLES

        public enum DispositionType
        {
            Happy,
            Sad,
            Nice,
            Mean,
            Crazy
        }

        #endregion

        #region FIELDS

        private string _name;
        private string _type;
        private string _sea;

        private bool _gills;
        private int _numberOfLegs;

        private DispositionType _disposition;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Sea
        {
            get { return _sea; }
            set { _sea = value; }
        }

        public bool Gills
        {
            get { return _gills; }
            set { _gills = value; }
        }

        public int NumbeOfLegs
        {
            get { return _numberOfLegs; }
            set { _numberOfLegs = value; }
        }

        public DispositionType Disposition
        {
            get { return _disposition; }
            set { _disposition = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public SeaMonster()
        {

        }



        #endregion

        #region METHODS

        /// <summary>
        /// display all of the monster's attributes
        /// </summary>
        public void DisplaySeaMonsterInfo()
        {
            Console.WriteLine("Greetings - My Monster's Attributes");
            Console.WriteLine();
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Type: {0}", _type);
            Console.WriteLine("Sea: {0}", _sea);
            Console.WriteLine("Has Gills: {0}", _gills);
            Console.WriteLine("Number or Legs: {0}", _numberOfLegs);
            Console.WriteLine("Disposition: {0}", Disposition);
        }

        #endregion
    }
}
