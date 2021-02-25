using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening7
{
    class Program
    {
        static void Main(string[] args)
        {
            string mijnString;
            Console.Write("Vul een zin in: ");
            mijnString = Console.ReadLine();
            Console.WriteLine(mijnString.Replace(" ", "_"));
            Console.ReadLine();
            
        }
    }
}
