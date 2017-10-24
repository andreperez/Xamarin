using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Projeto04.Database;
using Projeto04.Model;
using Xamarin.Forms;
using System.Windows.Input;

namespace Projeto04.ViewModel
{
    public class TelaPrincipalViewModel : INotifyPropertyChanged
    {
        public Tarefa TarefaAtual { get; set; }
        public ObservableCollection<Tarefa> Tarefas { get; set; }

        public Command SalvarCommand { get; set; }
        public Command EditarTarefaCommand { get; set; }
        public Command ExcluirTarefaCommand { get; set; }
        public ICommand MudarSituacaoCommand { get; set; }

        public TelaPrincipalViewModel()
        {
            TarefaAtual = new Tarefa();
            Tarefas = new ObservableCollection<Tarefa>( new TarefasDataAccess().GetTarefas() );
            SalvarCommand = new Command(Salvar);
            EditarTarefaCommand = new Command<Tarefa>(EditarTarefa);
            ExcluirTarefaCommand = new Command<Tarefa>(ExcluirTarefa);
            MudarSituacaoCommand = new Commands.MudarSituacaoCommand(this);
            //MudarSituacaoCommand = new Command<Tarefa>(MudarSituacao);
        }
        /*
        private void MudarSituacao(Tarefa tarefa)
        {
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

            
            for (int i = 0;i < Tarefas.Count; i++)
            {
                if(Tarefas[i].Id == tarefa.Id)
                {
                    Tarefas[i] = tarefa;
                }
            }
        }*/
        private void ExcluirTarefa(Tarefa tarefa)
        {
            new TarefasDataAccess().ExcluirTarefa(tarefa);
            Tarefas.Remove(tarefa);
        }
        private void EditarTarefa(Tarefa tarefa)
        {
            TarefaAtual = tarefa;
            OnPropertyChanged("TarefaAtual");
        }
        private void Salvar()
        {
            if(TarefaAtual.Id == 0) { 
                TarefaAtual.Finalizado = false;
                new TarefasDataAccess().SalvarTarefa(TarefaAtual);
                Tarefas.Add(TarefaAtual);
                //OnPropertyChanged("Tarefas");

                TarefaAtual = new Tarefa();
                OnPropertyChanged("TarefaAtual");
            }
            else
            {
                new TarefasDataAccess().AtualizarTarefa(TarefaAtual);
                Tarefas = new ObservableCollection<Tarefa>(new TarefasDataAccess().GetTarefas());
                OnPropertyChanged("Tarefas");

                /*
                for (int i = 0;i < Tarefas.Count; i++)
                {
                    if(Tarefas[i].Id == TarefaAtual.Id)
                    {
                        Tarefas[i] = TarefaAtual;
                    }
                }*/

                TarefaAtual = new Tarefa();
                OnPropertyChanged("TarefaAtual");
            }
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
