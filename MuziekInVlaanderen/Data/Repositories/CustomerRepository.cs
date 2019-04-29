using Microsoft.EntityFrameworkCore;
using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Customer> _customers;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _customers = dbContext.Customers;
        }

        public Customer GetBy(string email)
        {
            return _customers
                .Include(x => x.FavoriteEvenementen)
                .Include(c => c.Favorites)
                    .ThenInclude(f => f.Evenement)
                        .ThenInclude(e => e.Gallerij)
                            .ThenInclude(g => g.Fotograaf)
                .Include(c => c.Favorites)
                    .ThenInclude(f => f.Evenement)
                        .ThenInclude(e => e.Locatie)
                .Include(c => c.Favorites)
                    .ThenInclude(f => f.Evenement)
                        .ThenInclude(e => e.Moment)
                .SingleOrDefault(c => c.Email == email);
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
