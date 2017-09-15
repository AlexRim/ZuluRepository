using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lt = new MyPoint(0, 10);
            var lb = new MyPoint(0, 0);
            var rt = new MyPoint(10,10);
            var rb = new MyPoint(10, 0);

            var rect = new MainRectangle(lt, lb, rt, rb);

            var findPoints = new FindPoints(rect, 50);
            var list = findPoints.PointsList;
            int z = 0;
            foreach(var i in list)
            {
                z++;
                Console.WriteLine(z+") "+ i.ToString());
            }

            Console.ReadKey();
        }
    }
}
