using AlysiumX.Windows.WinTil.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlysiumX.Windows.WinTil.Application.Data
{
	public interface IWebsiteOperations
	{
		void RemoveWebsite( Website website );
		string RetrieveLocationFromContextAndProgramName( string context, string name );
		void SaveWebsite( Website website );
	}
}
