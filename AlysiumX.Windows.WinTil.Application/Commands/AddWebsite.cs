using AlysiumX.Windows.WinTil.Application.Adapters;
using AlysiumX.Windows.WinTil.Application.Data;
using AlysiumX.Windows.WinTil.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Commands
{
	public class AddWebsite : IWinTilCommand
	{
		private readonly IWebsiteOperations _websiteOperations;
		public AddWebsite( IWebsiteOperations websiteOperations )
		{
			_websiteOperations = websiteOperations;
		}

		public void Execute( IEnumerable<string> parameters )
		{
			var adapter = new WebsiteAdapter();
			var website = adapter.CreateObjectFromParameters( parameters );
			_websiteOperations.SaveWebsite( website );
		}
	}
}
