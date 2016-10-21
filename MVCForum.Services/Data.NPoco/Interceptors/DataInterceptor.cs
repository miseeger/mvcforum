using NPoco;

namespace MVCForum.Services.Data.NPoco.Interceptors
{
	public class DataInterceptor : IDataInterceptor
	{

		public bool OnInserting(IDatabase database, InsertContext insertContext)
		{
            // your code
            return true;
		}

		public bool OnUpdating(IDatabase database, UpdateContext updateContext)
		{
			// your code
			return true;
		}

		public bool OnDeleting(IDatabase database, DeleteContext deleteContext)
		{
			// your code
			return true;

		}
	}
}