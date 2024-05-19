using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDTO.Model
{
    public class BookEntity
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string coverPhoto { get; set; }
        [Required]
        public string bookType { get; set; }
        [Required]
        public string description { get; set; }
        public int author_id { get; set; }
        public DateTime created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool is_delete { get; set; }
    }
}
