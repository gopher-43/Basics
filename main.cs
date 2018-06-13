using System;

class Program
{
    static void Main(string[] argv)
    {
        foreach (string v in argv)
        {
            if (v != "-v") // Verbose
            {
                double k1 = argv[0];
                double k2 = argv[1];
                double k3 = argv[2];
                Console.WriteLine(“*** Input ***”);
                Console.WriteLine(“ Polynom of degree 2 ”);
                Console.WriteLine(“ x^2-x-1=0 ”);
                Console.WriteLine(“ *** Solution *** ”);
                Console.WriteLine(“ Solving by quadratic formula: ”);
                Console.WriteLine(“ Discriminant: ”);
                Console.WriteLine(“ D = b^2-4ac ”);
                Console.WriteLine(" D = (" +  ")^2-4*(1)*(-1) = 5 ");
                Console.WriteLine(“  ”);
                Console.WriteLine(“  ”);
                Console.WriteLine(“  ”);
                Console.WriteLine(“  ”);

                Console.WriteLine(“  ”);
                
            }
            else
            {
                double k1 = argv[0];
                double k2 = argv[1];
                double k3 = argv[2];
            }
        }
    }
}

/*
Verbose


> solvepoly -v 1 -1 -1
*** Input ***
Polynom of degree 2
x^2-x-1=0
*** Solution ***
Solving by quadratic formula:
Discriminant:
    D = b^2-4ac
    D = (-1)^2-4*(1)*(-1) = 5
Roots:
    D > 0, must be 2 roots
    x1,2 = (-b±√D)/(2a)
    x1 = (1+√5)/(2*1) = 1.6180
    x2 = (1-√5)/(2*1) = -0.6180
*** Results ***
1.6180
-0.6180



 */