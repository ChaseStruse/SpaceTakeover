using SpaceTakeover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class PlayerService
    {
        public bool ReduceStamina(Player player, int timeSpent)
        {
            bool success = true;

            if(timeSpent >= 1 && timeSpent <= 2 && player.stamina >= 25)
            {
                player.stamina -= 25;
            }
            else if(timeSpent >= 3 && timeSpent <= 5 && player.stamina >= 50)
            {
                player.stamina -= 50;
            }
            else if (timeSpent >= 6 && timeSpent <= 7 && player.stamina >= 75)
            {
                player.stamina -= 75;
            }
            else if (timeSpent == 8 && player.stamina == 100)
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
