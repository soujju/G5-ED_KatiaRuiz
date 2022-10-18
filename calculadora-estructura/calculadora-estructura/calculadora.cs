using System;

namespace calculadoraestructura
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num=0;
            double num2=0;
            double res;
            string opera;
            string res2;

            do
            {
                Console.Clear();
                Console.WriteLine("ingresa primer numero:");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingresa operacion (/,+,-,*,^):");
                opera = Console.ReadLine();
                Console.WriteLine("ingresa segundo numero:");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (opera)
                {
                    case "+":
                        res = (num + num2);
                        Console.WriteLine("resultado: " + res);
                        break;

                    case "-":
                        res = (num - num2);
                        Console.WriteLine("resultado: " + res);
                        break;

                    case "x":
                        res = (num * num2);
                        Console.WriteLine("resultado: " + res);
                        break;

                    case "/":
                        res = (num / num2);
                        Console.WriteLine("resultado: " + res);
                        break;
                    case "^":
                        res = Math.Pow(num, num2);
                        Console.WriteLine("resultado: " + res);
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("desea hacer otra operacion? (s/n)");
                res2 = Console.ReadLine();

            } while (res2 == "s");
        }

    }
}
