﻿using System;

namespace TehtavaC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä kokonaisluku (0-9): ");
            int luku = int.Parse(Console.ReadLine());

            switch (luku)
            {
                case 0:
                    Console.WriteLine("Nolla");
                    break;
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;
                default:
                    Console.WriteLine("Syötit luvun, joka ei ole välillä 0-9.");
                    break;
            }
        }
    }
}

