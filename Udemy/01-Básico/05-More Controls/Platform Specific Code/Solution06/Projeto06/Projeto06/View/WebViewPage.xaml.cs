using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Projeto06.View
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            var paginaHTML = new HtmlWebViewSource();
            paginaHTML.Html = @"<html><body>
                Esta é uma WebView executando HTML local.
            </body></html>";

            webView.Source = paginaHTML;
        }

        
    }
}
