using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp1
{
    class MainRectangle
    {
        private MyPoint leftTop;

        private MyPoint leftBottom;

        private MyPoint rightTop;

        private MyPoint rightBottom;

        public double RectangleHeight => Sqrt(Pow(leftTop.Y - leftBottom.Y, 2) + Pow(leftTop.X - leftBottom.X, 2));
        public double RectangleWidth => Sqrt(Pow(leftBottom.X - rightBottom.X, 2) + Pow(leftBottom.Y - rightBottom.Y,2));
            


        public MainRectangle(MyPoint lt, MyPoint lb, MyPoint rt, MyPoint rb)
        {
            this.leftTop = lt;
            this.rightBottom = rb;
            this.leftBottom = lb;
            this.rightTop = rt;
        }

        public override string ToString()
        {
            return leftBottom.ToString() + " " + leftTop.ToString()+ " "+rightBottom.ToString()+" "+rightTop.ToString() ;
        }



    }
}
