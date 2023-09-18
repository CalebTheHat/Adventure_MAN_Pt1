using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    public abstract class CharacterTile : Tile //abstract class
    {
        public int _hp, _maxHP, _ap;
        public Tile[] _charVision;
        public bool isDead { get; set; }

        public CharacterTile(Position pos, int _hp, int _ap) : base(pos)
        {
            this._hp = _hp;
            this._maxHP = _hp;
            this._ap = _ap;
            _charVision = new Tile[4];
        }

        public Tile[,] _arrtiles
        {
            get { return _arrtiles; }
        }

        public void UpdateVision(Level level)
        {
            _charVision[0] = _arrtiles[X_coords, Y_coords - 1];
            _charVision[1] = _arrtiles[X_coords + 1, Y_coords];
            _charVision[2] = _arrtiles[X_coords, Y_coords + 1];
            _charVision[3] = _arrtiles[X_coords - 1, Y_coords];

        }

        public void TakeDamage(int _ouch)
        {
            _hp = _hp - _ouch;
            if (_hp < 0)
            {
                _hp = 0;
                isDead = true;
            }
        }

        public void Attack(Tile target)
        {
            int damage;
            damage = _ap;
            TakeDamage(damage);
        }

}
}
