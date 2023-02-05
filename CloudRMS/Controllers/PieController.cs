using CloudRMS.Interfaces;
using CloudRMS.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.Controllers
{
    [Authorize]
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepositry;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepositry, ICategoryRepository categoryRepository)
        {
            _pieRepositry = pieRepositry;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(){
            var pies = new PieListViewModel()
            {
pies=_pieRepositry.AllPies,
CurrentCategory="Cakes"
            };
          return  View(pies);
    }
   
    }
}
