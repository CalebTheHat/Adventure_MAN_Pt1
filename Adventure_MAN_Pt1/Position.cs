using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_MAN_Pt1
{
    public class Position// concrete class
    {
        private int x, y;
        
        public int X_coords { get; set; }
        public int Y_coords { get; set; }

        public Position(int x, int y)
        { 
           X_coords = x; Y_coords = y ;
        }


    }
}
