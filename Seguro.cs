using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaProjetoFinal
{
    internal class Seguro
    {
        private string seguradora;
        private string seguroTipo;
        private int cotacao;
        private string cpf_seguro;

        public string Seguradora { get => seguradora; set => seguradora = value; }
       
        public string SeguroTipo { get => seguroTipo; set => seguroTipo = value; }
        public int Cotacao { get => cotacao; set => cotacao = value; }
        public string Cpf_seguro { get => cpf_seguro; set => cpf_seguro = value; }

        public Seguro (string seguradora, string seguroTipo, int cotacao, string cpf_seguro)
        {
            this.Seguradora = seguradora;           
            this.SeguroTipo = seguroTipo;
            this.Cotacao = cotacao;
            this.cpf_seguro = cpf_seguro;
        }

        
















    }
}
