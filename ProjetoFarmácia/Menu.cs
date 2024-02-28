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
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }//faz o carregamento da tela do menu

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click cad = new button1_Click();
            cad.ShowDiaLog();//Mostrar na tela
        }//fim do método
    }//fim da classe

    internal class button1_Click
    {
        internal void ShowDiaLog()
        {
            throw new NotImplementedException();
        }//fim do método
    }//fim do método
}//fim do projeto
