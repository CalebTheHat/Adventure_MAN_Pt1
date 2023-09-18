using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    internal class GameEngine
    {

        private Level _currentlvl;
        private int _numlvl;
        private Random _ranroll;
        private const int MIN_SIZE = 10;
        private const int MAX_SIZE = 20;
        private Position pos;


        public GameEngine(int _numlvl) 
        {

            int _lvlHight, _lvlWidth;

            this._numlvl = _numlvl;
            _ranroll = new Random();

            _lvlHight = _ranroll.Next(MIN_SIZE, MAX_SIZE + 1);
            _lvlWidth = _ranroll.Next(MIN_SIZE + 1, MAX_SIZE);

            _currentlvl = new Level(_lvlWidth,_lvlHight);
        
        }

        public override string ToString()
        {
            return _currentlvl.ToString();
        }

        private void MoveHero(Enum Direction)
        {

        }


    }
}
