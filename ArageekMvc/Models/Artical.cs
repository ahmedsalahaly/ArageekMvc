using ArageekMvc.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArageekMvc.Models
{
    public class Artical: BaseEntity
    {
        public string Title { get; set; }
        public int AutherId { get; set; }
        public string ImageURL { get; set; }
        [ForeignKey("AutherId")]
        public Auther auther { get; set; }
    }
}
