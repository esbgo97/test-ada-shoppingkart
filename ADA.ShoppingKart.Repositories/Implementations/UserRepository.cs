using Microsoft.EntityFrameworkCore;

using ADA.ShoppingKart.Database;
using ADA.ShoppingKart.Models.Entities;
using ADA.ShoppingKart.Repositories.Interfaces;

namespace ADA.ShoppingKart.Repositories.Implementations
{
    
    public class UserRepository : IUserRepository
    {
        private ShoppingKartDBContext _context;
        public UserRepository(DbContext context)
        {
            _context = (ShoppingKartDBContext)context;
        }
        public Task<bool> Add(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll(User entity)
        {
            return _context.Users.ToListAsync();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
