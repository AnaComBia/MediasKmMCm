using System;

namespace MediasKmMCm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nfale a médida em Metros: ");
            double MedidaMetros = Convert.ToDouble(Console.ReadLine());

            double MedidaKm = MedidaMetros / 1000;
            double MedidaCm = MedidaMetros * 100;

            Console.Write($"\n----Resultado---\n Km = {MedidaKm}\n M = {MedidaMetros}\n Cm = {MedidaCm}\n");


    
        }
    }
}
