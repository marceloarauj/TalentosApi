using System.Collections.Generic;
using System.Linq;
using api.Models.EntityModel.Searches;
using Microsoft.EntityFrameworkCore;
using Talentos.API.Data;

namespace api.Repository
{
    public class SearchRepository : ISearchRepository
    {
        private readonly Context _context;

        public SearchRepository(Context context)
        {
            _context = context;
        }

        public void Add(Search search)
        {
            _context.Add(search);
            _context.SaveChanges();
        }

        public void AddRange(ICollection<Search> searches)
        {
            _context.AddRange(searches);
            _context.SaveChanges();
        }

        /*
        public Pesquisa Find(long id)
        {
            return _context.Pesquisas.FirstOrDefault(s => s.IdCabecalho == id);
        }
        */
        public IEnumerable<Search> GetAll()
        {
            var searches = _context.Searches
            .Include(p => p.User)
            .Include(p => p.Sport);

            return searches.ToList();
        }

        public IEnumerable<Search> GetAllPesquisas(long userId)
        {

            var searches = _context.Searches
            .Include(p => p.User)
            .Include(p => p.Sport)
            .Where(p => p.UserId == userId);

            return searches.ToList();
        }

        public void Remove(long id)
        {
            var search = _context.Searches.First(s => s.UserId == id);
            _context.Remove(search);
            _context.SaveChanges();
        }

        public void Update(Search search)
        {
            _context.Searches.Update(search);
            _context.SaveChanges();
        }
    }
}