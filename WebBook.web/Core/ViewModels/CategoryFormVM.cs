
namespace WebBook.web.Core.ViewModels
{
    public class CategoryFormVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

       
    }
}
