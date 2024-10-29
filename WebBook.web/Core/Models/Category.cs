using System.ComponentModel.DataAnnotations;

namespace WebBook.web.Core.Models
{
	public class Category
	{
       
        [Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }
		public bool IsDeleted { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
		public DateTime? UpdateOn { get; set; }
		

	}
}
