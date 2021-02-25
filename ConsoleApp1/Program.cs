using System;


namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, temp;
            getal1 = 5;
            getal2 = 85;
            Console.WriteLine(getal1 + " " + getal2);
            temp = getal1;
            getal1 = getal2;
            getal2 = temp;
            
            Console.WriteLine(getal1 + " " + getal2);

            Console.ReadLine();

        }
    }
}
