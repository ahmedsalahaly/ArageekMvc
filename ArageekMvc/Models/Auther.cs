using ArageekMvc.Bases;

namespace ArageekMvc.Models
{
    public class Auther: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Artical> articals { get; set; }
    }
}
