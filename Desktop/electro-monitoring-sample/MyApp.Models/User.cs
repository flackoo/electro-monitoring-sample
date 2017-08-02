﻿namespace MyApp.Models
{
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
	using System.Collections.Generic;
	using System.Security.Claims;
	using System.Threading.Tasks;

	public class User : IdentityUser
	{
		public User()
		{
		}

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
		{
			// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
			var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
			// Add custom user claims here
			return userIdentity;
		}
	}
}
