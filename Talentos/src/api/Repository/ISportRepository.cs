using System.Collections.Generic;
using api.Models.EntityModel.Sports;

namespace api.Repository
{
    public interface ISportRepository
    {
        void Add(Sport sport);

        void AddRange(ICollection<Sport> sports);

        IEnumerable<Sport> GetAll();

        Sport Find(long id);

        void Remove(long id);

        void Update(Sport sport);
    }
}