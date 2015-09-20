using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MonsterClasses
{
    class SeaMonster
    {
        #region FIELDS

        private string _name;
        private string _type;
        private string _sea;

        private bool _gills;
        private int _numberOfLegs;      

        


        

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


        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS



        #endregion
    }
}
