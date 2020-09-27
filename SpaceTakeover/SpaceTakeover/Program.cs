using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;
using System;

namespace SpaceTakeover
{
    class Program
    {
        static void Main(string[] args)
        {

            // Game Loop
            Player player = new Player();

            InventoryService inventoryService = new InventoryService();
            ResourceService resourceService = new ResourceService();
            Console.WriteLine("Please enter Character Name: ");
            player.name = Console.ReadLine();
            bool playing = true;
            bool isAwake = true;

            int days = 0;
            while (playing == true)
            {
                player.stamina = 100;
                days++;
                while (isAwake)
                {
                    Console.WriteLine("Good Morning " + player.name + " lets start the day!");
                    Console.WriteLine("1 - Go Mining \n" +
                                      "2 - Go Hunting \n" +
                                      "3 - Exercise \n" +
                                      "4 - View Player Stats and Inventory \n" +
                                      "9 - Exit \n"
                                      );
                    var playerChoice = Console.ReadLine();

                    Console.WriteLine("How long would you like to do the activity? 1 - 8 hours");
                    var hours = Console.ReadLine();
                    player.timeToSpendOnTask = int.Parse(hours);
                    if (playerChoice == "1")
                    {
                        Resource resourceRetrieved = resourceService.mine(player, player.timeToSpendOnTask);
                        inventoryService.AddResourceToInventory(player.inventory, resourceRetrieved);
                    }
                    else if (playerChoice == "2") Console.WriteLine("Not implemented");
                    else if (playerChoice == "3") Console.WriteLine("Not implemented");
                    else if (playerChoice == "4") Console.WriteLine("Not implemented");
                    else if (playerChoice == "9") isAwake = false;
                }
            }

        }
    }
}
