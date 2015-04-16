using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BookManager.Models
{
    public class Books
    {
        [ScaffoldColumn(false)]
        [Key]
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
    }
}