using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

#if __ANDROID__
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.Support.Design.Widget;
#endif

#if __IOS__
using UIKit;
using Xamarin.Forms.Platform.iOS;
#endif



namespace App03
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

#if __ANDROID__
            TextView labelDroid = new TextView(Forms.Context) { Text = "Eu sou Android Nativo!"};
            Container.Children.Add(labelDroid);

            FloatingActionButton fab = new FloatingActionButton(Forms.Context);
            fab.SetImageResource(Droid.Resource.Drawable.ic_media_play);
            ContainerAbs.Children.Add(fab);

            fab.Click += delegate
            {
                DisplayAlert("FAB", "FAB clicado", "OK");
            };

#endif

#if __IOS__
            UILabel labelIOS = new UILabel() { Text = "Eu sou iOS Nativo!" };
            Container.Children.Add(labelIOS);
#endif
        }
    }
}
