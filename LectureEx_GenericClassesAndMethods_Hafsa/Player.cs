using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_GenericClassesAndMethods_Hafsa
{
    public abstract class Player
    {
        // Fields
        public string _name;
        public string _number;

        // Constructor
        public Player(string name, string number)
        {
            _name = name;
            _number = number;
        }

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
