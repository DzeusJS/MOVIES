using MOVIES.Models;

namespace MOVIES.DATA.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAllActors();
        Actor GetById(int id);
        void Add(Actor actor);
        void Delete(int id);

        Actor Update(int id, Actor newActor);
    }
}
