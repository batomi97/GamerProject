using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percantage { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
