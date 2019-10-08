using System.Collections.Generic;
using System.Linq;
using api.Models.EntityModel.Sports;
using Talentos.API.Data;

namespace api.Repository
{
    public class SportRepository : ISportRepository
    {
        private readonly Context _context;
        
        public SportRepository(Context context)
        {
            _context = context;    
        }

        public void Add(Sport sport)
        {
            _context.Add(sport);
            _context.SaveChanges();
        }

 
        public void AddRange(ICollection<Sport> sports)
        {
            _context.AddRange(sports);
            _context.SaveChanges();
        }
 
        public Sport Find(long id)
        {
            return _context.Sports.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Sport> GetAll()
        {
            return _context.Sports.ToList();
        }

        public void Remove(long id)
        {
            var sport = _context.Sports.First(s => s.Id == id);
            _context.Remove(sport);
            _context.SaveChanges();
        }

        public void Update(Sport sport)
        {
            _context.Sports.Update(sport);
            _context.SaveChanges();
        }
    }
}