using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Interfaces
{
	public interface IAdapter<T>
	{
		T CreateObjectFromParameters( IEnumerable<string> parameters );
	}
}
