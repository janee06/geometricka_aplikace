using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricka_aplikace
{
    internal class Program
    {
        //2D
        static double obvodctverce(double x)
        {
            return (4 * x);
        }
        static double obsahctverce(double x)
        {
            return (x * x);

        }
        static double obvodobdelniku(double x, double y)
        {
            return (2 * x) + (2 * y);
        }
        static double obsahobdelniku(double x, double y)
        {
            return (x * y);
        }
        static double obvodtrojuhelniku(double x, double y, double z)
        {
            return (x + y + z);
        }
        static double obsahtrojuhelniku(double s, double v)
        {
            return (s * v) / 2;
        }
        static double obvodkruhu(double r)
        {
            return 2 * Math.PI * r;
        }
        static double obsahkruhu(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        //3D
        static double objemkrychle(double a)
        {
            return Math.Pow(a, 3);
        }
        static double povrchkrychle(double a)
        {
            return 6 * Math.Pow(a, 2);
        }
        static double objemkvádru(double a, double b, double c)
        {
            return a * b * c;
        }
        static double povrchkvadru(double a, double b, double c)
        {
            return 2 * ((a * b) + (b * c) + (c * a));
        }
        static double objemvalce(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static double povrchvalce(double r, double v)
        {
            return (2 * Math.PI * r * v) + (2 * Math.PI * r * r);
        }
        static double objemjehlanu(double a, double v)
        {
            return (1 / 3) * a * a * v;
        }
        static double povrchjehlanu(double a, double v)
        {
            return a * (a + Math.Sqrt(4 * Math.Pow(v, 2) + a * a));
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("vyberte 2D nebo 3D tvar");
                Console.WriteLine("1. 2D");
                Console.WriteLine("2. 3D");
                int volba2D = int.Parse(Console.ReadLine());
                switch (volba2D)
                {
                    case 1: //2D

                        Console.WriteLine("Vyberte geometrický tvar: ");
                        Console.WriteLine("1. Obvod čtverce");
                        Console.WriteLine("2. Obsah čtverce");
                        Console.WriteLine("3. Obvod obdélníku");
                        Console.WriteLine("4. Obsah obdélníku");
                        Console.WriteLine("5. Obvod trojúhelníku");
                        Console.WriteLine("6. Obsah trojúhelníku");
                        Console.WriteLine("7. Obvod kruhu");
                        Console.WriteLine("8. Obsah kruhu");

                        int volba2 = int.Parse(Console.ReadLine());
                        double vysledek = 0;
                        switch (volba2)
                        {
                            case 1:
                                Console.WriteLine("Zadejet číslo v cm");
                                double x = double.Parse(Console.ReadLine());
                                vysledek = obvodctverce(x);
                                Console.WriteLine("Obvod čtverce je " + vysledek + "cm");
                                break;
                            case 2:
                                Console.WriteLine("Zadejte číslo v cm");
                                double a = double.Parse(Console.ReadLine());
                                vysledek = obsahctverce(a);
                                Console.WriteLine("Obsah čtverce je " + vysledek + "cm^2");
                                break;
                            case 3:
                                Console.WriteLine("Zadejet první číslo v cm");
                                double aa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte druhé číslo v cm");
                                double b = double.Parse(Console.ReadLine());
                                vysledek = obvodobdelniku(aa, b);
                                Console.WriteLine("Obvod obdelníku je " + vysledek + "cm");
                                break;
                            case 4:
                                Console.WriteLine("Zadejet první číslo v cm");
                                double aaa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte druhé číslo v cm");
                                double bb = double.Parse(Console.ReadLine());
                                vysledek = obsahobdelniku(aaa, bb);
                                Console.WriteLine("Obsah obelníku je " + vysledek + "cm^2");
                                break;
                            case 5:
                                Console.WriteLine("Zadejet první číslo v cm");
                                double xx = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet třetí číslo v cm");
                                double y = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet třetí číslo v cm");
                                double z = double.Parse(Console.ReadLine());
                                vysledek = obvodtrojuhelniku(xx, y, z);
                                Console.WriteLine("Obvod trojúhelníku je " + vysledek + "cm");
                                break;
                            case 6:
                                Console.WriteLine("Zadejet číslo starny v cm");
                                double s = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet výšku trojúhelníku v cm");
                                double v = double.Parse(Console.ReadLine());
                                vysledek = obsahtrojuhelniku(s, v);
                                Console.WriteLine("Obsah trojúhelníku je " + vysledek + "cm^2");
                                break;
                            case 7:
                                Console.WriteLine("Zadejet poloměr v cm");
                                double r = double.Parse(Console.ReadLine());
                                vysledek = obvodkruhu(r);
                                Console.WriteLine("Obvod kruhu je " + vysledek + "cm");
                                break;
                            case 8:
                                Console.WriteLine("Zadejet poloměr v cm");
                                double rr = double.Parse(Console.ReadLine());
                                vysledek = obsahkruhu(rr);
                                Console.WriteLine("Obsah kruhu je " + vysledek + "cm^2");

                                break;
                            default:
                                break;

                        }
                        break;

                    case 2: //3D
                        Console.WriteLine("Vyberte geometrický tvar");
                        Console.WriteLine("1. Objem krychle");
                        Console.WriteLine("2. Povrch krychle");
                        Console.WriteLine("3. Objem kvádru");
                        Console.WriteLine("4. Povrch kvádru");
                        Console.WriteLine("5. Objem válce");
                        Console.WriteLine("6. Povrch válce");
                        Console.WriteLine("7. Objem jehlanu");
                        Console.WriteLine("8. Povrch jehlanu");
                        int volba3 = int.Parse(Console.ReadLine());
                        double vysledek2 = 0;
                        switch (volba3)
                        {
                            case 1:
                                Console.WriteLine("Zadejet číslo v cm");
                                double a = double.Parse(Console.ReadLine());
                                vysledek2 = objemkrychle(a);
                                Console.WriteLine("Objem krychle je " + vysledek2 + "cm^3");
                                break;
                            case 2:
                                Console.WriteLine("Zadejet číslo v cm");
                                double aa = double.Parse(Console.ReadLine());
                                vysledek2 = povrchkrychle(aa);
                                Console.WriteLine("Povrch krychle je " + vysledek2 + "cm^2");
                                break;
                            case 3:
                                Console.WriteLine("Zadejete první číslo v cm");
                                double aaa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet druhé číslo v cm");
                                double b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet třetí číslo v cm");
                                double c = double.Parse(Console.ReadLine());
                                vysledek2 = objemkvádru(aaa, b, c);
                                Console.WriteLine("Objem kvádru je " + vysledek2 + "cm^3");
                                break;
                            case 4:
                                Console.WriteLine("Zadejete první číslo v cm");
                                double x = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet druhé číslo v cm ");
                                double y = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet třetí číslo v cm");
                                double z = double.Parse(Console.ReadLine());
                                vysledek2 = povrchkvadru(x, y, z);
                                Console.WriteLine("Povrch kvádru je " + vysledek2 + "cm^2");
                                break;
                            case 5:
                                Console.WriteLine("Zadejet poloměr v cm");
                                double r = double.Parse(Console.ReadLine());
                                vysledek2 = objemvalce(r);
                                Console.WriteLine("Objem válce je " + vysledek2 + "cm^3");
                                break;
                            case 6:
                                Console.WriteLine("Zadejet poloměr v cm");
                                double rr = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet výšku v cm");
                                double v = double.Parse(Console.ReadLine());
                                vysledek2 = povrchvalce(rr, v);
                                Console.WriteLine("Povrch válce je " + vysledek2 + "cm^2");
                                break;
                            case 7:
                                Console.WriteLine("Zadejte první číslo v cm");
                                double cislo = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet výšku v cm");
                                double vyska = double.Parse(Console.ReadLine());
                                vysledek2 = objemjehlanu(cislo, vyska);
                                Console.WriteLine("Objem jehlanu je " + vysledek2 + "cm^3");
                                break;
                            case 8:
                                Console.WriteLine("Zadejete číslo v cm");
                                double cislo2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejet výšku jehlanu v cm");
                                double vyska2 = double.Parse(Console.ReadLine());
                                vysledek2 = povrchjehlanu(cislo2, vyska2);
                                Console.WriteLine("Povrch jehlanu je " + vysledek2 + "cm^2");
                                break;
                            default:
                                break;

                        }
                        break;
                    default:
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}

