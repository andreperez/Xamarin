using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Logica;
using Xamarin.Forms;

namespace Projeto02
{
    public partial class Tela01 : ContentPage
    {
        public Tela01()
        {
            InitializeComponent();

            BtnSoma.Clicked += delegate
            {
                int num1 = int.Parse(Numero1.Text);
                int num2 = int.Parse(Numero2.Text);

                int resultado = Matematica.Soma(num1, num2);

                Resultado.Text = "O resultado é " + resultado;
            };
        }
    }
}
