void ExibeTitulo() {
    Console.WriteLine(@"NÚMERO SECRETO");
}

void ExibeMenu()
{
    Console.WriteLine("\nOlá Selecione a opção desejada: ");
    Console.WriteLine("Digite [1] novo jogo: ");
    Console.WriteLine("Digite [2] sair do jogo: ");

    Console.Write("\nDigite a sua opção: ");
    Console.WriteLine();
    String opcao = Console.ReadLine()!;
    int opcaoInt = int.Parse(opcao);

    switch (opcaoInt)
    {
        case 1:
            Console.WriteLine("Novo jogo");
            Console.Write("Qual o seu nome? ");
            String nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "! Você tem 5 chances para acertar o número secreto.");
            Console.WriteLine("Será que você consegue adivinhar qual o número que estou pensando?");
            int tentativas = 0;
            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 101);
            Console.WriteLine("Digite um número entre 1 e 100: ");
            


            while (tentativas < 5) {

                Console.WriteLine("Tentativa " + (tentativas + 1) + ": ");
                int numeroUsuario = int.Parse(Console.ReadLine()!);
                tentativas++;

                if (numeroUsuario == numeroSecreto) {
                    Console.WriteLine("Parabéns, " + nome + "! você acertou o número secreto em " + tentativas + " tentativas!");
                    break;
                }
                else if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("O número secreto que estou pensando é maior do que " + numeroUsuario + "!");
                }
                else
                {
                    Console.WriteLine("O número secreto que estou pensando é menor do que " + numeroUsuario + "!");
                }
            }

            if (tentativas == 5)
            {
                Console.WriteLine("Suas tentativas acabaram. O número secreto era " + numeroSecreto);
            }

            break;
        case 2:
            Console.WriteLine("Saindo do jogo. Até a próxima...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

ExibeTitulo();
ExibeMenu();