using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Interfaces
{
	public interface IWinTilCommand
	{
		void Execute( IEnumerable<string> parameters );
	}
}
