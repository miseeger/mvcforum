using MVCForum.Domain.Constants;
using MVCForum.Domain.Interfaces.NPoco;

namespace MVCForum.Services.Data.NPoco
{
    /// <summary>
    /// NPocoDBFactory is made available from and is registered
    /// with the DI container so it is possible to inject it into
    /// any Service or Controller (see UnityHelper.cs). So the 
    /// use of the NPoco microORM DataLayer is also provided whenever 
    /// there is need of a kind of lightweight data access.
    /// </summary>
    public class NPocoDbFactory : INPocoDbFactory
	{

        /// <summary>
        /// Provides an instance of a NPoco Database object which 
        /// implements IDisposable and is so ready to be used in a 
        /// using {} block. NPoco makes use of the connection pooling 
        /// functionality so there is no need for a singleton 
        /// to hold the Database object in order to reuse it.
        /// Please also refer to this: 
        /// http://stackoverflow.com/questions/1557592/is-using-a-singleton-for-the-connection-a-good-idea-in-asp-net-website
        /// </summary>
        /// <returns></returns>
        public INPocoDb CreateDb()
        {
            return new NPocoDb(AppConstants.MvcForumContext);
        }

	}

}
