using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_for
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Aufgabe---------Geben sie bunte Zufallszahlen auf der Konsole aus!*/


            //Console.WriteLine("ConsoleBunteZufallsZahl");
            //Console.WriteLine();
            //Console.Write("Geben Sie eine obere Schranke an: ");
            //int max = Convert.ToInt32(Console.ReadLine());

            //int endCounter = 0;
            //while (endCounter != 1)
            //{
            //    Random r = new Random();
            //    for (int j = 0; j < max; j++)
            //    {
            //        int zZahl = r.Next(1000);
            //        if (zZahl % 2 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //        }
            //        if (zZahl % 3 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //        }
            //        if (zZahl % 5 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //        }
            //        if (zZahl % 7 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //        }
            //        if (zZahl % 9 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Magenta;
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //        }
            //        if (zZahl % 11 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Cyan;
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //        }
            //        if (!(zZahl % 11 == 0) && !(zZahl % 9 == 0) && !(zZahl % 7 == 0) && !(zZahl % 5 == 0) && !(zZahl % 3 == 0) && !(zZahl % 2 == 0))
            //        {
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //        }
            //        Console.Write(zZahl.ToString().PadLeft(4));
            //    }

            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ReadLine();
            //    Console.WriteLine();

            //    int i = 0;
            //    while (i == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.Write("Programm beenden? Ja / Nein: ");
            //        string str = Console.ReadLine();
            //        Console.WriteLine();
            //        switch (str.ToUpper())
            //        {
            //            case "JA":
            //                endCounter = 1;
            //                i = 1;
            //                break;
            //            case "NEIN":
            //                endCounter = 0;
            //                i = 1;
            //                break;
            //            default:
            //                Console.ForegroundColor = ConsoleColor.White;
            //                Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
            //                i = 0;
            //                continue;
            //        }
            //    }
            //}



            /*Aufgabe-----------Berechne alle Primzahlen innerhalb eines bestimmten Zahlenbereichs und messe die
                                Zeit, die für die Berechnung notwendig ist!*/


            Console.WriteLine("ConsolePrimzahlen");
            Console.WriteLine();
            Console.WriteLine("Eine Primzahl ist eine natürliche Zahl > 1, die nur durch 1 und sich selbst teilbar ist.");
            Console.WriteLine();

            int endCounter = 0;
            while (endCounter != 1)
            {
                Stopwatch watch = new Stopwatch();
                Console.Write("Bitte geben Sie die obere Schranke an: ");
                int pLimit = Convert.ToInt32(Console.ReadLine());
                watch.Start();
                int pCount = 0;
                int nCheck = 0;
                for (int j = 2; j < pLimit; j++)
                {
                    nCheck++;
                    bool p = true;

                    for (int k = 2; k < j / 2 + 1; k++)
                    {
                        if (j % k == 0)
                        {
                            nCheck++;
                            p = false;
                            break;
                        }
                        else
                        {
                            nCheck++;
                        }
                    }
                    if (p)
                    {
                        nCheck++;
                        pCount++;
                        Console.Write(j.ToString().PadLeft(6));
                    }
                }
                watch.Stop();
                int duration = Convert.ToInt32(watch.Elapsed.TotalMilliseconds);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Gemessene Zeit: " + duration + "ms");
                Console.WriteLine("Anzahl durchgeführter Operationen: " + nCheck);
                Console.WriteLine("Anzahl gefundener Primzahlen: " + pCount);


                Console.WriteLine();
                int i = 0;
                while (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Programm beenden? Ja / Nein: ");
                    string str = Console.ReadLine();
                    Console.WriteLine();
                    switch (str.ToUpper())
                    {
                        case "JA":
                            endCounter = 1;
                            i = 1;
                            break;
                        case "NEIN":
                            endCounter = 0;
                            i = 1;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
                            i = 0;
                            continue;
                    }
                }
            }
        }
    }
}
