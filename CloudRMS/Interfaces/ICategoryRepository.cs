
using CloudRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.Interfaces
{
  public  interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
