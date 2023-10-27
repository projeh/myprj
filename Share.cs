using System.Data;

namespace mhmdhidry
{
    public static class Share
    {
        public static string GetAppSetting(string key, string value)
        {
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder();
            cfgBuilder.AddJsonFile("appsettings.json");
            IConfiguration cfg = cfgBuilder.Build();
            return cfg[$"{key}:{value}"];
        }
        public static string GetConnectionString()
        {
            return GetAppSetting("ConnectionStrings", "DefaultConnection");
        }
        public static string NewGuid()
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            return $"{dateTime.Year}{dateTime.Month.ToString("00")}{dateTime.Day.ToString("00")}{Guid.NewGuid().ToString().Replace("-",string.Empty)}{dateTime.Hour.ToString("00")}{dateTime.Minute.ToString("00")}{dateTime.Second.ToString("00")}{dateTime.Millisecond.ToString("000")}";
        }
    }
}