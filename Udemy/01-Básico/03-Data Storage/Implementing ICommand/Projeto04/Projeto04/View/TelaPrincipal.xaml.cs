using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Projeto04.Database;
using Projeto04.Model;
using Projeto04.ViewModel;
using Xamarin.Forms;

namespace Projeto04.View
{
    public partial class TelaPrincipal : ContentPage
    {
        public Tarefa TarefaEdicao { get; set; }

        public TelaPrincipal()
        {
            InitializeComponent();

            BindingContext = new TelaPrincipalViewModel();
            
        }
    }
}
