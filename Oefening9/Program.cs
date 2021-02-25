using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening9
{
    class Program
    {
        static void Main(string[] args)
        {

            string mijnString = "dit is een mooie string uwussssssss";
            for (int i = 0; i < mijnString.Length; i++)
            {
                if (mijnString.Substring(i,1).Equals("e"))
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.ReadLine();

        }
    }
}
