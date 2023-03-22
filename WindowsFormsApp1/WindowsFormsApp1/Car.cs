using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Car:IAccelerate
    {
        public int speed;
        public static int id = 0;
        public int objectId;

        public Car()
        {
            speed = 10;
            id++;
            objectId = id;
        }
        public void Accelerate(int x)
        {
            speed = x;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public override string ToString()
        {
            return "Car #" + objectId;
        }
    }
}
