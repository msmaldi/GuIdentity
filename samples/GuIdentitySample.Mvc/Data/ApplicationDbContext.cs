using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore;
using GuIdentitySample.Mvc.Models;

namespace GuIdentitySample.Mvc.Data
{
    public class ApplicationDbContext : GuIdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
