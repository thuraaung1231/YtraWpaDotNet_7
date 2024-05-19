using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDTO.Model
{
    public class AuthorEntity
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [StringLength(11,ErrorMessage = "Invalid Phone Number", MinimumLength = 11)]
        public string phoneNumber { get; set; }
        public string photo {  get; set; }
        public DateTime created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public bool is_delete { get; set; }

    }
}
