using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Projeto04.Model;
using Projeto04.Database;
using Projeto04.ViewModel;

namespace Projeto04.Commands
{
    class MudarSituacaoCommand : ICommand
    {
        public TelaPrincipalViewModel TelaPrincipal;
        public MudarSituacaoCommand(TelaPrincipalViewModel tela)
        {
            TelaPrincipal = tela;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var tarefa = (Tarefa)parameter;
            if (tarefa.Finalizado == true)
            {
                tarefa.Finalizado = false;
            }
            else
            {
                tarefa.Finalizado = true;
            }
            new TarefasDataAccess().AtualizarTarefa(tarefa);

            //Tarefas = new ObservableCollection<Tarefa>(new TarefasDataAccess().GetTarefas());
            //OnPropertyChanged("Tarefas");


            for (int i = 0; i < TelaPrincipal.Tarefas.Count; i++)
            {
                if (TelaPrincipal.Tarefas[i].Id == tarefa.Id)
                {
                    TelaPrincipal.Tarefas[i] = tarefa;
                }
            }
        }
    }
}
