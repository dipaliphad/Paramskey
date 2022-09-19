using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramskey
{
    internal class Program
    {
        static void AcceptNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("-------------");
        }

        static void Main(string[] args)
        {
            AcceptNames("dipu", "rani", "madhu");
            AcceptNames("Rupu", "jay");
            AcceptNames("darshan", "rutu", "ravi", "rechal");
        }
    }
}
