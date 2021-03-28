using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public interface IGameSales
    {
        void ToSell(Gamer gamer, Game game);
        void CampaignToSell(Game game, Campaign campaign, bool checkCampaign);
    }
}
