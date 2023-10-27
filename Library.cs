namespace mhmdhidry
{
	public static class Library
	{
		private static IConfiguration GetConfiguration()
		{
			IConfigurationBuilder cfgBuilder = new ConfigurationBuilder();
			cfgBuilder.AddJsonFile("websettings.json");
			IConfiguration cfg = cfgBuilder.Build();
			return cfg;
		}
		public static string JoinURL(HttpRequest httpRequest, string url)
		{
			string referer = domain(httpRequest);
			if ((referer ?? string.Empty).EndsWith("/")) referer = referer.Substring(0, referer.Length - 1);
			if (url.StartsWith("/")) url = url.Substring(1, url.Length - 1);
			return $"{referer}/{url}";
		}
		public static string domain(HttpRequest httpRequest) => httpRequest.Headers["Referer"];

		public static void CreateDirectory(string directory)
		{
			if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
		}
		public static void DeleteFile(string fileName)
		{
			if (File.Exists(fileName)) File.Delete(fileName);
		}
		public static string NewGuid()
		{
			DateTime dateTime = new DateTime();
			dateTime = DateTime.Now;
			return $"{dateTime.Year}{dateTime.Month.ToString("00")}{dateTime.Day.ToString("00")}{dateTime.Hour.ToString("00")}{dateTime.Minute.ToString("00")}{dateTime.Second.ToString("00")}{dateTime.Millisecond.ToString("000")}{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
		}

		public static string GetSession(HttpContext httpContext, string key) => httpContext.Session.GetString(key);

		public static void SetSession(HttpContext httpContext, string key, string value) => httpContext.Session.SetString(key, value);

		public static void RemoveSession(HttpContext httpContext, string key) => httpContext.Session.Remove(key);

		public static void SetSessionIfNull(HttpContext httpContext, string key, string value)
		{
			if (GetSession(httpContext, key) == null) SetSession(httpContext, key, value);
		}
	}
}
