using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction u1 = new Fraction(4, 2);
            Fraction u2 = new Fraction(3, 3);

            Console.WriteLine("Fracture 1:"+u1.ToString());
            Console.WriteLine("Fracture 2:" + u2.ToString());

            Console.WriteLine(u1 * u2);
            Console.WriteLine(u1 - u2);
            Console.WriteLine(u1 + u2);
            Console.WriteLine(u1 / u2);
        }
    }
}
