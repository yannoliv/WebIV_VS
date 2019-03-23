using MuziekInVlaanderen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderenAPI.Data
{
    public class EvenementenDataInitializer
    {

        private readonly ApplicationDbContext _dbContext;

        public EvenementenDataInitializer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void InitializeData()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                //seeding the database with Evenements, see DBContext               
            }
        }
    }
}
