namespace Atividade_Final.Forms
{
    partial class Form_Resultado
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
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Votos_Nulos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Votos_Branco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Votos_Validos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Vencer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nome,
            this.apelido,
            this.voto});
            this.dgvCandidatos.Location = new System.Drawing.Point(13, 88);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.RowHeadersWidth = 51;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.Size = new System.Drawing.Size(775, 207);
            this.dgvCandidatos.TabIndex = 11;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 125;
            // 
            // apelido
            // 
            this.apelido.HeaderText = "APELIDO";
            this.apelido.MinimumWidth = 6;
            this.apelido.Name = "apelido";
            this.apelido.Width = 125;
            // 
            // voto
            // 
            this.voto.HeaderText = "VOTOS";
            this.voto.MinimumWidth = 6;
            this.voto.Name = "voto";
            this.voto.Width = 125;
            // 
            // lb_Votos_Nulos
            // 
            this.lb_Votos_Nulos.BackColor = System.Drawing.Color.White;
            this.lb_Votos_Nulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Votos_Nulos.Location = new System.Drawing.Point(569, 339);
            this.lb_Votos_Nulos.Name = "lb_Votos_Nulos";
            this.lb_Votos_Nulos.Size = new System.Drawing.Size(219, 29);
            this.lb_Votos_Nulos.TabIndex = 10;
            this.lb_Votos_Nulos.Text = "0";
            this.lb_Votos_Nulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "VOTOS EM NULO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Votos_Branco
            // 
            this.lb_Votos_Branco.BackColor = System.Drawing.Color.White;
            this.lb_Votos_Branco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Votos_Branco.Location = new System.Drawing.Point(300, 339);
            this.lb_Votos_Branco.Name = "lb_Votos_Branco";
            this.lb_Votos_Branco.Size = new System.Drawing.Size(219, 29);
            this.lb_Votos_Branco.TabIndex = 8;
            this.lb_Votos_Branco.Text = "0";
            this.lb_Votos_Branco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "RESULTADO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "VOTOS EM BRANCO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Votos_Validos
            // 
            this.lb_Votos_Validos.BackColor = System.Drawing.Color.White;
            this.lb_Votos_Validos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Votos_Validos.Location = new System.Drawing.Point(13, 339);
            this.lb_Votos_Validos.Name = "lb_Votos_Validos";
            this.lb_Votos_Validos.Size = new System.Drawing.Size(219, 29);
            this.lb_Votos_Validos.TabIndex = 13;
            this.lb_Votos_Validos.Text = "0";
            this.lb_Votos_Validos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 56);
            this.label4.TabIndex = 12;
            this.label4.Text = "VOTOS VÁLIDOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_Vencer
            // 
            this.bt_Vencer.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_Vencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Vencer.Location = new System.Drawing.Point(431, 383);
            this.bt_Vencer.Name = "bt_Vencer";
            this.bt_Vencer.Size = new System.Drawing.Size(357, 55);
            this.bt_Vencer.TabIndex = 14;
            this.bt_Vencer.Text = "APRESENTAR VENCEDOR";
            this.bt_Vencer.UseVisualStyleBackColor = false;
            this.bt_Vencer.Click += new System.EventHandler(this.bt_Vencer_Click);
            // 
            // Form_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Vencer);
            this.Controls.Add(this.lb_Votos_Validos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.lb_Votos_Nulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Votos_Branco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Resultado";
            this.Text = "Form_Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.Label lb_Votos_Nulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Votos_Branco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn voto;
        private System.Windows.Forms.Label lb_Votos_Validos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Vencer;
    }
}