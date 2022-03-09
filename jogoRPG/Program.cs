using System;
using jogoRPG.SRC.Entities;

namespace jogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",72,"Knight", 749, 72);
            Wizard jennica = new Wizard("Jennica",72,"White Wizard", 601, 482);
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641);
            Ninja wedge = new Ninja("Wedge",42,"Ninja",574,89);
            
            Console.WriteLine("Jogador 1, digite o nome do seu personagem: \n1-Arus  2-Jennica  3-Topapa  4-Wedge");
            var jogador1 = Console.ReadLine();
            Console.WriteLine("Jogador 2, digite o nome do seu personagem: \n1-Arus  2-Jennica  3-Topapa  4-Wedge");
            var jogador2 = Console.ReadLine();
            Console.WriteLine("\nOs jogadores escolhidos foram "+ jogador1 + " e "+ jogador2 + "\n\nEstão prontos para Batalha? \nComeçou! \n\n");
            
            // Exemplo Batalha Arus x Wedge
            Console.WriteLine($"Batalha: {arus} x {wedge} " );
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack(3));
            Console.WriteLine(arus.Attack(8));
            Console.WriteLine(wedge.Attack(10));
            Console.WriteLine(arus.Attack(15));
        }
    }
}
