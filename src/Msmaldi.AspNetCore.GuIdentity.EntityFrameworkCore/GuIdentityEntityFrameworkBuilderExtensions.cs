using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class GuIdentityEntityFrameworkBuilderExtensions
	{
		public static IdentityBuilder AddEntityFrameworkGuidStores<TContext>(this IdentityBuilder builder)
			where TContext : DbContext
		{			
			return builder.AddEntityFrameworkStores<TContext>();
		}
	}
}