using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Task1
{
    internal class Program
    {
        private static int b;

        static void Main(string[] args)
        {
            #region Taks1
            int[,] mass = new int[2, 2];

            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    Console.Write($"mass[{a},{b}]=");
                    mass[a, b] = int.Parse(Console.ReadLine());
                }

            }
            {
                if (mass[0, 0] > mass[0, 1])
                {
                    Console.Write("Mass[0.0]=");
                    Console.WriteLine(mass[0, 0]);
                }

                else
                {
                    Console.Write("Mass[0.1]=");
                    Console.WriteLine(mass[0, 1]);
                }
            }
            {
                if (mass[1, 0] > mass[1, 1])
                {
                    Console.Write("Mass[1.0]=");
                    Console.WriteLine(mass[1, 0]);
                }

                else
                {
                    Console.Write("Mass[1.1]=");
                    Console.WriteLine(mass[1, 1]);

                }
            }
            #endregion
            #region Task2
            //Console.Write("Massivin uzunlugu:");
            //int a = int.Parse(Console.ReadLine());
            //int[] mass = new int[a];


            //for (var b = 0; b < mass.Length; b++)
            //{
            //    Console.Write($"mass[{b}]=");
            //    mass[b] = int.Parse(Console.ReadLine());
            //}
            //for (int b = 0; b < mass.Length; b++)
            //{
            //    Console.WriteLine("");
            //    Console.Write($"mass[{b}]=");
            //    Console.WriteLine(mass[b]);
            //    {
            //        double d = mass[b] % 2;
            //        int e = 0;
            //        double f = mass[b];
            //        int t = 0;
            //        for (t=0;t<mass.Length;t++)              
            //        { 
            //            if (d > 0)
            //                Console.WriteLine("Eded tekdir");

            //            else
            //                Console.WriteLine("Eded cemdir");

                      
            //        }
            //        Console.WriteLine(t);

            //    }
            //    {
            //        if (mass[b] < 0)
            //        {
            //            Console.WriteLine("Eded menfidir");
            //        }

            //        else
            //        {
            //            Console.WriteLine("eded musbetdir");
            //        }

            //    }

            //}
            #endregion
            #region Task3
            //Console.Write("Massivin uzunlugu:");
            //int a = int.Parse(Console.ReadLine());
            //int[] mass = new int[a];


            //for (var b = 0; b < mass.Length; b++)
            //{
            //    Console.Write($"mass[{b}]=");
            //    mass[b] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < mass.Length; i++) 
            //{
            //    Console.WriteLine(mass[i]);
            //    int l = mass[0]-mass[i];

            //    if (mass[0] + l != mass[i]) 
            //    {
            //        Console.WriteLine("Ededi silsiledir");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Ededi silsile deyil");
            //    } 


        }
#endregion 
            #region task4
            //Console.Write("Massivin uzunlugu:");
            //int a = int.Parse(Console.ReadLine());
            //int[] mass = new int[a];


            //for (int b = 0; b < mass.Length; b++)
            //{
            //    Console.Write($"mass[{b}]=");
            //    mass[b] = int.Parse(Console.ReadLine());
            //}
            //int birinci = 0;
            //int Sonuncu = 0;
            //int tmp = 0;

            //for (int i = 0; i < mass.Length; i++) 
            //{
            //    birinci = mass[0];
            //    Sonuncu = mass[mass.Length];
            //}

            //tmp = mass[Sonuncu];
            //mass[Sonuncu] = mass[birinci];
            //mass[birinci] = tmp;

            //for (b = 0; b < mass.Length; b++) 
            //{
            //    Console.WriteLine(mass);
            //}

            #endregion
        }
    }
