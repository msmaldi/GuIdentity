using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Msmaldi.AspNetCore.GuIdentity.EntityFrameworkCore
{
	public class GuIdentityRole : IdentityRole<Guid>
	{
		public GuIdentityRole()
		{ }

		public GuIdentityRole(string roleName) : this()
        {
            Name = roleName;
        }
	}
}