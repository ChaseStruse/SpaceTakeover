using SpaceTakeover.DAL.Models;
using SpaceTakeover.Data.Services;
using System;

namespace SpaceTakeover
{
    class Program
    {
        static void Main(string[] args)
        {
            IInventoryService inventoryService = new InventoryService();
            IResourceService resourceService = new ResourceService();
            IPlayerService playerService = new PlayerService();

            Player player = new Player();

            // Game Loop
            Console.WriteLine("Please enter Character Name: ");
            player.Name = Console.ReadLine();
            bool playing = true;
            bool isAwake = true;
            int days = 0;
            while (playing == true)
            {
                player.Stamina = 100;
                days++;
                Console.WriteLine($"START OF DAY {days}");
                while (isAwake)
                {
                    if (player.Stamina == 0)
                    {
                        Console.WriteLine($"Stamina has been depleted, {player.Name} its time to go to bed!");
                        isAwake = false;
                    }
                    else
                    {
                        DisplayPlayerMenu();
                        var playerChoice = Console.ReadLine();

                        if (playerChoice != "4" && playerChoice != "9")
                        {
                            GetTotalHoursToSpendOnTask(player);
                        }
                        if (playerService.ReduceStamina(player))
                        {
                            if (playerChoice == "1")
                            {
                                Mine(resourceService, player, inventoryService);
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
                        else
                        {
                            Console.WriteLine($"You do not have enough stamina, current stamina is {player.Stamina}");
                        }
                    }
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
            player.TimeToSpendOnTask = int.Parse(hours);
        }

        private static void Mine(IResourceService resourceService, Player player, IInventoryService inventoryService)
        {
            var randomNumberToDetermineResource = new Random().Next(0, 100);
            Resource resourceRetrieved = resourceService.Mine(player, randomNumberToDetermineResource);
            inventoryService.AddResourceToInventory(player.Inventory, resourceRetrieved);
        }
    }
}
