using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore
{
	public class GuIdentityDbContext : GuIdentityDbContext<GuIdentityUser>
	{		
		public GuIdentityDbContext(DbContextOptions options) : base(options)
		{			
		}

		protected GuIdentityDbContext()
		{			
		}
	}
	public class GuIdentityDbContext<TUser> : IdentityDbContext<TUser, GuIdentityRole, Guid> where TUser : GuIdentityUser
	{
		public GuIdentityDbContext(DbContextOptions options) : base(options)
		{			
		}

		protected GuIdentityDbContext()
		{			
		}
	}
}