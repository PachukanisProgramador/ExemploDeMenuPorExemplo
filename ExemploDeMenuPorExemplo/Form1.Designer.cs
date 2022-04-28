
namespace ExemploDeMenuPorExemplo
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
            this.CadastrarBotao = new System.Windows.Forms.Button();
            this.AtualiarBotao = new System.Windows.Forms.Button();
            this.ConsultarBotao = new System.Windows.Forms.Button();
            this.ExcluirBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadastrarBotao
            // 
            this.CadastrarBotao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CadastrarBotao.FlatAppearance.BorderSize = 0;
            this.CadastrarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadastrarBotao.Location = new System.Drawing.Point(25, 280);
            this.CadastrarBotao.Name = "CadastrarBotao";
            this.CadastrarBotao.Size = new System.Drawing.Size(183, 26);
            this.CadastrarBotao.TabIndex = 0;
            this.CadastrarBotao.Text = "Cadastrar";
            this.CadastrarBotao.UseVisualStyleBackColor = false;
            this.CadastrarBotao.Click += new System.EventHandler(this.CadastrarBotao_Click);
            // 
            // AtualiarBotao
            // 
            this.AtualiarBotao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AtualiarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtualiarBotao.Location = new System.Drawing.Point(214, 280);
            this.AtualiarBotao.Name = "AtualiarBotao";
            this.AtualiarBotao.Size = new System.Drawing.Size(183, 26);
            this.AtualiarBotao.TabIndex = 1;
            this.AtualiarBotao.Text = "Atualizar";
            this.AtualiarBotao.UseVisualStyleBackColor = false;
            this.AtualiarBotao.Click += new System.EventHandler(this.AtualiarBotao_Click);
            // 
            // ConsultarBotao
            // 
            this.ConsultarBotao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConsultarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultarBotao.Location = new System.Drawing.Point(403, 280);
            this.ConsultarBotao.Name = "ConsultarBotao";
            this.ConsultarBotao.Size = new System.Drawing.Size(183, 26);
            this.ConsultarBotao.TabIndex = 2;
            this.ConsultarBotao.Text = "Consultar";
            this.ConsultarBotao.UseVisualStyleBackColor = false;
            this.ConsultarBotao.Click += new System.EventHandler(this.ConsultarBotao_Click);
            // 
            // ExcluirBotao
            // 
            this.ExcluirBotao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExcluirBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirBotao.Location = new System.Drawing.Point(592, 280);
            this.ExcluirBotao.Name = "ExcluirBotao";
            this.ExcluirBotao.Size = new System.Drawing.Size(183, 26);
            this.ExcluirBotao.TabIndex = 3;
            this.ExcluirBotao.Text = "Excluir";
            this.ExcluirBotao.UseVisualStyleBackColor = false;
            this.ExcluirBotao.Click += new System.EventHandler(this.ExcluirBotao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExcluirBotao);
            this.Controls.Add(this.ConsultarBotao);
            this.Controls.Add(this.AtualiarBotao);
            this.Controls.Add(this.CadastrarBotao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CadastrarBotao;
        private System.Windows.Forms.Button AtualiarBotao;
        private System.Windows.Forms.Button ConsultarBotao;
        private System.Windows.Forms.Button ExcluirBotao;
    }
}

