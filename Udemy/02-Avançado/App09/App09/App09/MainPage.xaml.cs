using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            LblNome.Text = Lang.AppLang.LBL_NOME;
            TxtNome.Placeholder = Lang.AppLang.TXT_PH_NOME;
            BtnSalvar.Text = Lang.AppLang.BTN_SALVAR;
        }
    }
}
