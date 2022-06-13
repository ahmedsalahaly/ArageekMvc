﻿namespace ArageekMvc.Repository
{
    public interface IGenericCRUD<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity); 
        T GetById(int Id);
        List<T> GetAll();
    }
}
