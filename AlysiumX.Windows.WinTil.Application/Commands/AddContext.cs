using AlysiumX.Windows.WinTil.Application.Adapters;
using AlysiumX.Windows.WinTil.Application.Data;
using AlysiumX.Windows.WinTil.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Commands
{
	public class AddContext : IWinTilCommand
	{
		private readonly IContextOperations _contextOperations;
		public AddContext( IContextOperations contextOperations )
		{
			_contextOperations = contextOperations;
		}

		public void Execute( IEnumerable<string> parameters )
		{
			var adapter = new ContextAdapter();
			var context = adapter.CreateObjectFromParameters( parameters );
			_contextOperations.SaveContext( context );
		}
	}
}
