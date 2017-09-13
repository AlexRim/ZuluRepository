using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp1
{
    class FindPoints
    {
        List<MyPoint> pointsList;

        private int rectCount;

        private double delta;

        public double Delta
        {
            get;
        }

        public List<MyPoint> PointsList { get => pointsList; }

        public FindPoints(MainRectangle rect, int rectCount)
        {
            this.rectCount = rectCount;
            delta = CalcDelta(rect);
            FindAllPoints(rect);

        }

        private double CalcDelta(MainRectangle rect) => Sqrt(rect.RectangleHeight * rect.RectangleWidth / rectCount);


        private void FindAllPoints(MainRectangle rect)
        {
            pointsList = new List<MyPoint>();

            int firstForCount = (int)(rect.RectangleWidth / delta);
            int secondForCount= (int)(rect.RectangleHeight / delta);

            double x = rect.LeftBottom.X;
            double y = rect.LeftBottom.Y;
         

            for (int i = 0; i < secondForCount; i++)
            {
                for (int j = 0; j < firstForCount; j++)
                {
                    this.pointsList.Add(new MyPoint(x, y));
                    x += delta;
                }
                y += delta;
            }
      
        }
       



    }
}
