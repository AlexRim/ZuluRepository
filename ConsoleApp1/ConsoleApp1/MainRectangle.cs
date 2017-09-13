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

        public double RectangleHeight => Sqrt(Pow(LeftTop.Y - LeftBottom.Y, 2) + Pow(LeftTop.X - LeftBottom.X, 2));
        public double RectangleWidth => Sqrt(Pow(LeftBottom.X - RightBottom.X, 2) + Pow(LeftBottom.Y - RightBottom.Y,2));

        internal MyPoint LeftTop { get => leftTop; set => leftTop = value; }
        internal MyPoint LeftBottom { get => leftBottom; set => leftBottom = value; }
        internal MyPoint RightTop { get => rightTop; set => rightTop = value; }
        internal MyPoint RightBottom { get => rightBottom; set => rightBottom = value; }

        public MainRectangle(MyPoint lt, MyPoint lb, MyPoint rt, MyPoint rb)
        {
            this.LeftTop = lt;
            this.RightBottom = rb;
            this.LeftBottom = lb;
            this.RightTop = rt;
        }

        public override string ToString()
        {
            return LeftBottom.ToString() + " " + LeftTop.ToString()+ " "+RightBottom.ToString()+" "+RightTop.ToString() ;
        }



    }
}
