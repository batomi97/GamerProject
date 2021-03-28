using GamerProject.Abstract;
using GamerProject.Entities;
using GamerProject.Concrete;
using GamerProject.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerService = new SteamGamerManager(new MernisServiceAdapter());
            gamerService.Save(new Gamer { Id = 1, FirstName = "Batuhan", LastName = "Güner", NationalityId = "14725836912", DateBirth = new DateTime(1997, 2, 23) });

            IGameSales gameSales = new SalesManager();
            gameSales.ToSell(new Gamer { FirstName = "Batuhan" }, new Game { Id = 1, Name = "Call Of Duty", Category = "Action", Price = 125.50 });

            ICampaingService campaingService = new CampaingManager();
            campaingService.Add(new Campaign { Id = 1, Name = "Yaza Mücde", ExpireDate = new DateTime(2021, 4, 5), Percantage = 25 });

            IGameSales gameSales1 = new SalesManager();
            gameSales1.CampaignToSell(new Game { Name = "Call Of Duty", Price = 125.50 }, new Campaign { Name = "Yaza Mücde", Percantage = 25 }, true);

            Console.ReadLine();
        }
    }
}
