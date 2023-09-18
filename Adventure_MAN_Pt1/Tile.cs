using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    public abstract class Tile : Position //abstract type
    {

        private Position pos;


        public Tile(Position pos):base(pos.X_coords,pos.Y_coords)
        {
           
            this.pos = pos;

        }

        public int X
        {
            get { return pos.X_coords; }
            set { pos.X_coords = value;}
        }

        public int Y
        {
            get { return pos.Y_coords; }
            set { pos.Y_coords = value;}
        }

        public abstract char _Display { get; } //abstract method
    }
}
