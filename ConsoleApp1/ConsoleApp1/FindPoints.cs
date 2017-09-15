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
         

            for (int i = 0; i <= secondForCount; i++)
            {
                x = rect.LeftBottom.X;
                for (int j = 0; j <=firstForCount; j++)
                {
                    this.pointsList.Add(new MyPoint(x, y));
                    x += delta;
                }
                y += delta;
            }
      
        }

        public List<MainRectangle> GetRectangles(List<MyPoint> listPoint)
        {
            var list = new List<MainRectangle>();
            for (int i = 0; i < listPoint.Count; i++)
            {
                var lb = pointsList[i];
                var lt = new MyPoint(pointsList[i].X, pointsList[i].Y + delta);
                var rb = new MyPoint(pointsList[i].X + delta, pointsList[i].Y);
                var rt = new MyPoint(pointsList[i].X + delta, pointsList[i].Y + delta);
                list.Add(new MainRectangle(lt, lb, rt, rb));
            }
            return list;
        }
       



    }
}
