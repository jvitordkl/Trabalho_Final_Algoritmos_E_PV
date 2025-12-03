namespace Atividade_Final.Forms
{
    partial class Resultado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Votos_Branco = new System.Windows.Forms.Label();
            this.lb_Votos_Nulos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOTOS EM BRANCO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESULTADO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Votos_Branco
            // 
            this.lb_Votos_Branco.BackColor = System.Drawing.Color.White;
            this.lb_Votos_Branco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Votos_Branco.Location = new System.Drawing.Point(569, 115);
            this.lb_Votos_Branco.Name = "lb_Votos_Branco";
            this.lb_Votos_Branco.Size = new System.Drawing.Size(219, 29);
            this.lb_Votos_Branco.TabIndex = 2;
            this.lb_Votos_Branco.Text = "0";
            this.lb_Votos_Branco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Votos_Nulos
            // 
            this.lb_Votos_Nulos.BackColor = System.Drawing.Color.White;
            this.lb_Votos_Nulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Votos_Nulos.Location = new System.Drawing.Point(569, 192);
            this.lb_Votos_Nulos.Name = "lb_Votos_Nulos";
            this.lb_Votos_Nulos.Size = new System.Drawing.Size(219, 29);
            this.lb_Votos_Nulos.TabIndex = 4;
            this.lb_Votos_Nulos.Text = "0";
            this.lb_Votos_Nulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 56);
            this.label5.TabIndex = 3;
            this.label5.Text = "VOTOS EM NULO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nome,
            this.apelido});
            this.dataGridView1.Location = new System.Drawing.Point(13, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 150);
            this.dataGridView1.TabIndex = 5;
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
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_Votos_Nulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Votos_Branco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Resultado";
            this.Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Votos_Branco;
        private System.Windows.Forms.Label lb_Votos_Nulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelido;
    }
}