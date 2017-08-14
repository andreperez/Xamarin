using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mensagens
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Beta Teste", "Este programa está na versão Beta!", "OK");

            bool pergunta = await DisplayAlert("Excluir Registro", "Você tem certeza que deseja excluir este registro?", "Sim", "Não");
            lblResultado.Text = pergunta.ToString();
        }

        private async void Button_Clicked_Actions(object sender, EventArgs e)
        {
            var resultado = await DisplayActionSheet("Qual a sua linguagem preferida?", "Cancelar", "Fechar", "C#", "PHP", "Java", "VB", "Python", "Ruby");

            lblResultado.Text = resultado;
        }
    }
}
