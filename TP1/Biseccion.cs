﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
   public class Biseccion
    {
        public static double f(double x)
        {
            /* double e = 2.71828;
             return ((x * x * x * x * x - 1) * (e * x) - 10);*/
            //return ((12.5 * (x + 2)) / (x * x + 4 * x + 5)) + 2;
            return Math.Abs(x * x - 4) + 2 * x;
        }
        static void Main(string[] args)
        {

            double extremoderecho = 0, extremoizquierdo = 0, xr = 0;

            Console.WriteLine("Ingrese extremo izquierdo");
            string i = Console.ReadLine();
            extremoizquierdo = double.Parse(i);

            Console.WriteLine("Ingrese extremo derecho");
            string d = Console.ReadLine();
            extremoderecho = double.Parse(d);


            if (f(extremoizquierdo) * f(extremoderecho) > 0)
            {
                Console.WriteLine("No se cumple que f(extremoderecho)*f(extremoizquierdo) < 0");
                Console.ReadKey();
                return;
            }
            else if (f(extremoizquierdo) * f(extremoderecho) == 0)
            {
                if (f(extremoizquierdo) == 0)
                {
                    Console.WriteLine("El extremo izquierdo es la raiz");
                    Console.ReadKey();
                    return;
                }
                else if (f(extremoderecho) == 0)
                {
                    Console.WriteLine("El extremo derecho es la raiz");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                int contador = 0;
                double Xant = 0;
                double Error = 0;
                int Iteraciones = 100;
                double Tolerancia = 0.0001;
                do
                {
                    xr = (extremoizquierdo + extremoderecho) / 2;
                    contador = contador + 1;
                    Error = Math.Abs((xr - Xant) / xr);

                    if (Math.Abs(f(xr)) < Tolerancia | contador > Iteraciones | Error < Tolerancia)
                    {
                        Console.WriteLine("La raiz aproximada es r= " + xr);
                        Console.WriteLine("El valor de f en r= " + f(xr));
                        Console.WriteLine("El error relativo es= " + Error);
                        Console.WriteLine("La cantidad de iteraciones que se realizaron fueron= " + contador);
                        Console.ReadKey();
                        return;
                    }
                    else if (f(extremoizquierdo) * f(extremoderecho) < 0)
                    {
                        extremoizquierdo = xr;
                    }
                    else
                    {
                        extremoderecho = xr;
                    }
                    Xant = xr;
                } while (Error > Tolerancia && contador <= Iteraciones);
            }
        }
    }
}
