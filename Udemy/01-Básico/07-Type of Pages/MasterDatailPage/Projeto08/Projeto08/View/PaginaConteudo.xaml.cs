using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Projeto08.View
{
    public partial class PaginaConteudo : ContentPage
    {
        public PaginaConteudo()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaConteudo2());
        }
    }
}
