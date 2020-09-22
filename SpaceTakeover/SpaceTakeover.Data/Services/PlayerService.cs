using SpaceTakeover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class PlayerService
    {
        public bool ReduceStamina(Player player)
        {
            bool success = true;
            int timeToSpend = player.timeToSpendOnTask;

            if (timeToSpend >= 1 && timeToSpend <= 2 && player.stamina >= 25)
            {
                player.stamina -= 25;
            }
            else if(timeToSpend >= 3 && timeToSpend <= 5 && player.stamina >= 50)
            {
                player.stamina -= 50;
            }
            else if (timeToSpend >= 6 && timeToSpend <= 7 && player.stamina >= 75)
            {
                player.stamina -= 75;
            }
            else if (timeToSpend == 8 && player.stamina == 100)
            {
                player.stamina -= 100;
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
