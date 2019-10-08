using System;
using System.Collections.Generic;
using System.Linq;
using api.Models.EntityModel.Users;
using Talentos.API.Data;

namespace api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        
        public UserRepository(Context context)
        {
            _context = context;    
        }

        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public User Find(long id)
        {
            return _context.Users.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Remove(long id)
        {
            var user = _context.Users.First(s => s.Id == id);
            _context.Remove(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}