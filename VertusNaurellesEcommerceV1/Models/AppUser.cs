using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VertusNaurellesEcommerceV1.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
       
        public string Address { get; set; }
      
        public string City { get; set; }
        
        public int CodeZip { get; set; }
    
        public string Country { get; set; }
    }
}
