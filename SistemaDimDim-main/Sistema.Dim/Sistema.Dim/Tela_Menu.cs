using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Dim
{
    public partial class Tela_Menu : Form
    {
        public Tela_Menu()
        {
            InitializeComponent();
        }

        private void btn_cadClientes_Click(object sender, EventArgs e)
        {
            Tela_cadCliente tela_CadCliente = new Tela_cadCliente();
            tela_CadCliente.Show();
        }

        private void btn_cadFuncionarios_Click(object sender, EventArgs e)
        {
            Tela_cadFuncionario tela_CadFuncionario = new Tela_cadFuncionario();
            tela_CadFuncionario.Show();
        }

        private void btn_cadFornecedor_Click(object sender, EventArgs e)
        {
            Tela_cadFornecedor tela_CadFornecedor = new Tela_cadFornecedor();
            tela_CadFornecedor.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
        }
    }
}
