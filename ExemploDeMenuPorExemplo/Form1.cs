using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDeMenuPorExemplo
{
    public partial class Form1 : Form
    {
        TelaAtualizar atualizar;
        TelaCadastrar cadastrar;
        TelaExcluir excluir;
        TelaConsultar consultar;
        public Form1()
        {
            
            InitializeComponent();

            atualizar = new TelaAtualizar();
            cadastrar = new TelaCadastrar();
            excluir = new TelaExcluir();
            consultar = new TelaConsultar();

        }// Fim do construtor

        private void CadastrarBotao_Click(object sender, EventArgs e)
        {
            Visible = false;
            cadastrar.ShowDialog();
            Visible = true;
        }

        private void AtualiarBotao_Click(object sender, EventArgs e)
        {
            Visible = false;
            atualizar.ShowDialog();
            Visible = true;
        }

        private void ConsultarBotao_Click(object sender, EventArgs e)
        {
            Visible = false;
            consultar.ShowDialog();
            Visible = true;
        }

        private void ExcluirBotao_Click(object sender, EventArgs e)
        {
            Visible = false;
            excluir.ShowDialog();
            Visible = true;
        }
    }
}
