using System.ComponentModel.DataAnnotations;
namespace BookStoreApi.Model
{
    public class BookDto
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
