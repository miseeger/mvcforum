using MVCForum.Services.Data.NPoco.Interceptors;
using MVCForum.Services.Data.NPoco.Mapping;
using NPoco;
using NPoco.FluentMappings;

namespace MVCForum.Services.Data.NPoco
{

    /// <summary>
    /// Fluent configuration and mapping ... The advantage is that
    /// you don't have any NPoco specific Attributes in your model
    /// classes and do not necessarily need to include the NPoco
    /// library when using these classes. But feel also free to use
    /// the classic Attribute approach ;)
    /// https://github.com/schotime/NPoco/wiki/Fluent-mappings-including-conventional
    /// </summary>
    public class NPocoDbConfig
	{
		public static DatabaseFactory DbFactory { get; set; }

		public static void Initialize()
		{
			var fluentConfig = FluentMappingConfiguration.Configure
			(
				new MemberMapping()
                // ,new OtherMapping()
                // , ... etc.
			);

			DbFactory = DatabaseFactory.Config(x =>
			{
				x.WithFluentConfig(fluentConfig);
				x.WithInterceptor(new DataInterceptor());
			});
		}
	}
}