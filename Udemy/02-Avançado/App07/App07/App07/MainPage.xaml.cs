using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App07
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if(Device.Idiom == TargetIdiom.Tablet)
            {
                Container.BackgroundColor = Color.Aqua;
            }


            if (Device.OS == TargetPlatform.iOS) {
                Container.Margin = new Thickness(0, 10, 0, 0);
            }

            Thickness Margin = new Thickness(0, 10, 0, 0);

            Device.OnPlatform(iOS: () => {
                Margin = new Thickness(0, 10, 0, 0);
            },
            Android: ()=> {

            },
            WinPhone: () =>
            {

            }
            );

            Container.Margin = Margin;
            
        }
    }
}
