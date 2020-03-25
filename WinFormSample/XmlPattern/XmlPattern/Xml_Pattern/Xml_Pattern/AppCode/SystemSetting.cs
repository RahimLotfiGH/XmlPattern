using System.Collections.Generic;
using System.ComponentModel;

namespace Xml_Pattern.AppCode
{
    public class SystemSetting : SystemSettingBase
    {
        private static string BranchName => nameof(SystemSetting);
        public static string AppName => Settings.GetWithXmlPath<string>(BranchName, ESettings.AppName.ToString());
        public static string AppVersion => Settings.GetWithXmlPath<string>(BranchName, ESettings.AppVersion.ToString());
        public static string EfConnectionString => Settings.GetWithXmlPath<string>(BranchName, ESettings.EfConnectionString.ToString());
        public static string DapperConnectionString => Settings.GetWithXmlPath<string>(BranchName, ESettings.DapperConnectionString.ToString());

        private enum ESettings
        {
            [Description("نام اپلیکیشن")]
            AppName,
            [Description("ورژن")]
            AppVersion,
            [Description("کانکشن استرینگ اتصال به ان تی تی فریم ورک")]
            EfConnectionString,
            [Description("کانکشن استرینگ اتصال به دپر")]
            DapperConnectionString
        }
    }

    public class ServerSetting : SystemSettingBase
    {
        private static string BranchName => nameof(ServerSetting);
        public static string ServerName => Settings.GetWithXmlPath<string>(BranchName, ESettings.ServerName.ToString());
        public static string ServerIp => Settings.GetWithXmlPath<string>(BranchName, ESettings.ServerIp.ToString());
        public static string ServerLocation => Settings.GetWithXmlPath<string>(BranchName, ESettings.ServerLocation.ToString());
        public static bool IsServerAvailable => Settings.GetWithXmlPath<bool>(BranchName, ESettings.IsServerAvailable.ToString());
        public static List<int> Ports => Settings.GetListWithXmlPath<int>(BranchName, ESettings.Ports.ToString());
        //public static List<int> Ports => Settings.GetList<int>(ESettings.Ports.ToString());
        private enum ESettings
        {
            [Description("نام سرور")]
            ServerName,
            [Description("Ip سرور")]
            ServerIp,
            [Description("مکان سرور")]
            ServerLocation,
            [Description("سرور قابل دسترسی می باشد")]
            IsServerAvailable,
            [Description("پورت های قابل دسترسی")]
            Ports
        }
    }
}
