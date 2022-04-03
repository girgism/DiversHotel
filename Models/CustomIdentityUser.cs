using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Models
{
    public class CustomIdentityUser : IdentityUser
    {
    
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
