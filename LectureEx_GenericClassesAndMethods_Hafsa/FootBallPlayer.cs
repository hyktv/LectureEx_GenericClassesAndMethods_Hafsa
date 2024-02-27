using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_GenericClassesAndMethods_Hafsa
{
    public class FootBallPlayer : Player
    {
        public int _yardsRun;

        public FootBallPlayer(string name, string number, int yardsRun) : base(name, number)
        {
            _yardsRun = yardsRun;
        }

        public int YardsRun
        {
            get { return _yardsRun; }
            set { _yardsRun = value; }
        }

    }
}
