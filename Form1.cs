using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WfaProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ocultaGroupBox();
            ocultaDataGridView();
        }

        private void ocultaGroupBox()
        {
            gbCotacoesRelatorio.Visible = false;
        }

        private void ocultaDataGridView()
        {
            dGVSeguro.Visible = false;
        }


        //ABA CLIENTE 
        private void btInserirCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente(tbNome.Text, mtbCPF.Text, Convert.ToInt32(tbIdade.Text), tbCidade.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("INSERT INTO cliente1(cpf_cliente, nome_cliente, idade_cliente, cidade_cliente)" +
                "values('{0}', '{1}', '{2}', '{3}')", objCliente.CPF1, objCliente.Nome, objCliente.Idade, objCliente.Cidade);


            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand (commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Inserido com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextbox();

        }


        private void btExibirCliente_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao); //cria uma conexao com o banco

            con.Open(); //Abre a conexão com o banco

            DataTable dt = new DataTable(); //objeto que pode conter na tabela

            string commandText = "SELECT * FROM cliente1";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }

            dGV.DataSource = dt;

            con.Close();
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPF.Text;

            Cliente objCliente = new Cliente(tbNome.Text, mtbCPF.Text, Convert.ToInt32(tbIdade.Text), tbCidade.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("UPDATE cliente1 SET cpf_cLiente = '" + objCliente.CPF1 +
                "', nome_cliente = '" + objCliente.Nome + "' , idade_cliente = " + objCliente.Idade + 
                ", cidade_cliente = '" + objCliente.Cidade + "' WHERE cpf_cliente = '" + cpf + "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextbox();



        }

        private void btExcluirCliente_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPF.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("DELETE FROM cliente1 WHERE cpf_cliente = '{0}'", cpf);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Excluido com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextbox();


        }

        private void dGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbNome.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[1].Value);
            mtbCPF.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value);          
            tbIdade.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[3].Value);
            tbCidade.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[4].Value);
        }

        public void limparTextbox()
        {
            tbNome.Text = String.Empty;
            mtbCPF.Text = String.Empty;
            tbIdade.Text = String.Empty;
            tbCidade.Text = String.Empty;

        }

        //================= ABA CARRO =========================

        private void btInserirCarro_Click(object sender, EventArgs e)
        {
            Carro objCarro = new Carro(tbModelo.Text, tbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(tbValor.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("INSERT INTO carro1(modelo_carro, placa_carro, ano_carro, valor_carro)" +
                "values('{0}', '{1}', '{2}', '{3}')", objCarro.Modelo, objCarro.Placa, objCarro.Ano, objCarro.Valor);
            

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Inserido com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextboxCarro();
        }

        private void btExibirCarro_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao); //cria uma conexao com o banco

            con.Open(); //Abre a conexão com o banco

            DataTable dt = new DataTable(); //objeto que pode conter na tabela

            string commandText = "SELECT * FROM carro1";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }

            dGVCarro.DataSource = dt;

            con.Close();

        }

        private void btAtualizarCarro_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPF.Text;

            Carro objCarro = new Carro("", tbPlaca.Text, 0, Convert.ToInt32(tbValor.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("UPDATE carro1 SET valor_carro = '" + objCarro.valor + "' WHERE placa_carro = '" + objCarro.Placa + "'");

           /* string commandText = String.Format("UPDATE carro1 SET cpf_cLiente = '" + objCliente.CPF1 +
                "', nome_cliente = '" + objCarro.Modelo + "' , idade_cliente = " + objCliente.Idade +
                ", cidade_cliente = '" + objCliente.Cidade + "' WHERE cpf_cliente = '" + cpf + "'");
           */
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Valor Atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextboxCarro();



        }

        private void btExcluirCarro_Click(object sender, EventArgs e)
        {
            string placa = tbPlaca.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("DELETE FROM carro1 WHERE placa_carro = '{0}'", placa);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Excluido com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextboxCarro();
        }

        public void limparTextboxCarro()
        {
            tbModelo.Text = String.Empty;
            tbPlaca.Text = String.Empty;
            tbAno.Text = String.Empty;
            tbValor.Text = String.Empty;

        }

        private void dGVCarro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbModelo.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[1].Value);
            tbPlaca.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value);
            tbAno.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[3].Value);
            tbValor.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[4].Value);
        }

        //================= ABA SEGURO =========================

        private void btCotacao_Click(object sender, EventArgs e)
        {
            dGVSeguro.Visible = false;
            gbCotacoesRelatorio.Visible = true;

            string placa = tbPlacaSeguro.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();
            var valor = 0;

            string commandText = String.Format($"SELECT valor_carro FROM carro1 WHERE placa_carro like '%{placa}%'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                valor = Convert.ToInt32(pgsqlcommand.ExecuteScalar());        
            }


            con.Close();


            if (rbProtecao.Checked ==  true )
            {
                lbSeguradora1.Text = "Porto Seguro";

                int cotacao = 5* (valor / 100);

                lbCotacao1.Text = Convert.ToString(cotacao);


                lbSeguradora2.Text = "Tokio";

                int cotacao2 = 6 * (valor / 100); 

                lbCotacao2.Text = Convert.ToString(cotacao2);

            }
            else if (rbCobertura.Checked == true)
                {
                    lbSeguradora1.Text = "Porto Seguro";

                    int cotacao = 10 * (valor / 1000);
                    lbCotacao1.Text = Convert.ToString(cotacao);


                    lbSeguradora2.Text = "Tokio";

                    int cotacao2 = 10 * (valor / 1000); 
                    lbCotacao2.Text = Convert.ToString(cotacao2);

                }

            con.Close();
        }

        private void btContratarSeguro1_Click(object sender, EventArgs e)
        {

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();



            string tipo=""; 

            if (rbProtecao.Checked == true)
            {
               tipo = "Protecao Veicular";
            }
            else if (rbCobertura.Checked == true)
            {
                tipo = "Cobertura Completa";
            }

            Seguro objSeguro = new Seguro(lbSeguradora1.Text, tipo, Convert.ToInt32( lbCotacao1.Text), mtbCPFSeguro.Text);

            string commandText = String.Format("INSERT INTO seguro1(seguradora, seguro_tipo, cotacao_seguro, cpf_seguro)" +
                "values('{0}', '{1}', '{2}', '{3}')", objSeguro.Seguradora, objSeguro.SeguroTipo, objSeguro.Cotacao, objSeguro.Cpf_seguro);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Seguro contratado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btContratarSeguro2_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();



            string tipo = "";

            if (rbProtecao.Checked == true)
            {
                tipo = "Protecao Veicular";
            }
            else if (rbCobertura.Checked == true)
            {
                tipo = "Cobertura Completa";
            }

            Seguro objSeguro = new Seguro(lbSeguradora2.Text, tipo, Convert.ToInt32(lbCotacao2.Text), mtbCPFSeguro.Text);

            string commandText = String.Format("INSERT INTO seguro1(seguradora, seguro_tipo, cotacao_seguro, cpf_seguro)" +
                "values('{0}', '{1}', '{2}', '{3}')", objSeguro.Seguradora, objSeguro.SeguroTipo, objSeguro.Cotacao, objSeguro.Cpf_seguro);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Seguro contratado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable(); //objeto que pode conter na tabela

            string commandText = "SELECT * FROM seguro1";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }


            dGVSeguro.Visible = true;
            dGVSeguro.DataSource = dt;

            con.Close();
           
        }

        private void btExcluirSeguro_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPFSeguro.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();
            string commandText = String.Format("DELETE FROM seguro1 WHERE cpf_seguro = '{0}'",cpf);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Seguro Excluido com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btAtualizar1_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPFSeguro.Text;

            string tipo = "";

            if (rbProtecao.Checked == true)
            {
                tipo = "Protecao Veicular";
            }
            else if (rbCobertura.Checked == true)
            {
                tipo = "Cobertura Completa";
            }

            Seguro objSeguro = new Seguro(lbSeguradora1.Text, tipo, Convert.ToInt32(lbCotacao1.Text), mtbCPFSeguro.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("UPDATE seguro1 SET cotacao_seguro = '" + objSeguro.Cotacao + "' WHERE cpf_seguro = '" + objSeguro.Cpf_seguro + "';"+
                "UPDATE seguro1 SET seguradora = '" + objSeguro.Seguradora + "' WHERE cpf_seguro = '" + objSeguro.Cpf_seguro + "';"+
                "UPDATE seguro1 SET seguro_tipo = '" + objSeguro.SeguroTipo + "' WHERE cpf_seguro = '" + objSeguro.Cpf_seguro + "';") ;



            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Valor Atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btAtualizar2_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPFSeguro.Text;

            string tipo = "";

            if (rbProtecao.Checked == true)
            {
                tipo = "Protecao Veicular";
            }
            else if (rbCobertura.Checked == true)
            {
                tipo = "Cobertura Completa";
            }

            Seguro objSeguro = new Seguro(lbSeguradora2.Text, tipo, Convert.ToInt32(lbCotacao2.Text), mtbCPFSeguro.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.Conectar();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("UPDATE seguro1 SET cotacao_seguro = '" + objSeguro.Cotacao + "' WHERE cpf_seguro = '" + objSeguro.Cpf_seguro + "';" +
                 "UPDATE seguro1 SET seguradora = '" + objSeguro.Seguradora + "' WHERE cpf_seguro = '" + objSeguro.Cpf_seguro + "';" +
                "UPDATE seguro1 SET seguro_tipo = '" + objSeguro.SeguroTipo + "' WHERE cpf_seguro = '" + objSeguro.Cpf_seguro + "';");


            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Valor Atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void dGVSeguro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label5.Text = Convert.ToString(dGVSeguro.Rows[e.RowIndex].Cells[1].Value);
            lbSeguroTipo.Text = Convert.ToString(dGVSeguro.Rows[e.RowIndex].Cells[2].Value);
            lbCotacao.Text = Convert.ToString(dGVSeguro.Rows[e.RowIndex].Cells[3].Value);
            lbCPFSeguro.Text = Convert.ToString(dGVSeguro.Rows[e.RowIndex].Cells[4].Value);
        }
    }
}
