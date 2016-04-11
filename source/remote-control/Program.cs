using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remote_control
{
	class Program
	{
		static void Main(string[] args)
		{
			var settingService = new SettingService();
			var all = settingService.GetAllSettings();
			string userName = UserService.GetCurrentUsername();
			var data = settingService.GetSettingPerUser(userName);
			//var x = new SettingModel();
			//x.AllSetting = new UserSetting[] 
			//{
			//	new UserSetting() { SettingData = new SettingData() { Duration="1000" }, username="test" },
			//	new UserSetting() { SettingData = new SettingData() { Duration="1000" }, username="bahman" }
			//};
			//var xx = Newtonsoft.Json.JsonConvert.SerializeObject(x);
		}
	}
}
