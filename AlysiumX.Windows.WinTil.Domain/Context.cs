using System;

namespace AlysiumX.Windows.WinTil.Domain
{
	public class Context
	{
		public string Name { get; private set; }
		public Context( string name )
		{
			Name = name;
		}
	}
}
