using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solvepoly
{
    class Program
    {
        static void Main(string[] argv)
        {
            short i = 0;
            for (short j,argv[j]<)
            foreach (string v in argv)
            {
                if (v = "-v") // Verbose
                {
                    
                    double k1 = double.Parse(argv[0]);
                    double k2 = double.Parse(argv[1]);
                    double k3 = double.Parse(argv[2]);
                    Console.WriteLine("***Input * **");
                    Console.WriteLine(" Polynom of degree 2 ");
                    Console.WriteLine(" x ^ 2 - x - 1 = 0 ");
                    Console.WriteLine(" ***Solution * ** ");
                    Console.WriteLine(" Solving by quadratic formula: ");
                    Console.WriteLine(" Discriminant: ");
                    Console.WriteLine(" D = b ^ 2 - 4ac ");
                    Console.WriteLine(" D = (" + k2 + ")^2-4*(" + k1 + ")*(" + k3 +")" + ")");
                    Console.WriteLine(" Roots: ");
                    //discriminant
                    double discr = Math.Pow(k2, 2)-4*k1*k2;
                    

                    // D > 0 -> real roots
                    if (discr>0)
                    {
                        //roots
                        double x1 = ((-k2) + Math.Sqrt(discr)) / (2 * k1);
                        double x2 = ((-k2) + Math.Sqrt(discr)) / (2 * k1);
                        Console.WriteLine(" D > 0, must be 2 roots ");
                        Console.WriteLine(" x1,2 = (-b±√D)/ (2a) ");
                        Console.WriteLine(" x1 = ("+ (-k2) + "+ √" + discr + ") / (2" + k1 + " * " + k1 + ")");
                        Console.WriteLine(" x2 = ("+ (-k2) + "- √" + discr + ") / (2" + k1 + " * " + k1 + ")");
                        Console.WriteLine(" **Results * *** ");
                        Console.WriteLine(x1);
                        Console.WriteLine(x2);


                    }
                    // D = 0 -> one root
                    else if (discr==0)
                    {
                        double x1 = (-k2) / (2 * k1);
                        Console.WriteLine(" D = 0, must be 1 root ");
                        Console.WriteLine(" x = (-b)/(2a) ");
                        Console.WriteLine(" x1 = ( -(" + (k2) + ") ) / (2" + k1 + " * " + k1 + ")");
                        Console.WriteLine(" **Results * *** ");
                        Console.WriteLine(x1);
                        
                    }
                    else// D < 0 -> complex roots
                    {
                        Console.WriteLine(" D < 0, must be 2 complex roots ");
                        Console.WriteLine(" x1,2 = (-b±i√|D|)/ (2a) ");
                        Console.WriteLine(" x1 = (" + (-k2) + "+ √|" + discr + "|) / (2" + k1 + " * " + k1 + ")");
                        Console.WriteLine(" x2 = (" + (-k2) + "- √|" + discr + "|) / (2" + k1 + " * " + k1 + ")");
                        Console.WriteLine(" **Results * *** ");
                        Console.WriteLine(" x1 = (" + (-k2) + "+√|" + discr + "|)/" + 2*k1 + "");
                        Console.WriteLine(" x2 = (" + (-k2) + "-√|" + discr + "|)/" + 2*k1 + "");

                        //Console.WriteLine(x1);
                        //Console.WriteLine(x2);
                    }
                    Console.WriteLine("  ");
                    Console.WriteLine("  ");
                    Console.WriteLine("  ");

                    /*
                     */

                    break;//exit foreach
                }
                else
                {

                    double k1 = double.Parse(argv[0]);
                    double k2 = double.Parse(argv[1]);
                    double k3 = double.Parse(argv[3]);
                    //discriminant
                    double discr = Math.Pow(k2, 2) - 4 * k1 * k2;
                    // D > 0 -> real roots
                    if (discr > 0)
                    {
                        //roots
                        double x1 = ((-k2) + Math.Sqrt(discr)) / (2 * k1);
                        double x2 = ((-k2) + Math.Sqrt(discr)) / (2 * k1);
                        Console.WriteLine(x1);
                        Console.WriteLine(x2);

                    }
                    // D = 0 -> one root
                    else if (discr == 0)
                    {
                        double x1 = (-k2) / (2 * k1);
                        Console.WriteLine(x1);

                    }
                    else// D < 0 -> complex roots
                    {
                        Console.WriteLine(" x1 = (" + (-k2) + "+√|" + discr + "|)/" + 2 * k1 + "");
                        Console.WriteLine(" x2 = (" + (-k2) + "-√|" + discr + "|)/" + 2 * k1 + "");
                    }

                    break;//exit foreach
                }
            i++;
            }
            Console.ReadKey();
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
