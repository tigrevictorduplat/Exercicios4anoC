using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoExercicios
{
    class CalculadoraLoop
    {
        public static void somarEnquanto() {
            Console.WriteLine("Bem vindo à Somadora Automática!");
            Console.WriteLine("OBS: Para sair digite 0");
            int numeroSomado=0;
            int numeroDigitado = 1;
            while (numeroDigitado != 0)
            {
                Console.WriteLine("Digite um valor inteiro");
                numeroDigitado = int.Parse(Console.ReadLine());
                numeroSomado += numeroDigitado;
                Console.WriteLine("A soma está em: " + numeroSomado);              

            }


        
        }
        public static void calculaFatorial() {

            Console.WriteLine("Bem vindo à Calculadora Fatorial!");
            Console.WriteLine("Digite um valor inteiro");
            int numeroDigitado = int.Parse(Console.ReadLine());
            int comparadorAntecessor = numeroDigitado -1;
            while (comparadorAntecessor != 0) {

                Console.WriteLine(numeroDigitado + "*" + comparadorAntecessor);
                numeroDigitado = numeroDigitado * comparadorAntecessor;
                Console.WriteLine("=" + numeroDigitado);
                comparadorAntecessor--;
                
            };
            Console.WriteLine("O resultado do produto é: " + numeroDigitado);
            Console.ReadKey();

        }
        public static void imprimeIntervalo()
        {
            Console.WriteLine("Bem vindo ao Imprime Intervalo!");
            Console.WriteLine("Escolha dois números para testar seus múltiplos");
            int primeiroNumero = int.Parse(Console.ReadLine());
            int segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o intervalo [dois números inteiros]");
            Console.WriteLine("Começo");
            int comecoIntervalo = int.Parse(Console.ReadLine());
            Console.WriteLine("Final");
            int finalIntervalo = int.Parse(Console.ReadLine());
            int i = comecoIntervalo;
            while (i>=comecoIntervalo && i <= finalIntervalo)
            {
                int testeModPrimeiro = i % primeiroNumero;
                int testeModSegundo = i % segundoNumero;
              if (testeModPrimeiro== 0)
                {
                    Console.WriteLine($"{i} é múltiplo de {primeiroNumero}");
                }
              if (testeModSegundo== 0)
                {
                    Console.WriteLine($"{i} é múltiplo de {segundoNumero }");
                }
                i++;
            }
            Console.ReadKey();
        }

        public static void tabelaConversaoFahrenheitCelsius(){
            double grausCelcius;
            Console.WriteLine("Bem vindo ao Conversor de para Celcius!"); 
            Console.WriteLine("Escolha o intervalo [dois números inteiros]");
            Console.WriteLine("Começo");
            int comecoIntervalo = int.Parse(Console.ReadLine());
            Console.WriteLine("Final");
            int finalIntervalo = int.Parse(Console.ReadLine());
            int i = comecoIntervalo;
            Console.WriteLine("Fahrenheit || Celcius");
            while (i >= comecoIntervalo && i <= finalIntervalo)
            {
                grausCelcius = (5 * (i - 32)) / 9;
                Console.WriteLine($"{i}F° || {grausCelcius}C°");
                i++;
            };
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }

        public static void sistemaEleitoral()
        {
            Console.WriteLine("Bem vindo ao Sistema Eleitoral! \n" +
                " Digite aqui em quem você vai votar");
        }
    }
}
