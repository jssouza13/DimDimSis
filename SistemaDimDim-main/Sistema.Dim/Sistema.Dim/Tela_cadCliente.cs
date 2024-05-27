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
    public partial class Tela_cadCliente : Form
    {
        public Tela_cadCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_retMenu_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_Menu = new Tela_Menu();
            tela_Menu.Show();
        }

        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            if (txt_codCliente.Text == "" || txt_lojaCliente.Text == "" || txt_cnpjCliente.Text == "" || txt_telCliente.Text == "" || txt_endCliente.Text == "" || txt_numCliente.Text == "" || txt_bairroCliente.Text == "" || txt_cidadeCliente.Text == "" || txt_ufCliente.Text == "" || txt_cepCliente.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
            else
            {
                MessageBox.Show("Cadastro concluído com sucesso!");
                txt_codCliente.Text = "";
                txt_lojaCliente.Text = "";
                txt_cnpjCliente.Text = "";
                txt_telCliente.Text = "";
                txt_endCliente.Text = "";
                txt_numCliente.Text = "";
                txt_bairroCliente.Text = "";
                txt_cidadeCliente.Text = "";
                txt_ufCliente.Text = "";
                txt_cepCliente.Text = "";
            }
        }
    }
}
