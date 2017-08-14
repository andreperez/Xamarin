using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Projeto08.View
{
    public partial class PaginaMaster : MasterDetailPage
    {
        public PaginaMaster()
        {
            InitializeComponent();
        }

        private void ButtonPagina1_OnClicked(object sender, EventArgs e)
        {
            Detail = new PaginaConteudo();
            IsPresented = false;
        }

        private void ButtonPagina2_OnClicked(object sender, EventArgs e)
        {
            Detail = new PaginaConteudo2();
            IsPresented = false;
        }
    }
}
