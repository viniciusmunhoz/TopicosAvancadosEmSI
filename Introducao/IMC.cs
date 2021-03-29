using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjAula1;

namespace ProjAula1
{
    class IMC
    {
        static void Min(String[] Args)
        {
            Console.Write(" POR FAVOR INFORME O SEU PESO EM KG: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write(" POR FAVOR INFOME SUA ALTURA EM METROS: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> ABAIXO DO PESO!. ");
            }
            else if ((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> PESO NORMAL!. ");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> ACIMA DO PESO!. ");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> OBESO!. ");
            }
            else
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> MUITO OBESO!. ");
            }

            Console.ReadKey();
        }
    }
}