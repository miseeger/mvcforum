
// Think this is no longer needed according to this:
// http://stackoverflow.com/questions/1557592/is-using-a-singleton-for-the-connection-a-good-idea-in-asp-net-website

namespace MVCForum.Services.Data.NPoco
{
    using System.Web;
    using Domain.Constants;
    using global::NPoco;

    internal static class ContextPerRequest
    {
        internal static IDatabase Current
        {
            get
            {
                if (!HttpContext.Current.Items.Contains(SiteConstants.Instance.MvcForumContext))
                {
                    HttpContext.Current.Items.Add(SiteConstants.Instance.MvcForumContext, new Database(SiteConstants.Instance.MvcForumContext));
                }
                return HttpContext.Current.Items[SiteConstants.Instance.MvcForumContext] as IDatabase;
            }
        }
    }
}
