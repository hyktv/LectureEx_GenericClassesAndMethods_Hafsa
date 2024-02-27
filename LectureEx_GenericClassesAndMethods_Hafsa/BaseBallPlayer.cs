using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_GenericClassesAndMethods_Hafsa
{
    internal class BaseBallPlayer : Player
    {
        private string _position;

        public BaseBallPlayer(string name, string number, string position) : base(name, number)
        {
            _position = position;
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
