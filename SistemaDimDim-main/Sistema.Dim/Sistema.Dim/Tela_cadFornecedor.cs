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
    public partial class Tela_cadFornecedor : Form
    {
        public Tela_cadFornecedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_cadFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_retMenu_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_Menu = new Tela_Menu();
            tela_Menu.Show();
        }

        private void btn_cadFornecedor_Click(object sender, EventArgs e)
        {
            if (txt_codFornecedor.Text == "" || txt_nomeFornecedor.Text == "" || txt_cnpjFornecedor.Text == "" || txt_telFornecedor.Text == "" || txt_endFornecedor.Text == "" || txt_numFornecedor.Text == "" || txt_bairroFornecedor.Text == "" || txt_cidadeFornecedor.Text == "" || txt_ufFornecedor.Text == "" || txt_cepFornecedor.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
            else
            {
                MessageBox.Show("Cadastro concluído com sucesso!");
                txt_codFornecedor.Text = "";
                txt_nomeFornecedor.Text = "";
                txt_cnpjFornecedor.Text = "";
                txt_telFornecedor.Text = "";
                txt_endFornecedor.Text = "";
                txt_numFornecedor.Text = "";
                txt_bairroFornecedor.Text = "";
                txt_cidadeFornecedor.Text = "";
                txt_ufFornecedor.Text = "";
                txt_cepFornecedor.Text = "";
            }
        }
    }
}
