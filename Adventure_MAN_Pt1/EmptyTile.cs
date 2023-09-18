using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    public class EmptyTile : Tile //concrete type
    {
        public EmptyTile(Position pos): base(pos)
        {
        
        }

        public override char _Display
        { 
        
            get { return '.'; }

        }
    }
}
