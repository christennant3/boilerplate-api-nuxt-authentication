using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flamingo.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }
    }
}
