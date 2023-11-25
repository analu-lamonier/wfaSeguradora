using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaProjetoFinal
{
    internal class ConexaoString
    {

        string serverName = "localhost"; // localhost 
        string port = "5432"; // porta default
        string userName = "postgres"; // nome do administrador
        string password = "senha123"; // Senha do SGDB
        string dataBaseName = "bdSeguro"; // Nome do Banco de Dados

        public string Conectar()
        {
            //var connString = String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3}, Database = {4};", 
                //serverName, port, userName, password, dataBaseName);

            var connString = "Server =" + serverName + ";Port =" + port + ";Username =" + userName + ";Password =" + password + ";Database =" + dataBaseName;

            return connString;
        }



    }
}
