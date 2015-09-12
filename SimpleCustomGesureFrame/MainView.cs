using System;
using Xamarin.Forms;

using SimpleCustomGesureFrame.ViewModels;

namespace SimpleCustomGesureFrame
{
	public class MainView : ContentPage
	{
		private MainViewModel ViewModel
		{
			get { return BindingContext as MainViewModel; }
		}

		public MainView ()
		{
			BindingContext = new MainViewModel ();

			GestureFrame gi = new GestureFrame
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.FromHex("bf3122"),
			};

			gi.SwipeDown += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Down Detected", "OK");
				ViewModel.SampleCommand.Execute("Swipe Down Detected");
			};

			gi.SwipeTop += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Top Detected", "OK");
				ViewModel.SampleCommand.Execute("Swipe Top Detected");
			};

			gi.SwipeLeft += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Left Detected", "OK");
				ViewModel.SampleCommand.Execute("Swipe Left Detected");
			};

			gi.SwipeRight += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Right Detected", "OK");
				ViewModel.SampleCommand.Execute("Swipe Right Detected");
			};

			this.Content = gi;
		}
	}
}