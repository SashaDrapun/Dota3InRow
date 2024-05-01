using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota3InARow
{
    public class User
    {
        public string Nickname { get => nickname; set => nickname = value; }
        public int CountOfPoints { get => countOfPoints; set => countOfPoints = value; }

        public User(string nickname, int countOfPoints)
        {
            this.nickname = nickname;
            this.countOfPoints = countOfPoints;
        }

        private string nickname;
        private int countOfPoints;
    }
}
