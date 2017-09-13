using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyPoint
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

         public MyPoint(){  }

        public MyPoint(double x, double y)
        {
            this.x = x;
            this.y = y;

        }

        public override string ToString()
        {
            return "X="+X+" "+"Y="+Y;
        }

    }
}
