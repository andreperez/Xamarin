using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace DataTemplateSelector
{
    public class MainPageCs : ContentPage
    {
        private readonly DataTemplate incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
        private readonly DataTemplate outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));      

        #region Constructor

        public MainPageCs()
        {
            var viewModel = new MainPageViewModel();
            BindingContext = viewModel;
            var listView = new SfListView();
            listView.ItemSize = 100;
            listView.ItemsSource = viewModel.Messages;

            listView.ItemTemplate = new MyDataTemplateSelector
            {
                OutgoingDataTemplate = outgoingDataTemplate,
                IncomingDataTemplate = incomingDataTemplate,
            };
            Content = listView;
        }

        #endregion
    }
}
