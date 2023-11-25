using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaProjetoFinal
{
    internal class Cliente
    {

        private string nome;
        private string CPF;
        private int idade;
        private string cidade;

        public Cliente (string nome, string CPF, int idade, string cidade)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.idade = idade;
            this.cidade = cidade;
        }
        


        public string Nome { get => nome; set => nome = value; }
        public string CPF1 { get => CPF; set => CPF = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cidade { get => cidade; set => cidade = value; }
    }
}
