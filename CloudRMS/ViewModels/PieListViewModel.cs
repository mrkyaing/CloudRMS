using CloudRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> pies{ get; set; }
        public string CurrentCategory { get; set; }
    }
}
