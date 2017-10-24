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
    public partial class TelaPessoa : ContentPage
    {
        public TelaPessoa(Pessoa pessoa)
        {
            InitializeComponent();



            BindingContext = new TelaPessoaViewModel(pessoa);
        }
    }
}
