using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} kampanyası %{campaign.Percantage}'lik olarak eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} adlı kampanya silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} adlı kampanya güncellenmiştir.");
        }
    }
}
