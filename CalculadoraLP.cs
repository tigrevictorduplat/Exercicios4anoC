using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicios
{
     class CalculadoraLP
    {
        public static void calculaMediaIdade()
        {
            Console.WriteLine("Bem vindo ao Calculo de Média de Idades!");
            Console.WriteLine("Quantos de quantas pessoas você deseja calcular a idade?");
            int numeroPessoas = int.Parse(Console.ReadLine());
            int somaIdades = 0;
            int i = 0;
            while (i < numeroPessoas)
            {
                Console.WriteLine("Digite a idade " + (i + 1));
                somaIdades += int.Parse(Console.ReadLine());
                i++;
            }
            float mediaIdade = somaIdades / numeroPessoas;
            Console.WriteLine($"A média das idades é: {Math.Round(mediaIdade, 2)}");
            Console.ReadKey();
        }
        public static void calculaBaskara(){
            Console.WriteLine("Esta é a calculadora de Baskara...");
            Console.WriteLine("Informe ,respectivivamente, números para 'a' , 'b' e 'c' :");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double delta = (b*b) - (4 * a * c);
            if(delta >= 0)
            {
            double x1 = b - Math.Sqrt(delta) / 2*a;
            double x2 = b + Math.Sqrt(delta) / 2*a;
                if (x1 == x2)
                {
                    Console.WriteLine($"A raíz da equação é {x1}");
                } else
                {
                    Console.WriteLine($"As raízes da equação são {x1} e {x2}");
                }
            } else
            {
                Console.WriteLine("Não há raizes reais para esta equação!");
            }
            Console.ReadKey();

        }

        public static void calculaIMC()
        {
            Console.WriteLine("Calculadora de IMC... qual será o seu?");
            Console.WriteLine("Informe ,respectivivamente, sua altura em metros e peso em Kg :");
            double altura = double.Parse(Console.ReadLine());
            double peso = double.Parse(Console.ReadLine());
            double IMC = (peso) / (altura * altura);
            Console.WriteLine($"Seu nível de IMC é de {Math.Round(IMC,2)} pontos");
        }
    }  
}
