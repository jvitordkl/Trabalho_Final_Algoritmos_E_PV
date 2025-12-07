namespace Atividade_Final
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
            this.btCadastrarCandidato = new System.Windows.Forms.Button();
            this.bt_Votacao_Interativa = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCadastrarCandidato
            // 
            this.btCadastrarCandidato.BackColor = System.Drawing.Color.PaleGreen;
            this.btCadastrarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCandidato.Location = new System.Drawing.Point(276, 115);
            this.btCadastrarCandidato.Name = "btCadastrarCandidato";
            this.btCadastrarCandidato.Size = new System.Drawing.Size(293, 55);
            this.btCadastrarCandidato.TabIndex = 0;
            this.btCadastrarCandidato.Text = "CADASTRAR CANDIDATO";
            this.btCadastrarCandidato.UseVisualStyleBackColor = false;
            this.btCadastrarCandidato.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Votacao_Interativa
            // 
            this.bt_Votacao_Interativa.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_Votacao_Interativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Votacao_Interativa.Location = new System.Drawing.Point(276, 176);
            this.bt_Votacao_Interativa.Name = "bt_Votacao_Interativa";
            this.bt_Votacao_Interativa.Size = new System.Drawing.Size(293, 55);
            this.bt_Votacao_Interativa.TabIndex = 1;
            this.bt_Votacao_Interativa.Text = "VOTAÇÃO";
            this.bt_Votacao_Interativa.UseVisualStyleBackColor = false;
            this.bt_Votacao_Interativa.Click += new System.EventHandler(this.bt_Votacao_Interativa_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.Location = new System.Drawing.Point(276, 237);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(293, 55);
            this.bt_Reset.TabIndex = 2;
            this.bt_Reset.Text = "RESETAR SIMULAÇÃO";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIMULADOR DE ELEIÇÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acadêmicos:\r\nJoão Vitor Alvernaz Mariano\r\nNawane Krauze de Souza\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.bt_Votacao_Interativa);
            this.Controls.Add(this.btCadastrarCandidato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarCandidato;
        private System.Windows.Forms.Button bt_Votacao_Interativa;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

