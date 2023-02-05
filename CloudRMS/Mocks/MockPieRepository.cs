using CloudRMS.Interfaces;
using CloudRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.Mocks
{
    public class MockPieRepository : IPieRepository
    {
        //to activate this _categoryRepository,plz inject in StartUp.cs
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie{Id=1,Name=" Cheese Cake1",ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg"},
            new Pie{Id=2,Name=" Strawberry Cake2"},
            new Pie{Id=3,Name=" Orange Cake3"},
           new Pie{Id=4,Name=" Apple Cake4"},
            new Pie{Id=11,Name=" Cheese Cake5"},
            new Pie{Id=12,Name=" Strawberry Cake6"},
            new Pie{Id=13,Name=" Orange Cake7"},
           new Pie{Id=14,Name=" Apple Cake8"},
            new Pie{Id=21,Name=" Cheese Cake9"},
            new Pie{Id=22,Name=" Strawberry Cake10"},
            new Pie{Id=33,Name=" Orange Cake11"},
           new Pie{Id=44,Name=" Apple Cake12"}
        };

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie GetById(int id)
        {
            return AllPies.FirstOrDefault(p => p.Id == id);
        }
    }
}
