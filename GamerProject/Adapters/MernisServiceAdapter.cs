using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if(gamer.FirstName =="Batuhan" && gamer.LastName=="Güner" && gamer.NationalityId=="14725836912" && gamer.DateBirth==new DateTime(1997, 2, 23))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
