using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Projeto06.View
{
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void OnToggledSwitch(object sender, ToggledEventArgs e)
        {
            txtSwitch.Text = e.Value.ToString();
        }
    }
}
