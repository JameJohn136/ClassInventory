using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
    internal class Player
    {
        public string name, team, position;
        public int age;

        public Player(int _age, string _name, string _team, string _position)
        {
            age = _age;
            name = _name;
            team = _team;
            position = _position;
        }


    }
}
