using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MonsterClasses
{
    public abstract class Monster
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

        private DispositionType _disposition;

        private string[] _friends = new string[5];

        public string[] Friends
        {
            get { return _friends; }
            set { _friends = value; }
        }

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

        public DispositionType Disposition
        {
            get { return _disposition; }
            set { _disposition = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        public Monster(string name)
        {
            _name = name;
        }

        public Monster(string name, DispositionType disposition)
        {
            _name = name;
            _disposition = disposition;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// display all of the monster's attributes
        /// </summary>
        public abstract void DisplayMonsterInfo();

        public virtual void Greeting()
        {
            Console.WriteLine("Hello friends, my name is {0}", _name);
        }

        #endregion
    }
}
