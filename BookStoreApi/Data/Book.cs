using System.ComponentModel.DataAnnotations;
namespace BookStoreApi.Data
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please add title")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
