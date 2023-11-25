using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaProjetoFinal
{
    internal class Carro
    {
        private string modelo;
        private string placa;
        private int ano;
        public int valor;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }
        public int Valor { get => valor; set => valor = value; }

        public Carro (string modelo, string placa, int ano, int valor)
        {
            this.modelo = modelo;
            this.placa = placa;
            this.ano = ano;
            this.valor = valor;
        }
    }
}
