using ADA.ShoppingKart.Models.Entities;
using ADA.ShoppingKart.Business.Interfaces;
using ADA.ShoppingKart.Repositories.Interfaces;

namespace ADA.ShoppingKart.Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        private IUserRepository _repository;
        public UserBusiness(IUserRepository repository)
        {
            _repository = repository;
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
            return _repository.GetAll(entity);
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
