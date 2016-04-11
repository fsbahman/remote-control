using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remote_control
{
	public class SettingService
	{
		const string settingFileName = "settings.json";


		public SettingModel GetAllSettings()
		{
			string data = File.ReadAllText(settingFileName);
			var settings = JsonConvert.DeserializeObject<SettingModel>(data);
			return settings;
		}

		public SettingData GetUserSetting(string username)
		{
			var settings = GetAllSettings();
			if (settings == null) return null;
			foreach (UserSetting userSetting in settings.AllSetting)
			{
				if (userSetting.username == username)
				{
					return userSetting.SettingData;
				}
			}
			return null;
		}

		private int GetUserSettingIndex(string username)
		{
			var settings = GetAllSettings();
			if (settings == null) return -1;
			int i = 0;
			foreach (UserSetting userSetting in settings.AllSetting)
			{
				if (userSetting.username == username)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		public void SetSettingForUser(string username, SettingData setting)
		{
			var userSettingIndex = GetUserSettingIndex(username);
			
			if(userSettingIndex > 0 )
			{
				var all = GetAllSettings();
				var allSettings = all.AllSetting;
				Array.Resize<UserSetting>(ref allSettings, all.AllSetting.Length+1);
				all.AllSetting = allSettings;
				newMemberIndex = all.AllSetting.Length - 1;
				
			}
			else
			{

			}
			all.AllSetting[all.AllSetting.Length - 1] = new UserSetting() { SettingData = setting, username = username };

		}
	}
}
