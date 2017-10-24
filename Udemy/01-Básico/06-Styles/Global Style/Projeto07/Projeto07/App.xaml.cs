using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto07.View;
using Xamarin.Forms;

namespace Projeto07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Tela03();
        }
    }
}
