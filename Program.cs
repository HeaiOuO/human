using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            human player1 = new human("player1");
            human player2 = new human("player2");

            player1.attack(player2);
            Console.WriteLine(player2.ToString());
            Console.WriteLine(player1.ToString());
            player1.attack("sss");
        }
    }
}
