using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    public class WallTile : Tile
    {
        public WallTile(Position pos) : base(pos)
        {
            
        }

        public override char _Display
        {

            get { return '█'; }

        }
    }
}
