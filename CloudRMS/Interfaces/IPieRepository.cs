
using CloudRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.Interfaces
{
   public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetById(int id);
    }
}
