using AlysiumX.Windows.WinTil.Application.Interfaces;
using AlysiumX.Windows.WinTil.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Adapters
{
	public class WebsiteAdapter : IAdapter<Website>
	{
		public Website CreateObjectFromParameters( IEnumerable<string> parameters )
		{
			var parameterList = parameters.ToList();
			return new Website( parameterList[0], parameterList[1], parameterList[2] );
		}
	}
}
