using AlysiumX.Windows.WinTil.Application.Interfaces;
using AlysiumX.Windows.WinTil.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Adapters
{
	public class ProgramAdapter : IAdapter<Program>
	{
		public Program CreateObjectFromParameters( IEnumerable<string> parameters )
		{
			var parameterList = parameters.ToList();
			return new Program( parameterList[0], parameterList[1], parameterList[2] );
		}
	}
}
