using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remote_control
{
	public class UserService
	{
		public static string GetCurrentUsername()
		{
			return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
		}
	}
}
