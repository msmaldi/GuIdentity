using Xunit;
using System;
using Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore.Test
{
	public class GuIdentityDbContextTest
	{
		[Fact]
		public void CanCreateUser()
		{
			using (var db = new InMemoryGuIdentityDbContext())
			{
				db.Users.Add(new GuIdentityUser { UserName = "msmaldi" });
				var result = db.SaveChanges();
				Assert.Equal(1, result);
			};
		}

		[Fact]
		public void CanCreateRole()
		{
			using (var db = new InMemoryGuIdentityDbContext())
			{
				db.Roles.Add(new GuIdentityRole("Administrator"));
				var result = db.SaveChanges();
				Assert.Equal(1, result);
			};
		}
	}

	public class InMemoryGuIdentityDbContext : GuIdentityDbContext
	{
		public InMemoryGuIdentityDbContext() : base()
		{ }	

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }	
	}
}