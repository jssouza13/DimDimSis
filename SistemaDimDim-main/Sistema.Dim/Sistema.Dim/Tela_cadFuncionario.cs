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
    public partial class Tela_cadFuncionario : Form
    {
        public Tela_cadFuncionario()
        {
            InitializeComponent();
        }

        private void btn_retMenu_Click(object sender, EventArgs e)
        {
            Tela_Menu tela_Menu = new Tela_Menu();
            tela_Menu.Show();
        }

        private void btn_cadFuncionario_Click(object sender, EventArgs e)
        {
            if(txt_codFuncionario.Text == "" || txt_nomeFuncionario.Text == "" || txt_telFuncionario.Text == "" || txt_cpfFuncionario.Text == "" || txt_rgFuncionario.Text == "" || txt_cargoFuncionario.Text == "" || txt_endFuncionario.Text == "" || txt_numFuncionario.Text == "" || txt_bairroFuncionario.Text == "" || txt_cidadeFuncionario.Text == "" || txt_ufFuncionario.Text == "" || txt_cepFuncionario.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
            else
            {
                MessageBox.Show("Cadastro concluído com sucesso!");
                txt_codFuncionario.Text = "";
                txt_nomeFuncionario.Text = "";
                txt_telFuncionario.Text = "";
                txt_endFuncionario.Text = "";
                txt_numFuncionario.Text = "";
                txt_bairroFuncionario.Text = "";
                txt_cidadeFuncionario.Text = "";
                txt_ufFuncionario.Text = "";
                txt_cepFuncionario.Text = "";
            }
        }
    }
}
