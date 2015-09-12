using System;
using Xamarin.Forms;

namespace SimpleCustomGesureFrame
{
	public class MainView : ContentPage
	{
		public MainView ()
		{
			GestureFrame gi = new GestureFrame
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.FromHex("bf3122"),
			};

			gi.SwipeDown += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Down Detected", "OK");
			};

			gi.SwipeTop += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Top Detected", "OK");
			};

			gi.SwipeLeft += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Left Detected", "OK");
			};

			gi.SwipeRight += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Right Detected", "OK");
			};

			this.Content = gi;
		}
	}
}