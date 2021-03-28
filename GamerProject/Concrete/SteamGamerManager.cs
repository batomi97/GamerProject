using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class SteamGamerManager : BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;

        public SteamGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                Console.WriteLine("Not a valid gamer!");
            }
        }

        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);
        }

        public override void Update(Gamer gamer)
        {
            base.Update(gamer);
        }
    }
}
