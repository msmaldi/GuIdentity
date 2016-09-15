using Xunit;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore.Test
{
	public class GuIdentityEntityFrameworkBuilderExtensionsTest
	{
		[Fact]
		public void EnsureGetManagers()
		{
			var services = new ServiceCollection();
			services.AddDbContext<InMemoryGuIdentityDbContext>();
			services.AddIdentity<GuIdentityUser, GuIdentityRole>()
					.AddEntityFrameworkGuidStores<InMemoryGuIdentityDbContext>()
                	.AddDefaultTokenProviders();
			var userManager = services.BuildServiceProvider()
							   		.GetRequiredService<UserManager<GuIdentityUser>>();

			var signInManager = services.BuildServiceProvider()
									.GetRequiredService<SignInManager<GuIdentityUser>>();
			
			Assert.NotNull(userManager);
			Assert.NotNull(signInManager);			
		}
	}
}