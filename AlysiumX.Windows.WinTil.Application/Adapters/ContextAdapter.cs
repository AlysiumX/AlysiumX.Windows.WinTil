using AlysiumX.Windows.WinTil.Application.Interfaces;
using AlysiumX.Windows.WinTil.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Adapters
{
	public class ContextAdapter : IAdapter<Context>
	{
		public Context CreateObjectFromParameters( IEnumerable<string> parameters )
		{
			var parameterList = parameters.ToList();
			return new Context( parameterList[0] );
		}
	}
}
