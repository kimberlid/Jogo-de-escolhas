// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int alvo = random.Next(1, 20); // Escolhe o alvo aleatoriamente entre 1 e 20
        int soma = alvo;

        Console.WriteLine("Bem-vindo ao jogo!");
        Console.WriteLine("Tente adivinhar o alvo escolhido (um numero entre 1 e 20).");

        while (soma <= 100)
        {
            Console.Write("Digite o seu palpite: ");
            int palpite;

            // Verifica se o palpite é um número válido entre 1 e 20
            while (!int.TryParse(Console.ReadLine(), out palpite) || palpite < 1 || palpite > 20)
            {
                Console.WriteLine("Numero invalido.");
                Console.Write("Digite o seu palpite: ");
            }

            Console.WriteLine($"Numero sorteado: {alvo}");
            Console.WriteLine($"Seu palpite: {palpite}");

            if (palpite == alvo)
            {
                Console.WriteLine("Parabens! Voce acertou.");
                break;
            }
            else
            {
                soma += palpite;

                if (soma > 100)
                {
                    Console.WriteLine("Voce ultrapassou o valor 100. O computador venceu!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Você errou.");
                    alvo = random.Next(1, 20);
                }
            }
        }
    }
}

