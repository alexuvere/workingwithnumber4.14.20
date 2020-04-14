using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( 50 );
            Console.WriteLine( 5/8 );
            Console.WriteLine(5 * 8 );
           //Remainder of divison operation 
            Console.WriteLine( 5 % 2 );
            //rules follow order of operationl use ()
            Console.WriteLine( (4 + 2) * 3);
            Console.WriteLine( 5.0 + 8.1 );
            Console.WriteLine( 5 + 8.1);

            Console.WriteLine( Math.Abs(-40) );
            Console.WriteLine(Math.Abs(3^2));
            Console.WriteLine(Math.Abs(3^14));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.7));







            Console.ReadLine();
        }
    }
}
