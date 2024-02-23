using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoFarmácia
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public string[] rg;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=ProjetoFarmacia;Uid=root;Password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//Temporariamente             
            }//fim do try
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                conexao.Close();
            }//fim do catch
        }//fim do construtor

        public void Inserir(int codigo, string nome, string telefone, string endereco, string rg)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + endereco + "','" + rg + "')";
            sql = "insert into cliente(codigo, nome, telefone, endereço, rg) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido!");
            }//fim do try
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }//fim do catch
        }//fim do método

        public void PreencherVetor()
        {
            string query = "select * from cliente";

            //Instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];
            this.rg = new string[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                telefone[i] = "";
                endereco[i] = "";
                rg[i] = "";
            }//fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contar i
            contador = 0;//Contar quantos dados eu tenho no banco
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + leitura["nome"];
                telefone[i] = "" + leitura["telefone"];
                endereco[i] = "" + leitura["endereço"];
                rg[i] = "" + leitura["rg"];
                i++;//Mudando o contador
                contador++;//Contar quantos dados tem no banco
            }//fim do while

            //Encerrar o banco
            leitura.Close();
        }//fim do método

        public int RetornarContagem()
        {
            return contador;
        }//fim do método 

        public int SelecionarPorCodigo(int id)
        {
            PreencherVetor();

            for(int i=0; i < RetornarContagem(); i++)
            {
                if (codigo[i] == id)
                {
                    return i;   
                }//fim do if
            }//fim do for
            return -1;//Flag = Bandeira|Sinal
        }//fim do método
    }//fim da classe
}//fim da DAO
