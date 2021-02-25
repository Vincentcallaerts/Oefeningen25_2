using System;

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
