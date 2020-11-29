namespace PersonalWebsite
{
	public class Plugin
	{
		public Plugin(string name, string developer, string info, string link = null)
		{
			Name      = name;
			Developer = developer;
			Info      = info;
			Link      = link;
		}

		public string Name;
		public string Developer;
		public string Info;
		public string Link;
	}

	public class Synth : Plugin
	{
		public Synth(string name, string developer, string type, string info, string link = null) :
			base(name, developer, info, link)
		{
			Name      = name;
			Developer = developer;
			Type      = type;
			Info      = info;
			Link      = link;
		}

		public string Type;
	}

	public class Effect : Plugin
	{
		public Effect(string name, string developer, string category, string useCase, string info, string link = null) :
			base(name, developer, info, link)
		{
			Name      = name;
			Developer = developer;
			Category  = category;
			UseCase   = useCase;
			Info      = info;
			Link      = link;
		}

		public string UseCase;
		public string Category;
	}
}