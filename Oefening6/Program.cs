using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            string mijnString = "dit is een mooie string uwussssssss";
            Console.WriteLine(mijnString.Substring(0,1).ToUpper() + mijnString.Substring(1,mijnString.Length-1));
            
            Console.ReadLine();
        }
    }
}
