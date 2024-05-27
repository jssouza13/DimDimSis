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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "esteves" && txt_Senha.Text == "1245")
            {
                MessageBox.Show("Seja Bem-Vindo!");
                Tela_Menu tela_Menu = new Tela_Menu();
                tela_Menu.Show();
            }
            else if (txt_Usuario.Text == "jobs" && txt_Senha.Text == "468r")
            {
                MessageBox.Show("Seja Bem-Vindo!");
                Tela_Menu tela_Menu = new Tela_Menu();
                tela_Menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos!");
            }

            
        }
    }
}
