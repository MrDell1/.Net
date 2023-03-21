using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    internal class Computer
    {
        public static int id = 0;

        public Computer() {
            id++;
        }
        public override string ToString()
        {
            return "Computer #" + id;
        }
    }
}
