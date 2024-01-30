using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = "";
        
        // navigation prop
        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }

    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string Name { get; set; } = "";
        public int CategoryId { get; set; }

        // navigation prop
        public Category Category { get; set; } = new Category();
        public Book Book { get; set; } = new Book();

    }
}
