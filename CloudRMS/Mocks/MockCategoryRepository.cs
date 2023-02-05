
using CloudRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.Interfaces
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category> {
            new Category(){Id=1,Name="fruit pies"},
            new Category(){Id=2,Name="food pies"}
            };
    }
}
