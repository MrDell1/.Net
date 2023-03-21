using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Plane:IAccelerate,IRise
    {
        public int speed;
        public int height;
        public static int id = 0;

        public Plane()
        {
            speed = 10;
            height = 100;
            id++;
        }
        public void Accelerate(int x)
        {
            speed = x;
        }
        public void Rise(int x)
        {
            height = x;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public int GetAltitude()
        {
            return height;
        }
        public override string ToString()
        {
            return "Plane #" + id;
        }
    }
}
