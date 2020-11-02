using SpaceTakeover.DAL.Models;
namespace SpaceTakeover.Data.Services
{
    public interface IPlayerService
    {
        bool ReduceStamina(Player player);
    }
    public class PlayerService : IPlayerService
    {
        public bool ReduceStamina(Player player)
        {
            bool success = true;
            int timeToSpend = player.TimeToSpendOnTask;

            if (timeToSpend >= 1 && timeToSpend <= 2 && player.Stamina >= 25)
            {
                player.Stamina -= 25;
            }
            else if(timeToSpend >= 3 && timeToSpend <= 5 && player.Stamina >= 50)
            {
                player.Stamina -= 50;
            }
            else if (timeToSpend >= 6 && timeToSpend <= 7 && player.Stamina >= 75)
            {
                player.Stamina -= 75;
            }
            else if (timeToSpend == 8 && player.Stamina == 100)
            {
                player.Stamina -= 100;
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}
