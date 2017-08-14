using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Projeto06.View
{
    public partial class RangePage : ContentPage
    {
        public RangePage()
        {
            InitializeComponent();
        }

        public void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtSlider.Text = e.NewValue.ToString();
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtStepper.Text = e.NewValue.ToString();
        }
    }
}
