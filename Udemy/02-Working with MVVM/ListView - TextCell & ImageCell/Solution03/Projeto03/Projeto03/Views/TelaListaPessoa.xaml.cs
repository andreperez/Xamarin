using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto03.Models;
using Projeto03.ViewModels;
using Xamarin.Forms;

namespace Projeto03.Views
{
    public partial class TelaListaPessoa : ContentPage
    {
        public TelaListaPessoa()
        {
            InitializeComponent();

            BindingContext = new TelaListaPessoaViewModel();
        }

        public void ListView_ItemDetail(object sender, ItemTappedEventArgs e)
        {
            Pessoa pessoa = e.Item as Pessoa;

            Navigation.PushAsync(new TelaPessoa(pessoa));
        }
    }
}
