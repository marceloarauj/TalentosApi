using System.Collections.Generic;
using api.Models.EntityModel.Users;

namespace api.Repository
{
    public interface IUserRepository
    {
        void Add(User cabecalho);

        IEnumerable<User> GetAll();

        User Find(long id);

        void Remove(long id);

        void Update(User cabecalho);
    }
}