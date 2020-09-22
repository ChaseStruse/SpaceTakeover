using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;
using System;

namespace SpaceTakeover
{
    class Program
    {
        private PlayerService playerService = new PlayerService();

        static void Main(string[] args)
        {
          
            // Game Loop
            Player player = new Player();
            Console.WriteLine("Please enter Character Name: ");
            player.name = Console.ReadLine();
            bool playing = true;
            bool isAwake = true;

            int days = 0;
            while(playing == true)
            {
                while (isAwake)
                {
                    days++;
                    Console.WriteLine("Good Morning " + player.name + " lets start the day!");
                    Console.WriteLine("1 - Go Mining \n" +
                                      "2 - Go Hunting \n" +
                                      "3 - Exercise \n" +
                                      "9 - View Player Stats and Inventory"
                                      );
                   
                }
            }

        }
    }
}
