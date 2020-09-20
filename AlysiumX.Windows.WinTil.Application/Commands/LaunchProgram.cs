using AlysiumX.Windows.WinTil.Application.Adapters;
using AlysiumX.Windows.WinTil.Application.Data;
using AlysiumX.Windows.WinTil.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Commands
{
	public class LaunchProgram : IWinTilCommand
	{
		private readonly IProgramOperations _programOperations;
		public LaunchProgram( IProgramOperations programOperations )
		{
			_programOperations = programOperations;
		}

		public void Execute( IEnumerable<string> parameters )
		{
			var adapter = new ProgramAdapter();
			var program = adapter.CreateObjectFromParameters( parameters );
			var location = _programOperations.RetrieveLocationFromContextAndProgramName( program.Context, program.Name );
			program.SetLocation( location );
		}
	}
}
