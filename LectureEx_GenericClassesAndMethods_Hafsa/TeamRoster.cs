using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_GenericClassesAndMethods_Hafsa
{
    internal class TeamRoster<T> where T : Player
    {
        private List<T> _roster;

        public TeamRoster()
        {
            _roster = new List<T>();
        }

        public List<T> Roster
        {
            get { return _roster; }
        }

        public void AddPlayer(T player)
        {
            _roster.Add(player);
        }

    }
}
