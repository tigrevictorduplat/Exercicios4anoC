namespace ProjetoExercicios
{
    class CalculadoraLoop
    {
        public static void somarEnquanto()
        {
            Console.WriteLine("Bem vindo à Somadora Automática!");
            Console.WriteLine("OBS: Para sair digite 0");
            int numeroSomado = 0;
            int numeroDigitado = 1;
            while (numeroDigitado != 0)
            {
                Console.WriteLine("Digite um valor inteiro");
                numeroDigitado = int.Parse(Console.ReadLine());
                numeroSomado += numeroDigitado;
                Console.WriteLine("A soma está em: " + numeroSomado);

            }



        }
        public static void calculaFatorial()
        {

            Console.WriteLine("Bem vindo à Calculadora Fatorial!");
            Console.WriteLine("Digite um valor inteiro");
            int numeroDigitado = int.Parse(Console.ReadLine());
            int comparadorAntecessor = numeroDigitado - 1;
            while (comparadorAntecessor != 0)
            {

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
            while (i >= comecoIntervalo && i <= finalIntervalo)
            {
                int testeModPrimeiro = i % primeiroNumero;
                int testeModSegundo = i % segundoNumero;
                if (testeModPrimeiro == 0)
                {
                    Console.WriteLine($"{i} é múltiplo de {primeiroNumero}");
                }
                if (testeModSegundo == 0)
                {
                    Console.WriteLine($"{i} é múltiplo de {segundoNumero}");
                }
                i++;
            }
            Console.ReadKey();
        }

        public static void tabelaConversaoFahrenheitCelsius()
        {
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
                " Lembre dos números dos Candidatos! \n" +
                "Candidado 1 - 01 \nCandidato 2 - 02 \nCandidato 3 - 03 \nCandidato 4 - 04 \nVoto Nulo - N | Voto Branco - B");
            string selecaoVoto = "";
            int[] contVotoCandidato = new int[6];
            while (selecaoVoto != "0")
            {
                Console.WriteLine("Vote agora no seu candidato:");
                selecaoVoto = Console.ReadLine();
                switch (selecaoVoto)
                {
                    case "0":
                        Console.WriteLine("Votação Encerrada!");
                        break;
                    case "1":
                    case "01":
                        contVotoCandidato[0]++;
                        Console.WriteLine("Voto Computado!");
                        break;
                    case "2":
                    case "02":
                        contVotoCandidato[1]++;
                        Console.WriteLine("Voto Computado!");
                        break;
                    case "3":
                    case "03":
                        contVotoCandidato[2]++;
                        Console.WriteLine("Voto Computado!");
                        break;
                    case "4":
                    case "04":
                        contVotoCandidato[3]++;
                        Console.WriteLine("Voto Computado!");
                        break;
                    case "N":
                    case "n":
                        contVotoCandidato[4]++;
                        Console.WriteLine("Voto Computado!");
                        break;
                    case "B":
                    case "b":
                        contVotoCandidato[5]++;
                        Console.WriteLine("Voto Computado!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }


            double calculoPorcentagemNulo = (contVotoCandidato[4] * 100) / contVotoCandidato.Sum() ;
            double porcentagemVotosNulo = (contVotoCandidato[4] == 0) ? 0 : calculoPorcentagemNulo;
            double calculoPorcentagemBranco = (contVotoCandidato[5]*100 )/ contVotoCandidato.Sum();
            double porcentagemVotosBranco = (contVotoCandidato[5] == 0) ? 0 : calculoPorcentagemBranco;

            Console.WriteLine($"Resultados da Votação - {contVotoCandidato.Sum()} votos\n" +
                    $"Candidato 1 - {contVotoCandidato[0]} votos\n" +
                    $"Candidato 2 - {contVotoCandidato[1]} votos\n" +
                    $"Candidato 3 - {contVotoCandidato[2]} votos\n" +
                    $"Candidato 4 - {contVotoCandidato[3]} votos\n" +
                    $"Votos Nulos - {contVotoCandidato[4]} votos\n" +
                    $"Votos Brancos - {contVotoCandidato[5]} votos\n" +
                    $"Porcentagem de Votos Nulos - {porcentagemVotosNulo}% \n" +
                    $"Porcetagem de Votos em Branco - {porcentagemVotosBranco}% ");
        }
    }
}
