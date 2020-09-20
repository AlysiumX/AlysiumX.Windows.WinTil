using System.Windows;
using System.Windows.Input;

namespace AlysiumX.Windows.WinTil.UI
{
	/// <summary>
	/// Interaction logic for Command.xaml
	/// </summary>
	public partial class Command : Window
	{
		Settings _Settings { get; set; }
		//CommandProcessor Processor { get; set; }

		public Command()
		{
			InitializeComponent();
			this.Topmost = true;
			_Settings = new Settings();
			//ProgramBindings = new ProgramBindings();
			//Processor = new CommandProcessor();
			//Info.Text = $"Context:{Processor.Process( DefaultCommands.Context )}";
		}


		//TODO : Simple routing system, simplar to a web api.
		public void SendButton_Clicked( object sender, RoutedEventArgs e )
		{
			//	Message.Text = "";
			//	var responseMessage = ProcessCommand(EntryBox.Text);
			//	EntryBox.Text = "";

			//	if( responseMessage != "" )
			//	{
			//		Message.Text = responseMessage;
			//	}
			//	else
			//	{
			//		this.Hide();
			//	}

			//	Info.Text = $"Context:{Processor.Process( DefaultCommands.Context )}";
		}

		//private string ProcessCommand(string text)
		//{
		//	var command = text.ToLower();

		//	if (command == "config")
		//		_Settings.Show();

		//	return Processor.Process(command);
		//}

		private void Window_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.Key == Key.Escape )
			{
				this.Hide();
			}
		}
	}
}
