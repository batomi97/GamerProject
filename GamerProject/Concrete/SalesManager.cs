using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class SalesManager : IGameSales
    {
        public void CampaignToSell(Game game, Campaign campaign, bool checkCampaign)
        {
            if (checkCampaign)
            {
                Console.WriteLine($"{game.Name} oyunu kampanyalı olarak satıldı. {game.Price} fiyatından %{campaign.Percantage} indirim uygulanmıştır");
            }
            else
            {
                Console.WriteLine($"{game.Name} oyunu kampanyasız olarak satıldı.");
            }
        }

        public void ToSell(Gamer gamer, Game game)
        {
            Console.WriteLine("Succes to sell game : " + game.Name + " by " + gamer.FirstName);
        }
    }
}
