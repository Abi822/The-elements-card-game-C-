using System;

namespace The_elements_card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            string[] elementstring = "fire/wind/earth/water".Split('/');
            Random rnd = new Random();
            string player1_c1 = elementstring[rnd.Next(elementstring.Length)]; string player1_c2 = elementstring[rnd.Next(elementstring.Length)];
            string player2_c1 = elementstring[rnd.Next(elementstring.Length)]; string player2_c2 = elementstring[rnd.Next(elementstring.Length)];

            Console.WriteLine("*---------PLAYER 1 TURN ---------*");
            Console.WriteLine("Player 1: Your cards:\n" + player1_c1 + " + " + player1_c2); 
            

            if (player1_c1 == player1_c2)
            {
                Console.WriteLine("Luckey! double up!");
                string player1_c3 = elementstring[rnd.Next(elementstring.Length)];
                Console.WriteLine("\n" + player1_c1 + " + " + player1_c2 + " + " + player1_c3);
                Console.WriteLine("--------------------");
            }
            Console.ReadKey();

            Console.WriteLine("\n*---------PLAYER 2 TURN ---------*");
            Console.WriteLine("Player 2: Your cards:\n" + player2_c1 + " + " + player2_c2);

            if (player2_c1 == player2_c2)
            {
                Console.WriteLine("Luckey! double up!");
                string player2_c3 = elementstring[rnd.Next(elementstring.Length)];
                Console.WriteLine("\n" + player2_c1 + " + " + player2_c2 + " + " + player2_c3);
                Console.WriteLine("--------------------");
            }

            Console.ReadLine();
        }
    }
}
