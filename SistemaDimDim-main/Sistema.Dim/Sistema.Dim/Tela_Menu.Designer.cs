
namespace Sistema.Dim
{
    partial class Tela_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cadClientes = new System.Windows.Forms.Button();
            this.btn_cadFuncionarios = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_cadFornecedor = new System.Windows.Forms.Button();
            this.lbl_dimDim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadClientes
            // 
            this.btn_cadClientes.Location = new System.Drawing.Point(287, 111);
            this.btn_cadClientes.Name = "btn_cadClientes";
            this.btn_cadClientes.Size = new System.Drawing.Size(208, 77);
            this.btn_cadClientes.TabIndex = 0;
            this.btn_cadClientes.Text = "Cadastre Clientes";
            this.btn_cadClientes.UseVisualStyleBackColor = true;
            this.btn_cadClientes.Click += new System.EventHandler(this.btn_cadClientes_Click);
            // 
            // btn_cadFuncionarios
            // 
            this.btn_cadFuncionarios.Location = new System.Drawing.Point(287, 213);
            this.btn_cadFuncionarios.Name = "btn_cadFuncionarios";
            this.btn_cadFuncionarios.Size = new System.Drawing.Size(208, 77);
            this.btn_cadFuncionarios.TabIndex = 1;
            this.btn_cadFuncionarios.Text = "Cadastre Funcionários";
            this.btn_cadFuncionarios.UseVisualStyleBackColor = true;
            this.btn_cadFuncionarios.Click += new System.EventHandler(this.btn_cadFuncionarios_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(691, 398);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(97, 40);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_cadFornecedor
            // 
            this.btn_cadFornecedor.Location = new System.Drawing.Point(287, 320);
            this.btn_cadFornecedor.Name = "btn_cadFornecedor";
            this.btn_cadFornecedor.Size = new System.Drawing.Size(208, 77);
            this.btn_cadFornecedor.TabIndex = 4;
            this.btn_cadFornecedor.Text = "Cadastre Fornecedores";
            this.btn_cadFornecedor.UseVisualStyleBackColor = true;
            this.btn_cadFornecedor.Click += new System.EventHandler(this.btn_cadFornecedor_Click);
            // 
            // lbl_dimDim
            // 
            this.lbl_dimDim.AutoSize = true;
            this.lbl_dimDim.Location = new System.Drawing.Point(369, 60);
            this.lbl_dimDim.Name = "lbl_dimDim";
            this.lbl_dimDim.Size = new System.Drawing.Size(46, 13);
            this.lbl_dimDim.TabIndex = 6;
            this.lbl_dimDim.Text = "Dim Dim";
            // 
            // Tela_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_dimDim);
            this.Controls.Add(this.btn_cadFornecedor);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_cadFuncionarios);
            this.Controls.Add(this.btn_cadClientes);
            this.Name = "Tela_Menu";
            this.Text = "Tela_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadClientes;
        private System.Windows.Forms.Button btn_cadFuncionarios;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_cadFornecedor;
        private System.Windows.Forms.Label lbl_dimDim;
    }
}