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
                    if (player.stamina == 0) Console.WriteLine("Stamina has been depleted");
                    DisplayPlayerMenu();
                    var playerChoice = Console.ReadLine();

                    if (playerChoice != "4" && playerChoice != "9") GetTotalHoursToSpendOnTask(player);

                    if (playerChoice == "1")
                    {
                        Resource resourceRetrieved = resourceService.Mine(player);
                        inventoryService.AddResourceToInventory(player.inventory, resourceRetrieved);
                    }
                    else if (playerChoice == "2") Console.WriteLine("Not implemented");
                    else if (playerChoice == "3") Console.WriteLine("Not implemented");
                    else if (playerChoice == "4") inventoryService.DisplayInventory(player);
                    else if (playerChoice == "9")
                    {
                        Console.WriteLine("Stamina has been replenished");
                        isAwake = false;
                    }
                    Console.WriteLine("");

                }
                isAwake = true;
            }

        }

        private static void DisplayPlayerMenu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Choose from the list of activities     |");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| 1 - Go Mining                          |\n" +
                              "| 2 - Go Hunting                         |\n" +
                              "| 3 - Exercise                           |\n" +
                              "| 4 - View Player Stats and Inventory    |\n" +
                              "| 9 - Sleep                              |\n");
            Console.WriteLine("------------------------------------------");
        }

        private static void GetTotalHoursToSpendOnTask(Player player)
        {
            Console.WriteLine("How long would you like to do the activity? 1 - 8 hours");
            var hours = Console.ReadLine();
            player.timeToSpendOnTask = int.Parse(hours);
        }
    }
}
