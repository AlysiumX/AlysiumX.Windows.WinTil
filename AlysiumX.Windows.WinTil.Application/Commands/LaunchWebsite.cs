using AlysiumX.Windows.WinTil.Application.Adapters;
using AlysiumX.Windows.WinTil.Application.Data;
using AlysiumX.Windows.WinTil.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Commands
{
	public class LaunchWebsite : IWinTilCommand
	{
		private readonly IWebsiteOperations _websiteOperations;
		public LaunchWebsite( IWebsiteOperations websiteOperations )
		{
			_websiteOperations = websiteOperations;
		}

		public void Execute( IEnumerable<string> parameters )
		{
			var adapter = new WebsiteAdapter();
			var website = adapter.CreateObjectFromParameters( parameters );
			var location = _websiteOperations.RetrieveLocationFromContextAndProgramName( website.Context, website.Name );
			website.SetLocation( location );
		}
	}
}
