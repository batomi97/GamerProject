using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted : " + gamer.FirstName + " " + gamer.LastName);
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer is saved : " + gamer.FirstName + " " + gamer.LastName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
