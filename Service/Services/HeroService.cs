using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Services
{
    using Models;

    public class HeroService
    {
        public HeroService() { }

        public IEnumerable<HeroModel> GetHeroes()
        {
            var heroes = new List<HeroModel>()
            {
                new HeroModel { Id = 11, Name = "Mr. Nice" },
                new HeroModel { Id = 12, Name = "Narco" },
                new HeroModel { Id = 13, Name = "Bombasto" },
                new HeroModel { Id = 14, Name = "Celeritas" },
                new HeroModel { Id = 15, Name = "Magneta" },
                new HeroModel { Id = 16, Name = "RubberMan" },
                new HeroModel { Id = 17, Name = "Dynama" },
                new HeroModel { Id = 18, Name = "Dr IQ" },
                new HeroModel { Id = 19, Name = "Magma" },
                new HeroModel { Id = 20, Name = "Tornado" }
            };

            return heroes;
        }
    }
}
