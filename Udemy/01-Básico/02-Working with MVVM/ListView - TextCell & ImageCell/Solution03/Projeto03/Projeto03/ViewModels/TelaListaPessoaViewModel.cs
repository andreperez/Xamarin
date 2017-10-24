using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto03.Models;

namespace Projeto03.ViewModels
{
    public class TelaListaPessoaViewModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public TelaListaPessoaViewModel()
        {
            Pessoas = new List<Pessoa>();

            Pessoas.Add(new Pessoa { Nome = "José da Costa Souza", Email = "jose.costa@gmail.com", Cargo = "Administrador" });
            Pessoas.Add(new Pessoa { Nome = "Maria da Costa Souza", Email = "jose.costa@gmail.com", Cargo = "CEO" });
            Pessoas.Add(new Pessoa { Nome = "João da Costa Souza", Email = "joao.costa@gmail.com", Cargo = "CTO" });
            Pessoas.Add(new Pessoa { Nome = "Filipe da Costa Souza", Email = "filipe.costa@gmail.com", Cargo = "Colaborador" });
            Pessoas.Add(new Pessoa { Nome = "Tiago da Costa Souza", Email = "tiago.costa@gmail.com", Cargo = "Colaborador" });
            
        }
    }
}
