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
    public class PieService : IPieRepository
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public PieService(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
         }
        public IEnumerable<Pie> AllPies => _applicationDBContext.Pies.Include(x=>x.Category);

        public IEnumerable<Pie> PiesOfTheWeek => _applicationDBContext.Pies.Include(x => x.Category).Where(p=>p.IsPieOfTheWeek);

        public Pie GetById(int id) => _applicationDBContext.Pies.FirstOrDefault(p => p.Id == id);
    }
}
