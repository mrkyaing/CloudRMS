using CloudRMS.DAO;
using CloudRMS.Interfaces;
using CloudRMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDBContext _applicationDBContext;

        public CategoryRepository(ApplicationDBContext applicationDBContext)
        {
            this._applicationDBContext = applicationDBContext;
        }
        public IEnumerable<Category> AllCategories => _applicationDBContext.Categories.ToList();
    }
}
