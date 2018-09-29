using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerBackend.Models
{
    public class User
    {
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("E-mail Address")]
        public string Email { get; set; }
        [DisplayName("Field")]
        public string Field { get; set; }

    }
}
