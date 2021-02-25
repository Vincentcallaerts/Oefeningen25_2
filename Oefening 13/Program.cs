using System;


namespace Oefening_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1,getal2,getal3;
            Console.Write("Vul je eerste getal in: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vul je tweede getal in: ");
            getal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vul je derde getal in: ");
            getal3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Min(Math.Max(getal1, getal2), getal3));
            Console.ReadLine();

        }
    }
}
