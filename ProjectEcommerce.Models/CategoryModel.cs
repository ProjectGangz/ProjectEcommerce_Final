using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectEcommerce.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoeyID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        [Required]
        [MaxLength(3000)]
        [DisplayName("Category Discription")]
        public string CategoryDescription { get; set; }
        [Range(1,100,ErrorMessage ="Display Order must be between 1 - 100")]
        [DisplayName("Display Order")]
        public int DisplayOrder {  get; set; }
    }
}
