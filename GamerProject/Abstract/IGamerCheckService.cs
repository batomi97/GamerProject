using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
