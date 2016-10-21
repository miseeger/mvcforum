using MVCForum.Domain.Interfaces.Five01st;
using NPoco;

namespace MVCForum.Services.Data.NPoco
{
	// http://stackoverflow.com/questions/2813322/unity-2-0-how-to-use-resolve-with-resolveroverride

	public class NPocoDb : Database, INPocoDb
	{

		public NPocoDb(string dbConnection)
			: base(dbConnection)
		{
			NPocoDbConfig.Initialize();
			NPocoDbConfig.DbFactory.Build(this);
		}

		public NPocoDb(string dbConnection, DatabaseType dbType)
			: base(dbConnection, dbType)
		{
			NPocoDbConfig.Initialize();
			NPocoDbConfig.DbFactory.Build(this);
		}

	}

}