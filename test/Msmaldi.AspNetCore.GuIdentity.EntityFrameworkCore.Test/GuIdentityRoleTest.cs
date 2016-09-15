using Xunit;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore.Test
{
	public class GuIdentityRoleTest
	{
		[Fact]
		public void EnsureGuIdentityRoleIdIsGuid()
		{
			var role = new GuIdentityRole();
			var typeOfId = role.Id.GetType();
			Assert.Equal(typeof(Guid), typeOfId);
		}
		
		[Fact]
		public void EnsureGuIdentityUserIsIdentityRoleGuid()
		{
			Assert.True(typeof(IdentityRole<Guid>).IsAssignableFrom(typeof(GuIdentityRole)));
		}
	}
}