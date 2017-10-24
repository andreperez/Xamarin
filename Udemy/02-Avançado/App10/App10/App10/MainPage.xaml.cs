using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Multilingual;
using System.Globalization;
namespace App10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Lang.AppLang.Culture = new CultureInfo("es");

            LblNome.Text = Lang.AppLang.LBL_NOME;
            //var x = CrossMultilingual.Current.CurrentCultureInfo;

            //var y = x;
        }
    }
}
