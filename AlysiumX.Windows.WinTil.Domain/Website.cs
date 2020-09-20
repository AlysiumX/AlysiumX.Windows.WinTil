using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Domain
{
	public class Website
	{
		public string Context { get; private set; }
		public string Name { get; private set; }
		public string Location { get; private set; }

		public Website( string context, string name )
		{
			Context = context;
			Name = name;
		}

		public Website( string context, string name, string location )
		{
			Context = context;
			Name = name;
			Location = location;
		}

		public void SetLocation( string location )
		{
			Location = location;
		}

	}
}
