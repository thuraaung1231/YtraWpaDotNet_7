using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDTO.Model
{
    public class AuthorEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string photo {  get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public bool is_delete { get; set; }

    }
}
