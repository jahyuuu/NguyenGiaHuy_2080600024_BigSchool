using System.ComponentModel.DataAnnotations;

namespace NguyenGiaHuy_2080600024_BigSchool.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}