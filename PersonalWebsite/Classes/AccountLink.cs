namespace PersonalWebsite.Classes
{
	public class AccountLink
	{
		public string Link;
		public string Image;
		public string Username;
		public bool   UseUsername;

		public AccountLink(string link, string username, string image, bool useUsername = false)
		{
			Link        = link;
			Image       = image;
			Username    = username;
			UseUsername = useUsername;
		}
	}
}
