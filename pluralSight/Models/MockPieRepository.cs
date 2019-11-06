using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pluralSight.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name = "Strawberry Pie", Price = 15.99M, ShortDescription = "Lovely"},
                new Pie {PieId = 2, Name = "Cheese cake", Price = 11.99M, ShortDescription = "Amazing"},
                new Pie {PieId = 3, Name = "Rhubarb Pie", Price = 12.99M, ShortDescription = "Incredible"},
                new Pie {PieId = 4, Name = "Pumpkin Pie", Price = 10.99M, ShortDescription = "Yo yo madafaka"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
