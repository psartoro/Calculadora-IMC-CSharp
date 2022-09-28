using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMC.Models
{
    public class Calculadora
    {
        double peso = 0;
        double altura = 0;
        double IMC = 0;

        public Calculadora(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public int CalculaIMC()
        {
            if (peso > 0 && altura > 0)
            {
                IMC = peso / (Math.Pow(altura, 2));

                if (IMC < 18.5)
                {
                    Console.WriteLine($"\nSeu IMC é {Math.Round(IMC, 2)}. Magreza (ATENÇÃO)\n");
                }
                else if (IMC >= 18.5 && IMC <= 24.9)
                {
                    Console.WriteLine($"\nSeu IMC é {Math.Round(IMC, 2)}. Normal\n");
                }
                else if (IMC >= 25 && IMC <= 30)
                {
                    Console.WriteLine($"\nSeu IMC é {Math.Round(IMC, 2)}. Sobrepeso (ATENÇÃO)\n");
                }
                else
                {
                    Console.WriteLine($"\nSeu IMC é {Math.Round(IMC, 2)}. Obesidade (CUIDADO)\n");
                }
                return 1;
            }
            return 0;
        }
    }
}