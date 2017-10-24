using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App11.Traducao;
namespace App11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            Lang.AppLang.Culture = DependencyService.Get<ILocale>().GetCurrentCultureInfo();
            LblMsg.Text = Lang.AppLang.MSG_01;
        }
    }
}
