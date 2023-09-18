using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    public class HeroTile : CharacterTile
    {
        public HeroTile(Position pos, int _hp, int _ap) : base(pos, _hp, _ap)
        {
            this._hp = 40;
            _maxHP = this._hp;
            this._ap = 5;
        }

        public override char _Display
        {
            get { return '▼'; }
        }
    }
}
