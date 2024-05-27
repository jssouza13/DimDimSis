
namespace Sistema.Dim
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Acessar = new System.Windows.Forms.Button();
            this.lbl_dimDim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(265, 136);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuário:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(270, 199);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_Senha.TabIndex = 1;
            this.lbl_Senha.Text = "Senha:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(337, 133);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(134, 20);
            this.txt_Usuario.TabIndex = 2;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(337, 192);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(134, 20);
            this.txt_Senha.TabIndex = 3;
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.Location = new System.Drawing.Point(304, 285);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(166, 51);
            this.btn_Acessar.TabIndex = 4;
            this.btn_Acessar.Text = "Acessar";
            this.btn_Acessar.UseVisualStyleBackColor = true;
            this.btn_Acessar.Click += new System.EventHandler(this.btn_Acessar_Click);
            // 
            // lbl_dimDim
            // 
            this.lbl_dimDim.AutoSize = true;
            this.lbl_dimDim.Location = new System.Drawing.Point(365, 44);
            this.lbl_dimDim.Name = "lbl_dimDim";
            this.lbl_dimDim.Size = new System.Drawing.Size(46, 13);
            this.lbl_dimDim.TabIndex = 5;
            this.lbl_dimDim.Text = "Dim Dim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_dimDim);
            this.Controls.Add(this.btn_Acessar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Acessar;
        private System.Windows.Forms.Label lbl_dimDim;
    }
}

