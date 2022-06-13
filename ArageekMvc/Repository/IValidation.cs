namespace ArageekMvc.Repository
{
    public interface IValidation
    {
        public interface IValidation<T> where T : class
        {
            bool IsExist(T entity);
            bool IsExistById(int Id);
        }
    }
}
