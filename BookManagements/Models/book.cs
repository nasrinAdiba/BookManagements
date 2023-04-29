using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BookManagements.Models
{
    public class book
    {

        public int Id { get; set; }
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }
        [Display(Name = "Publisher Age")]
        public int PublisherAge { get; set; }
        [Display(Name = "Page Number")]
        public int PageNumber { get; set; }
        [Display(Name = "Published Date")]
        public DateTime PublishDate { get; set; }
        public string Type { get; set; }
    }
}
