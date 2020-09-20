using AlysiumX.Windows.WinTil.Application.Data;
using AlysiumX.Windows.WinTil.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AlysiumX.Windows.WinTil.UI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : System.Windows.Application
	{
		private ServiceProvider serviceProvider;
		public App()
		{
			ServiceCollection services = new ServiceCollection();
			ConfigureServices( services );
			serviceProvider = services.BuildServiceProvider();
		}

		private void ConfigureServices( ServiceCollection services )
		{
			services.AddSingleton<MainWindow>();
			services.AddSingleton<IContextOperations, ContextOperations>();
			services.AddSingleton<IProgramOperations, ProgramOperations>();
			services.AddSingleton<IWebsiteOperations, WebsiteOperations>();
		}

		private void OnStartup( object sender, StartupEventArgs e )
		{
			var mainWindow = serviceProvider.GetService<MainWindow>();
			mainWindow.Show();
		}
	}
}
