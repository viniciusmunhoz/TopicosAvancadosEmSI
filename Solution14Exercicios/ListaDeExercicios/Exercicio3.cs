﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            double custoTotal, custoFabrica;

            Console.Write("Informe o custo total para a fabrica: R$");
            custoFabrica = double.Parse(Console.ReadLine());

            custoTotal = custoFabrica * 1.73;

            Console.Write("\nCusto total para o consumidor: R$" + custoTotal);
            Console.ReadKey();
        }
    }
}
