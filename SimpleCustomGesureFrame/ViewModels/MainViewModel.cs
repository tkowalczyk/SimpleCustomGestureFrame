using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace SimpleCustomGesureFrame.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		public MainViewModel ()
		{
		}

		private Command<string> sampleCommand;
		public Command<string> SampleCommand
		{
			get { return sampleCommand ?? (sampleCommand = new Command<string>(async arg => await ExecuteSampleCommand(arg))); }
		}

		private async Task ExecuteSampleCommand(string arg)
		{
			try
			{
				Console.WriteLine("ViewModel Command: " + arg);
			}
			catch (Exception ex)
			{
				
			}
		}
	}
}