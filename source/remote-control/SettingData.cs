using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remote_control
{
	public class SettingModel
	{
		public UserSetting[] AllSetting { get; set; }
	}

	public class UserSetting
	{
		public SettingData SettingData { get; set; }
		public string username { get; set; }
	}

	public class SettingData
	{
		public string Duration { get; set; }
	}

}
