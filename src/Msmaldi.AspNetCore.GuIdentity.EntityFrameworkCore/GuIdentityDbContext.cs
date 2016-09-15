using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore
{
	public class GuIdentityDbContext : GuIdentityDbContext<GuIdentityUser>
	{		
		public GuIdentityDbContext(DbContextOptions options) : base(options)
		{ }

		protected GuIdentityDbContext()
		{ }
	}
	
	public class GuIdentityDbContext<TUser> : GuIdentityDbContext<TUser, GuIdentityRole>
		where TUser : GuIdentityUser
	{		
		public GuIdentityDbContext(DbContextOptions options) : base(options)
		{ }

		protected GuIdentityDbContext()
		{ }
	}

	public class GuIdentityDbContext<TUser, TRole> : IdentityDbContext<TUser, TRole, Guid>
		where TUser : GuIdentityUser
		where TRole : GuIdentityRole
	{
		public GuIdentityDbContext(DbContextOptions options) : base(options)
		{ }

		protected GuIdentityDbContext()
		{ }
	}
}