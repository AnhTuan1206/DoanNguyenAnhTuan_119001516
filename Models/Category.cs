using System.ComponentModel.DataAnnotations;
namespace DoanNguyenAnhTuan.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public List<News> News { get; set; }
    }
}








