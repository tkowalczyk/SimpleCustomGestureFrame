using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using SimpleCustomGesureFrame;
using SimpleCustomGesureFrame.iOS;
using MonoTouch.UIKit;

[assembly: ExportRenderer(typeof(GestureFrame), typeof(GestureFrameRenderer))]
namespace SimpleCustomGesureFrame.iOS
{
	public class GestureFrameRenderer : FrameRenderer
	{
		UISwipeGestureRecognizer swipeDown;
		UISwipeGestureRecognizer swipeUp;
		UISwipeGestureRecognizer swipeLeft;
		UISwipeGestureRecognizer swipeRight;

		public GestureFrameRenderer()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Frame> e)
		{
			base.OnElementChanged (e);

			swipeDown = new UISwipeGestureRecognizer (
				() => 
				{
					GestureFrame _gi = (GestureFrame)this.Element;
					_gi.OnSwipeDown();
				}
			)
			{
				Direction = UISwipeGestureRecognizerDirection.Down,
			};

			swipeUp = new UISwipeGestureRecognizer (
				() => 
				{
					GestureFrame _gi = (GestureFrame)this.Element;
					_gi.OnSwipeTop();
				}
			) 
			{
				Direction = UISwipeGestureRecognizerDirection.Up,
			};

			swipeLeft = new UISwipeGestureRecognizer (
				() => 
				{
					GestureFrame _gi = (GestureFrame)this.Element;
					_gi.OnSwipeLeft();
				}
			) 
			{
				Direction = UISwipeGestureRecognizerDirection.Left,
			};

			swipeRight = new UISwipeGestureRecognizer (
				() => 
				{
					GestureFrame _gi = (GestureFrame)this.Element;
					_gi.OnSwipeRight();
				}
			) 
			{
				Direction = UISwipeGestureRecognizerDirection.Right,
			};

			if (e.NewElement == null) {
				if (swipeDown != null) {
					this.RemoveGestureRecognizer (swipeDown);
				}
				if (swipeUp != null) {
					this.RemoveGestureRecognizer (swipeUp);
				}
				if (swipeLeft != null) {
					this.RemoveGestureRecognizer (swipeLeft);
				}
				if (swipeRight != null) {
					this.RemoveGestureRecognizer (swipeRight);
				}
			}

			if (e.OldElement == null) {
				this.AddGestureRecognizer (swipeDown);
				this.AddGestureRecognizer (swipeUp);
				this.AddGestureRecognizer (swipeLeft);
				this.AddGestureRecognizer (swipeRight);
			}
		}
	}
}