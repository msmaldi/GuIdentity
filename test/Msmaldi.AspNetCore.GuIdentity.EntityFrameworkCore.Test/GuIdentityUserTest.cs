using Xunit;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore.Test
{
	public class GuIdentityUserTest
	{
		[Fact]
		public void EnsureGuIdentityUserIdIsGuid()
		{
			var user = new GuIdentityUser();
			var typeOfId = user.Id.GetType();
			Assert.Equal(typeof(Guid), typeOfId);
		}

		[Fact]
		public void EnsureGuIdentityUserIsIdentityUserGuid()
		{
			Assert.True(typeof(IdentityUser<Guid>).IsAssignableFrom(typeof(GuIdentityUser)));
		}
	}
}