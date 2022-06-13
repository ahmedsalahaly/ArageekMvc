using ArageekMvc.Models;

namespace ArageekMvc.Repository
{
    public interface IArticalRepository : IGenericCRUD<Artical>, IValidation<Artical>
    {
    }
}
