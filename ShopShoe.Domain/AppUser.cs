using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopShoe.Domain
{
    public class AppUser:IdentityUser<int>
    {
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
    }
}
