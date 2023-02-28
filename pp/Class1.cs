using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace pp
{
    public class Param
    {
        public int h;
        public Bitmap pic;
    }

    public class ParamWaterDrop : Param
    {
        public ParamWaterDrop()
        {
            h = 50;
            pic = new Bitmap(@"D:\pipipupu\bb.png");
        }
    }
    public class ParamTwoWaterDrop : Param
    {
        public ParamTwoWaterDrop()
        {
            h = 50;
            pic = new Bitmap(@"D:\pipipupu\rr.jpg");
        }
    }
    public class Drop
    {
        public int x, y;
        //------------
        /* public int h;
         public Bitmap pic;*/
        public Param p;
        //------------
        public Drop()
        {
            // h = 10;
            x = 0; y = 0;
        }
        /* public Tree(int x, int y, int ah, Bitmap apic)
         {
             h = ah;
             pic = apic;
             this.x = x;
             this.y = y;
         }*/
        public Drop(int x, int y, Param p)
        {
            this.p = p;
            this.x = x;
            this.y = y;
        }
    }
}
    
