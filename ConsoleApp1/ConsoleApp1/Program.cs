using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void nazwa()
        {
            Console.WriteLine(Environment.MachineName);

        }
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ --- MENU APLIKACJI --- ]");
            Console.ResetColor();
            Console.WriteLine("[1. Obliczanie pierwiastka z liczby ]");
            Console.WriteLine("[2. Oblicz Delte ]");
            Console.WriteLine("[3. Zaokrąglanie libcz]");
            Console.WriteLine("[4. Oblicz potęge danej liczy ]");
            Console.WriteLine("[5. Policz Funkcje Liniową ]");
            Console.WriteLine("[0. Zamknij aplikacje ]");
            Console.WriteLine();
            Console.WriteLine("Podaj cyfre aby rozpocząć lub zakończyć działanie programu");
        }
        static void KolorWynik()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Rozwiązanie : ");
            Console.ResetColor();
        }
        static double P(double x) => Math.Sqrt(x);

        static double Pow(double x, double y) => Math.Pow(x, y);
        static double Delta(double a, double b, double c)
        {
            double Delta = (b * b) - (4 * a * c);
            return Delta;
        }
        static decimal Zaokro(decimal a, int b) => Math.Round(a, b);

          static double Fliniowa(double a, double b)
        {
                
                double x = -b / a;
                return x;
            
        }
        
        static void Main(string[] args)
        {

            int k;
            Console.Write("Witaj "); nazwa();
            do
            {

                Menu();
                k = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (k)
                {
                    case 1:
                        Console.WriteLine("Podaj liczbe z ktorej chcesz obliczyć pierwiastek");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podana przez Ciebie liczba : {0} ", x);
                        KolorWynik();
                        Console.WriteLine(P(x));
                        Console.WriteLine("");

                        break;
                    case 2:
                        Console.WriteLine(" --- Podaj a --- ");
                        int q = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" --- Podaj b --- ");
                        int w = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" --- Podaj c --- ");
                        int e = Convert.ToInt32(Console.ReadLine());
                        KolorWynik();
                        Console.WriteLine(Delta(q, w, e));
                        break;
                    case 3:
                        Console.WriteLine("Podaj liczbe którą chcesz zaokrąglić");
                        decimal l = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Podaj ile miejsc po przecinku");
                        int o = Convert.ToInt32(Console.ReadLine());
                        KolorWynik();
                        Console.WriteLine(Zaokro(l, o));
                        break;
                    case 4:

                        Console.WriteLine(" --- Podaj liczbe --- ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" --- Podaj wartość potęgi --- ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        KolorWynik();
                        Console.WriteLine(Pow(a, b));

                        break;
                    case 5:
                        Console.WriteLine("Podaj a");
                         double h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj b");
                        double y = Convert.ToDouble(Console.ReadLine());
                        if(h!=0)
                            {
                            KolorWynik();
                            Console.WriteLine(Fliniowa(h, y));
                            }
                        else if(y!=0)
                            {
                            Console.WriteLine("Rozwiazanie sprzeczne");
                            }
                        else
                            {
                            Console.WriteLine("To równanie ma nieskończenie wiele rozwiazań");
                            }
                        break;
                    

                    case 0:
                        break;
                    default:
                        Console.WriteLine("To wykracza po za program! ");
                        break;
                }

            } while (k != 0);

            Console.WriteLine("Dziękuje za skorzystanie z programu");
                nazwa();
            

        }

    }
}