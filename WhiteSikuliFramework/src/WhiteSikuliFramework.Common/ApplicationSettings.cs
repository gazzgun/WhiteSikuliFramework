using System.Configuration;

namespace WhiteSikuliFramework.Common
{
    public static class ApplicationSettings
    {
        public static string SikuliImage => GetSettingValue("sikuliImagePath");

        public static string GetApplicationTitle(string key)
        {
            return GetSettingValue(key);
        }

        private static string GetSettingValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetApplicationPath(string key)
        {
            return GetSettingValue(key);
        }
    }
}