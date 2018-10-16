using System;
using System.Collections.Generic;
using System.Text;
using GuIdentitySample.Mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore;

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
