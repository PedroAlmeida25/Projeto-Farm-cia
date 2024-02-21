using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFarmácia
{
    public partial class Form1 : Form
    {
        DAO bd;
        public int codigo;
        public string nome;
        public string telefone;
        public string endereco;
        public string Rg;
        public Form1()
        {
            InitializeComponent();
            bd = new DAO();//Conectar a tela com a classe DAO
        }//fim do método construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }//faz o carregamento de conteúdos da minha tela

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do código

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do nome

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do endereço

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do rg

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigo);
            string name = nome;
            string tel = telefone;
            string end = endereco;
            string rg = Rg;

            bd.Inserir(cod, name, tel, end, rg);//Inserindo no BD

            //Limpando os campos
            codigo = 0;
            nome = "";
            telefone = "";
            endereco = "";
            Rg = "";
        }//fim do botão cadastrar
    }//fim da classe
}//fim do projeto
