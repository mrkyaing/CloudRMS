using Microsoft.AspNetCore.Identity;
using System;

namespace WebApp.Data {
    public class AppRole : IdentityRole {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IPAddress { get; set; }
    }
}
