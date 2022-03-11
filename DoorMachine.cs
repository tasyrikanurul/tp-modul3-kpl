using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302201131
{
    internal class DoorMachine
    {
        enum State {Terkunci, Terbuka};
        public static void Main()
        {
            State state = State.Terkunci;
            string[] kondisipintu = { "Terkunci", "Terbuka" };
            while (state != State.Terkunci) ;
            {
                Console.Write("Pintu tidak terkunci");

            }
            while (state != State.Terbuka) ;
            {
                Console.Write("Pintu terkunci");
            }
        }
    }
}
