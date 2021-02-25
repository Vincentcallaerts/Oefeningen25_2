using System;


namespace Oefening14
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1,teken;
            Console.Write("Vul je één getal in negatief of positief: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            teken = Math.Sign(getal1);
            Console.WriteLine($"Het omgekeerde is: {getal1 * teken}");
            Console.ReadLine();

        }
    }
}
