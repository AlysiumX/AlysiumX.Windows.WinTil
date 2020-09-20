using AlysiumX.Windows.WinTil.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Data
{
	public interface IContextOperations
	{
		void RemoveContext( Context context );
		void SaveContext( Context context );
	}
}
