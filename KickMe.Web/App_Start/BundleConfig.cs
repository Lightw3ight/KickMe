namespace KickMe
{
	using System.Web.Optimization;

	/// <summary>
	/// The bundle config.
	/// </summary>
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/app")
				.Include("~/app/app.js")
				.IncludeDirectory("~/app", "*.js")
				.IncludeDirectory("~/app/directives", "*.js")
				.IncludeDirectory("~/app/controllers", "*.js")
				.IncludeDirectory("~/app/services", "*.js"));

			bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
						"~/Scripts/jquery-2.1.4.min.js",
						"~/Scripts/lodash.min.js",
						"~/Scripts/angular.js",
						"~/Scripts/angular-animate.min.js",
						"~/Scripts/angular-route.min.js",
						"~/Scripts/angular-ui/ui-bootstrap-tpls.min.js"));
		}
	}
}