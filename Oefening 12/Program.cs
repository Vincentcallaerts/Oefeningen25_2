using System;


namespace Oefening_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double mijnDouble;
            Console.Write("Vul één getal in: ");
            mijnDouble = Convert.ToDouble(Console.ReadLine());
            mijnDouble = Math.Pow(mijnDouble, 3);
            Console.WriteLine($"{mijnDouble} tot de 3de macht = {mijnDouble}");
            Console.WriteLine($"De vierkantswortel van {Math.Sqrt(mijnDouble)}");
            
            

            Console.ReadLine();
        }
    }
}
