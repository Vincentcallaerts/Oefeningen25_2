using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening10
{
    class Program
    {
        static void Main(string[] args)
        {
            char mijnLetter,volgendeLetter;
            Console.Write("Vul één letter in: ");
            mijnLetter = Convert.ToChar(Console.ReadLine());
            if (mijnLetter.Equals('Z') || mijnLetter.Equals('z'))
            {
                Console.WriteLine("Slimme niet de laaste letter pakken");
            }
            else
            {
                
                volgendeLetter = Convert.ToChar(mijnLetter + 1);
                Console.WriteLine(volgendeLetter);
            }
            
            Console.ReadLine();
        }
    }
}
