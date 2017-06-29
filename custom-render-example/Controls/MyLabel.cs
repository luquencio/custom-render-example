using System;
using Xamarin.Forms;

namespace customrenderexample.Controls
{
    public class MyLabel : Label
    {
        public MyLabel()
        {
        }

		public static readonly BindableProperty IsUnderlineProperty =
            BindableProperty.Create(nameof(IsUnderline), typeof(bool), typeof(MyLabel), true);

		public bool IsUnderline
		{
			get
			{
				return (bool)GetValue(IsUnderlineProperty);
			}
			set
			{
				SetValue(IsUnderlineProperty, value);
			}
		}
    }
}
