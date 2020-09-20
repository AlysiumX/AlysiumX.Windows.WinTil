using AlysiumX.Windows.WinTil.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Data
{
	public interface IProgramOperations
	{
		void RemoveProgram( Program program );
		string RetrieveLocationFromContextAndProgramName( string context, string name );
		void SaveProgram( Program program );
	}
}
