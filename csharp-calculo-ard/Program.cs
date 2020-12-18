using System;
using System.Globalization;

namespace AreaPerimetroDiagonal
    {
        class Program
        {
            static void Main(string[] args)
            {

                double x = 2.0;
                double aaltura, abase;
                double area, perimetro, diagonal;


                aaltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                abase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                area = abase * aaltura;
                perimetro = (abase + aaltura) * x;
                diagonal = Math.Sqrt(Math.Pow(aaltura, x) + Math.Pow(abase, x));


                Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
                Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
                Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

            }
        }
    }

// retângulo
// base = 5.0 / altura = 4.0

// calcular
// AREA =
// PERIMETRO =
// DIAGONAL =
// 4 decimos
