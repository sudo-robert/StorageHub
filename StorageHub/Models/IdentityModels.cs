﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace StorageHub.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Email { get; set; }
        public virtual ICollection<StorageService> StorageServices { get; set; }
    }   
}