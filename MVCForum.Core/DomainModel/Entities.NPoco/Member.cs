using System;

namespace MVCForum.Domain.DomainModel
{

	public class Member
	{
		public Guid MemberId { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public bool IsApproved { get; set; }
		public bool IsLockedOut { get; set; }
		public bool IsBanned { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime LastLoginDate { get; set; }
		public string Slug { get; set; }
		public string Signature { get; set; }
		public int? Age { get; set; }
		public string Location { get; set; }
		public string Website { get; set; }
		public string Twitter { get; set; }
		public string Facebook { get; set; }
		public string Avatar { get; set; }
		public bool? DisableEmailNotifications { get; set; }
		public bool? DisablePosting { get; set; }
		public bool? DisablePrivateMessages { get; set; }
		public bool? DisableFileUploads { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
	}

}