using System;


namespace Oefening_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            Console.Write("Vul je één getal in negatief of positief: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De absolute waarde is: {Math.Abs(getal1)}");
            
          
            
            Console.ReadLine();
        }
    }
}
