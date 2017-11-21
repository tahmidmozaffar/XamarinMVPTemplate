using System;
namespace XamarinMVPTemplate.Main.Models
{
	public class LoginCredential
	{
		public string UserName { get; set; }
		public string Password { get; set; }

		public bool IsValidUserName()
		{
			if (UserName.StartsWith("*", StringComparison.OrdinalIgnoreCase)) {
				return false;
			}

			return true;

		}

		public bool IsValidPassword()
		{
			return Password.Length > 4;

		}
	}
}