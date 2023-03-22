using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Submarine : IAccelerate, IDive
    {
        public int speed;
        public int deep;
        public static int id = 0;
        public int objectId;
        public Submarine()
        {
            speed = 10;
            deep = 100;
            id++;
            objectId = id;
        }
        public void Accelerate(int x)
        {
            speed = x;
        }
        public void Dive(int x)
        {
            deep = x;
        }
        public int GetDeepnes()
        {
            return deep;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public override string ToString()
        {
            return "Submarine #" + objectId;
        }

    }
}
