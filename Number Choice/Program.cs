//Game Choice

using System.Runtime.CompilerServices;

Random aleatorio = new Random();
int numeroAleatorio = aleatorio.Next(1, 101);
int qtTentativa = 1;

void Start()
{
    Console.WriteLine(@"
█▀▀ █░█ █▀█ █ █▀▀ █▀▀   ▀█▀ █░█ █▀▀   █▄░█ █░█ █▀▄▀█ █▄▄ █▀▀ █▀█
█▄▄ █▀█ █▄█ █ █▄▄ ██▄   ░█░ █▀█ ██▄   █░▀█ █▄█ █░▀░█ █▄█ ██▄ █▀▄");
    Console.WriteLine("\nBem vindo ao Choice Number");
    Console.WriteLine("\nNeste jogo, para ganhar, basta escolher o mesmo número sorteado pela máquina.");
}


Start();

do
{
    Console.Write("\nEscolha um número entre 0 e 100: ");
    string numeroEscolhido = Console.ReadLine()!;
    int numeroEscolhidoConv = int.Parse(numeroEscolhido);
    int numeroProximo1 = numeroAleatorio - numeroEscolhidoConv;
    int numeroProximo2 = numeroEscolhidoConv - numeroAleatorio;



    Console.WriteLine("\nTentativa: " + qtTentativa);
    qtTentativa++;

    if (qtTentativa > 5)
    {
        Console.WriteLine("\nVocê perdeu :(");
        Console.WriteLine("\nO número sorteado era: " + numeroAleatorio);
        break;
    }
    else if (numeroEscolhidoConv == numeroAleatorio)
    {
        Console.WriteLine("\nParabéns!!! Você acertou! :D");
        break;
    }
    else if (numeroProximo1 > 0 && numeroProximo1 < 2)
    {
        Console.WriteLine("\nO número sorteado está muito perto!");
    }
    else if (numeroProximo2 > 0 && numeroProximo2 < 2)
    {
        Console.WriteLine("\nO número sorteado está muito perto!");
    }
    else if (numeroProximo1 > 0 && numeroProximo1 < 5)
    {
        Console.WriteLine("\nQuase lá!");
    }
    else if (numeroProximo2 > 0 && numeroProximo2 < 5)
    {
        Console.WriteLine("\nQuase lá!");
    }
    else if (numeroProximo1 > 0 && numeroProximo1 < 10)
    {
        Console.WriteLine("\nO número sorteado está próximo!");
    }
    else if (numeroProximo2 > 0 && numeroProximo2 < 10)
    {
        Console.WriteLine("\nO número sorteado está próximo!");
    }
    else if (numeroEscolhidoConv < numeroAleatorio)
    {
        Console.WriteLine("\nO número sorteado é maior!");
    }
    else
    {
        Console.WriteLine("\nO número sorteado é menor!");
    }
} while (true);











