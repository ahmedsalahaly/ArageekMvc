using ArageekMvc.Data;
using ArageekMvc.Data.Migrations;
using ArageekMvc.Repository;
using static ArageekMvc.Repository.IValidation;

namespace ArageekMvc.Services
{
    public class ArticalService : IGenericCRUD<Artical>,IValidation<Artical>
    {
        private readonly ApplicationDbContext dbContext;
        public ArticalService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext; 
        }

        public void Add(Artical entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Artical entity)
        {
            throw new NotImplementedException();
        }

        public List<Artical> GetAll()
        {
            return dbContext.articals.ToList();
        }

        public Artical GetById(int ID)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(Artical entity)
        {
            if (!IsExistById(entity.ID))
            {
                return dbContext.articals.Any(x => x.Id == Id);
            }
            else
            {
                return true;
            }
        }

        public bool IsExistById(int ID)
        {
            return dbContext.articals.Any(x => x.Id==ID);
        }

        public void Update(Artical entity)
        {
            throw new NotImplementedException();
        }
    }
}
