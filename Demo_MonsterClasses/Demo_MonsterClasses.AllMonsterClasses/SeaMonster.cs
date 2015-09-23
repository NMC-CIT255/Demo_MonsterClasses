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

        private bool _hasGills;
        private int _numberOfLegs;

        private DispositionType _disposition;

        private string[] _friends = new string[5];

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

        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
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

        public string[] Friends
        {
            get { return _friends; }
            set { _friends = value; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// constructor
        /// </summary>
        public SeaMonster()
        {

        }

        public SeaMonster(string name)
        {
            _name = name;
        }

        public SeaMonster(string name, DispositionType disposition)
        {
            _name = name;
            _disposition = disposition;
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
            Console.WriteLine("Has Gills: {0}", _hasGills);
            Console.WriteLine("Number or Legs: {0}", _numberOfLegs);
            Console.WriteLine("Disposition: {0}", Disposition);

            Console.WriteLine();
            Console.WriteLine("Friends");
            foreach (var friend in _friends)
            {
                if (friend != null)
                {
                Console.WriteLine("Friend: {0}", friend);                    
                }
            }
        }

        #endregion
    }
}
