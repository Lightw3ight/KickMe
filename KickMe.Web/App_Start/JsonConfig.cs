namespace KickMe
{
	using System.Net.Http.Formatting;

	using Newtonsoft.Json.Serialization;

	public class JsonConfig
	{
		public static void ConfigureJsonFormatting(JsonMediaTypeFormatter formatter)
		{
			var settings = formatter.SerializerSettings;
			settings.Formatting = Newtonsoft.Json.Formatting.Indented;
			settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
		}
	}
}