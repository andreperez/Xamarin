using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Projeto04.Database;
using Projeto04.Model;
using Xamarin.Forms;

namespace Projeto04.ViewModel
{
    public class TelaPrincipalViewModel : INotifyPropertyChanged
    {
        public List<Tarefa> Tarefas { get; set; }
        
        public TelaPrincipalViewModel()
        {
            Tarefas = new TarefasDataAccess().GetTarefas();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
