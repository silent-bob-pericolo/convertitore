﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resto;
            string numeroConvertito = "";
            int divisore;
            Console.WriteLine("inserisci il numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il divisore");
            divisore = Convert.ToInt32(Console.ReadLine());
            while (numero > 0)
            {
                resto = numero % divisore;
                numero = numero / 2;
                numeroConvertito = Convert.ToString(resto) + numeroConvertito;
            }
            Console.WriteLine($"{numeroConvertito}");
            Console.ReadLine());
        }
    
    }
}
