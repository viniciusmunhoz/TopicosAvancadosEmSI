﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio14
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int count = 0;

            for (int i = 15; i <= 100; i++)
            {
                soma += i;
                count += 1;
            }

            Console.Write("Media aritmetica dos números inteiros entre 15 e 100: " + (soma/count));
            Console.ReadKey();
        }
    }
}
