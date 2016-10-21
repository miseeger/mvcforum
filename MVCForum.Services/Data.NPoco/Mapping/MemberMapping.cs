using MVCForum.Domain.DomainModel;
using NPoco.FluentMappings;

namespace MVCForum.Services.Data.NPoco.Mapping
{
    public class MemberMapping : Map<Member>
	{

		public MemberMapping()
		{
			TableName("MembershipUser");

			Columns(x =>
			{
				x.Column(y => y.MemberId).WithName("Id");
				x.Column(y => y.UserName);
				x.Column(y => y.Email);
				x.Column(y => y.IsApproved);
				x.Column(y => y.IsLockedOut);
				x.Column(y => y.IsBanned);
				x.Column(y => y.CreateDate);
				x.Column(y => y.LastLoginDate);
				x.Column(y => y.Slug);
				x.Column(y => y.Age);
				x.Column(y => y.Website);
				x.Column(y => y.Twitter);
				x.Column(y => y.Facebook);
				x.Column(y => y.Avatar);
				x.Column(y => y.DisableEmailNotifications);
				x.Column(y => y.DisablePosting);
				x.Column(y => y.DisablePrivateMessages);
				x.Column(y => y.DisableFileUploads);
				x.Column(y => y.Latitude);
				x.Column(y => y.Longitude);
			});

		}

	}

}
