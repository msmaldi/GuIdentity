using System;
using Microsoft.AspNetCore.Identity;

namespace Msmaldi.AspNetCore.GuIdentity
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