using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    public class Level
    {
        private int _width;
        private int _hight;
        private  Tile[,] _arrtiles;
        public HeroTile HeroTile { get; }



        public enum Direction
        {
            Up, Right, Down, Left, None
        }

        public enum _TileType
        {
            Empty,
            Wall,
            Hero
        }
        public Level(int _width, int _height, HeroTile heroTile = null)
        { 
           this._hight = _height;
           this._width = _width;
            Position newPos = GetRandomEmptyPosition();
           if (heroTile == null) { heroTile = (HeroTile)_CreateTile(_TileType.Hero, newPos); }
           else { heroTile.X = newPos.X_coords; heroTile.Y = newPos.Y_coords; }
           this.HeroTile = heroTile;
           HeroTile.UpdateVision(this);
           _arrtiles = new Tile[_width, _height];
           _tileInitailized();
        }

        public int Width
        { get { return _width; } }

        public int Height { get { return _hight; } }

        private void _tileInitailized()
        {
            for(int x = 0; x < _width; x++)
            {
                for(int y = 0; y < _hight; y++)
                {
                    if (x == 0 || x == _width -1 || y == 0 || y == _hight -1)
                    {
                        _arrtiles[x, y] = _CreateTile(_TileType.Wall, new Position(_width, _hight));
                    }
                    else
                    {
                        _arrtiles[x, y] = _CreateTile(_TileType.Empty, new Position(_width, _hight));                      
                    }                  
                }
            }
           GetRandomEmptyPosition();
            
        }

        private Tile _CreateTile(_TileType _type, Position _pos)
        {
            Tile _tile;

            switch (_type)
            {          
                case _TileType.Empty:
                    _tile = new EmptyTile(_pos);
                    break;
                case _TileType.Wall:
                    _tile = new WallTile(_pos);
                    break;
                case _TileType.Hero:
                    _tile = new HeroTile(_pos, 40, 5);
                    break;
                default:
                    _tile = null;
                    break;
            }

            if (_tile == null)
            {
                _arrtiles[_pos.X_coords, _pos.Y_coords] = _tile;
            }

            return _tile;
        }

        public override string ToString()
        {

            StringBuilder lvlString = new StringBuilder();

            for(int y = 0; y < _hight; y++)
            {
               for(int x = 0; x < _width; x++)
                {
                    lvlString.Append(_arrtiles[x, y]._Display);
                }
                lvlString.AppendLine();
            }

            return lvlString.ToString();
        }

        private Position GetRandomEmptyPosition()
        {
            bool rTile = false;
            Random random = new Random();
            Position ranPos = null;
            int xVal = 0, yVal = 0;

            while (rTile == false)
            {
                xVal = random.Next(0, 12);
                yVal = random.Next(0, 7);

                if (_arrtiles[xVal, yVal].Equals(_TileType.Empty))
                {
                    _arrtiles[xVal, yVal] = _CreateTile(_TileType.Hero, new Position(_width, _hight));
                    ranPos = new Position(_width, _hight);
                    rTile = true;
                    
                    break;
                }
            }
            return ranPos;
        }

        public void SwopTiles(Tile first, Tile second)
        {
            Tile temp;

            temp = first;
            first = second;
            second = temp;
        }
    }
}
