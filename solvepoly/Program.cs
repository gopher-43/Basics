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
            //short i = 0;
            double[] k = new double[argv.Length+20];
            bool flag1 = false;//
            int j = 0;
            for (int i=0; i<argv.Length;i++)
            {
                if (argv[i] == "-v")
                {
                    flag1 = true;
                    //coef[j] = Double.Parse(argv[i+1]);
                   
                    continue;
                }
                k[j] = Double.Parse(argv[i]);
                j++;
            }
            
                if (flag1)//(v == "-v") // Verbose
                {
                    Console.WriteLine("***Input * **");
                    Console.WriteLine("Polynom of degree 2 ");
                    Console.WriteLine($"{k[0]}x^2 + ({k[1]})x + ({k[2]}) = 0 ");
                    Console.WriteLine("*** Solution ***");
                    Console.WriteLine("Solving by quadratic formula: ");
                    //discriminant
                    double discr = Math.Pow(k[1], 2) - 4 * k[0] * k[1];

                    Console.WriteLine("Discriminant: ");
                    Console.WriteLine("D = b^2 - 4ac ");
                    Console.WriteLine($"D = ({k[1]})^2-4*({k[0]})*({k[2]})");
                    Console.WriteLine($"D = {discr}");
                    Console.WriteLine("Roots: ");

                    // D > 0 -> real roots
                    if (discr>0)
                    {
                        //roots
                        double x1 = ((-k[1]) + Math.Sqrt(discr)) / (2 * k[0]);
                        double x2 = ((-k[1]) + Math.Sqrt(discr)) / (2 * k[0]);
                        Console.WriteLine("D > 0, must be 2 roots ");
                        Console.WriteLine("x1,2 = (-b±√D)/ (2a) ");
                        Console.WriteLine($"x1 = ({-k[1]} + √{discr}) / (2{k[0]} * {k[2]})");
                        Console.WriteLine($"x1 = ({-k[1]} - √{discr}) / (2{k[0]} * {k[2]})");
                        Console.WriteLine(" **Results * *** ");
                        Console.WriteLine(x1);
                        Console.WriteLine(x2);


                    }
                    // D = 0 -> one root
                    else if (discr==0)
                    {
                        double x1 = (-k[1]) / (2 * k[0]);
                        Console.WriteLine("D = 0, must be 1 root ");
                        Console.WriteLine("x = (-b)/(2a) ");
                        Console.WriteLine($"x1 = ( -({k[1]} ) ) / (2{k[0]}");
                        Console.WriteLine("**Results**");
                        Console.WriteLine(x1);
                        
                    }
                    else// D < 0 -> complex roots
                    {
                        Console.WriteLine(" D < 0, must be 2 complex roots ");
                        Console.WriteLine(" x1,2 = (-b±i√|D|)/(2a) ");
                        Console.WriteLine($"x1 = ({-k[1]} +√|{discr}|)/(2{k[0]}*{k[0]})");
                        Console.WriteLine($"x2 = ({-k[1]} -√|{discr}|)/(2{k[0]}*{k[0]})");
                        Console.WriteLine(" **Results * *** ");
                        Console.WriteLine($"x1 = ({-k[1]} +√|{discr}|)/{2*k[0]}");
                        Console.WriteLine($"x2 = ({-k[1]} -√|{discr}|)/{2*k[0]}");

                        //Console.WriteLine(x1);
                        //Console.WriteLine(x2);
                    }
                    Console.WriteLine("======");
                }
                else
                {

                    //discriminant
                    double discr = Math.Pow(k[1], 2) - 4 * k[0] * k[1];
                    // D > 0 -> real roots
                    if (discr > 0)
                    {
                        //roots
                        double x1 = ((-k[1]) + Math.Sqrt(discr)) / (2 * k[0]);
                        double x2 = ((-k[1]) + Math.Sqrt(discr)) / (2 * k[0]);
                        Console.WriteLine(x1);
                        Console.WriteLine(x2);

                    }
                    // D = 0 -> one root
                    else if (discr == 0)
                    {
                        double x1 = (-k[1]) / (2 * k[0]);
                        Console.WriteLine(x1);

                    }
                    else// D < 0 -> complex roots
                    {
                        Console.WriteLine($"x1 = ({-k[1]}+√|{discr}|)/2 * {k[0]}");
                        Console.WriteLine($"x2 = ({-k[1]}-√|{discr}|)/2 * {k[0]}");
                    }
                }
         
        }
    }
}