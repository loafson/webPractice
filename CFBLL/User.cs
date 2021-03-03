using System;

namespace CF.BLL
{
	public class User
	{
		public static bool add(Model.User user)
		{
			return DAL.User.add(user);
		}
	}
}
