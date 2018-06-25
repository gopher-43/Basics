using System;

namespace solvepoly
{
    class Program
    {
        static void Main(string[] argv)
        {
            coeffCalculate(argv);

        }
        static double[] coeffCalculate(double[] coefficentArray)
        {
            double[] k = new double[coefficentArray.Length + 2];
            bool isVerbose = false;
            int j = 0;
            int cntCoefs = 0;//число коффициентов
            bool isOutput = false;
            bool isBigOutput = false;
            string fileName = "";
            double[] roots = new double[2];

            for (int i = 0; i < coefficentArray.Length; i++)
            {
                if (coefficentArray[i] == "-v")
                {
                    isVerbose = true;
                    continue;
                }
                else if (coefficentArray[i] == "-o")
                {
                    isOutput = true;
                    i++;//слудующий аргумент - имя файла
                    fileName = coefficentArray[i];
                    continue;
                }
                else if (coefficentArray[i] == "-O")
                {
                    isBigOutput = true;
                    i++;//слудующий аргумент - имя файла
                    fileName = coefficentArray[i];
                    continue;
                }
                k[j] = Double.Parse(coefficentArray[i]);
                j++;
                cntCoefs = j;
            }
            try
            {
                switch (cntCoefs)
                {
                    case 0:
                        return k;
                        break;

                    case 1:
                        double x1 = -k[1] / k[0];
                        return x1;
                        break;

                    case 2:
                        //три коеффициета - квадратное ур-е
                        //discriminant
                        double discr = Math.Pow(k[1], 2) - 4 * k[0] * k[1];
                        // D > 0 -> real roots
                        if (discr > 0)
                        {
                            //roots
                            double x1 = ((-k[1]) + Math.Sqrt(discr)) / (2 * k[0]);
                            double x2 = ((-k[1]) + Math.Sqrt(discr)) / (2 * k[0]);

                        }
                        // D = 0 -> one root
                        else if (discr == 0)
                        {
                            double x1 = (-k[1]) / (2 * k[0]);

                        }
                        else// D < 0 -> complex roots
                        {

                        }
                        break;

                    default:

                        break;
                }
            }
            catch
            {

            }

            return n;
        }
        static string Output(double[] k, bool veboseOn, bool fileOutput)
        {
            if (verboseOn) //  Verbose
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
                if (discr > 0)
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
                else if (discr == 0)
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
                    Console.WriteLine($"x1 = ({-k[1]} +√|{discr}|)/{2 * k[0]}");
                    Console.WriteLine($"x2 = ({-k[1]} -√|{discr}|)/{2 * k[0]}");

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

            return 0;
        }
    }
}