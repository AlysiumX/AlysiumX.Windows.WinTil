using AlysiumX.Windows.WinTil.Application.Adapters;
using AlysiumX.Windows.WinTil.Application.Data;
using AlysiumX.Windows.WinTil.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Commands
{
	public class AddProgram : IWinTilCommand
	{
		private readonly IProgramOperations _programOperations;
		public AddProgram( IProgramOperations programOperations )
		{
			_programOperations = programOperations;
		}

		public void Execute( IEnumerable<string> parameters )
		{
			var adapter = new ProgramAdapter();
			var program = adapter.CreateObjectFromParameters( parameters );
			_programOperations.SaveProgram( program );
		}
	}
}
