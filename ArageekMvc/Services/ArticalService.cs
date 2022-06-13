using ArageekMvc.Data;
using ArageekMvc.Models ;
using ArageekMvc.Repository;
using Microsoft.EntityFrameworkCore;

namespace ArageekMvc.Services
{
    public class ArticalService : IArticalRepository
    {
        private readonly ApplicationDbContext dbContext;
        public ArticalService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext; 
        }

        public void Add(Artical entity)
        {
            if (!IsExist(entity))
            {
                dbContext.articals.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(Artical entity)
        {
            if (IsExistById(entity.Id))
            {
                dbContext.articals.Remove(GetById(entity.Id));
                dbContext.SaveChanges();
            }
        }

        public List<Artical> GetAll()
        {
            return dbContext.articals.Include(x=>x.auther).ToList();
        }

        public Artical GetById(int ID)
        {
            if (IsExistById(ID))
            {
                return dbContext.articals.Where(x => x.Id == ID).SingleOrDefault();
            }
            return null;
        }

        public bool IsExist(Artical entity)
        {
            if (!IsExistById(entity.Id))
            {
                return dbContext.articals.Any(x => x.Id == entity.Id);
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
            if (IsExist(entity))
            {
                Artical oldArtical = GetById(entity.Id);
                oldArtical.Title = entity.Title;
                dbContext.articals.Update(oldArtical);
                dbContext.SaveChanges();
            }
        }
    }
}
