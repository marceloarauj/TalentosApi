using System.Collections.Generic;
using api.Models.EntityModel.Searches;

namespace api.Repository
{
    public interface ISearchRepository
    {
        void Add(Search search);

        void AddRange(ICollection<Search> searches);

        IEnumerable<Search> GetAll();

        IEnumerable<Search> GetAllPesquisas(long UserId);

        void Remove(long id);

        void Update(Search search);
    }
}