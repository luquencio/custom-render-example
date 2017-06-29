using System;
using Android.Graphics;
using customrenderexample.Controls;
using customrenderexample.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]
namespace customrenderexample.Droid.Renderers
{
    public class MyLabelRenderer : LabelRenderer
    {
        public MyLabelRenderer()
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e) {

            base.OnElementChanged(e);


			if (this.Control == null)
				return;

            var view =  Element as MyLabel ;
			if (view.IsUnderline)
			{
				this.Control.PaintFlags = PaintFlags.UnderlineText;
			}

        }

    }
}
