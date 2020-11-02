using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public interface IHuntingService
    {
        object GetAnimalToHunt(int minNumber);
    }
    public class HuntingService : IHuntingService
    {
        
    }
}
