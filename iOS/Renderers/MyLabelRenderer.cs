using System;
using customrenderexample.Controls;
using customrenderexample.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]
namespace customrenderexample.iOS.Renderers
{
    public class MyLabelRenderer : LabelRenderer 
    {
        public MyLabelRenderer()
        {
            
        }

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);


			if (this.Control == null)
				return;

            try
            {
                var label = (UILabel) Control;
                var text = (NSMutableAttributedString)label.AttributedText;
                var range = new NSRange(0, text.Length);
                text.AddAttribute(UIStringAttributeKey.UnderlineStyle, NSNumber.FromInt32((int)NSUnderlineStyle.Single), range);

            }
            catch (Exception ex)
            {
                throw ex;
            }

		}
    }
}
