using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MonsterClasses
{
    class SpaceMonster
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
        private string _planet;

        private bool _hasDeathRay;
        private int _numberOfWings;

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

        public string Planet
        {
            get { return _planet; }
            set { _planet = value; }
        }

        public bool HasDeathRay
        {
            get { return _hasDeathRay; }
            set { _hasDeathRay = value; }
        }

        public int NumbeOfWings
        {
            get { return _numberOfWings; }
            set { _numberOfWings = value; }
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
        public SpaceMonster()
        {

        }

        public SpaceMonster(string name)
        {
            _name = name;
        }

        public SpaceMonster(string name, DispositionType disposition)
        {
            _name = name;
            _disposition = disposition;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// display all of the monster's attributes
        /// </summary>
        public void DisplaySpaceMonsterInfo()
        {
            Console.WriteLine("Greetings - My Monster's Attributes");
            Console.WriteLine();

            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Type: {0}", _type);
            Console.WriteLine("Planet: {0}", _planet);
            Console.WriteLine("Has Death Ray: {0}", _hasDeathRay);
            Console.WriteLine("Number or Wings: {0}", _numberOfWings);
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
