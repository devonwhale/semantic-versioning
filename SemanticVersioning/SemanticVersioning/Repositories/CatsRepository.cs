using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SemanticVersioning.Models;

namespace SemanticVersioning.Repositories
{
    public class CatsRepository
    {
        private static readonly List<Cat> LoadCatsFromDatabase = new List<Cat>
        {
            new Cat { Name = "Pickles", Description = "A loving Tabby who enjoys a good scratch behind the ear." , Age = 3},
            new Cat { Name = "Larry", Description = "Chief Mouser to the Cabinet Office." , Age = 13},
            new Cat { Name = "Mr Meow", Description = "Meow meow meow." , Age = 7},
            new Cat { Name = "Matilda", Description = "Might need the occasional reminder that you shouldn't scratch the sofa." , Age = 2},
            new Cat { Name = "Ace", Description = "A wicked cat!" , Age = 9},
            new Cat { Name = "Pickles", Description = "The younger sister of Pickles." , Age = 1}
        };

        public List<Cat> GetCats()
        {
            return LoadCatsFromDatabase;
        }

        public Cat GetCat(string catName)
        {
            var cats = LoadCatsFromDatabase;

            var cat = cats.Where(c => c.Name.ToLower() == catName.ToLower()).First();

            Random rdm = new Random();

            if (rdm.Next(3) > 1)
                cat = new Cat { Name = "Debug Cat", Description = "This is to aid testing", Age = 10000 };

            return cat;
        }
    }
}
