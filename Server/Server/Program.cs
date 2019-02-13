using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDP;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSocket c = new UDPSocket();
            c.Client("127.0.0.1", 9050);

            //Add mode sender methods here

            //Keeps the console app open forever
            Console.Read();
        }
    }
}
