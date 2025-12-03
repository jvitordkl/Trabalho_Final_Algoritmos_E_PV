namespace Atividade_Final.Forms
{
    partial class Form_Votacao_Interativa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Numero = new System.Windows.Forms.Label();
            this.bt_Number_1 = new System.Windows.Forms.Button();
            this.bt_Number_2 = new System.Windows.Forms.Button();
            this.bt_Number_3 = new System.Windows.Forms.Button();
            this.bt_Number_6 = new System.Windows.Forms.Button();
            this.bt_Number_5 = new System.Windows.Forms.Button();
            this.bt_Number_4 = new System.Windows.Forms.Button();
            this.bt_Number_9 = new System.Windows.Forms.Button();
            this.bt_Number_8 = new System.Windows.Forms.Button();
            this.bt_Number_7 = new System.Windows.Forms.Button();
            this.bt_Votar = new System.Windows.Forms.Button();
            this.bt_Number_0 = new System.Windows.Forms.Button();
            this.bt_Apagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nome});
            this.dgvCandidatos.Location = new System.Drawing.Point(12, 51);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.RowHeadersWidth = 51;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.Size = new System.Drawing.Size(394, 387);
            this.dgvCandidatos.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "VOTAÇÂO INTERATIVA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMERO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Numero
            // 
            this.lb_Numero.BackColor = System.Drawing.Color.White;
            this.lb_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Numero.Location = new System.Drawing.Point(515, 99);
            this.lb_Numero.Name = "lb_Numero";
            this.lb_Numero.Size = new System.Drawing.Size(192, 31);
            this.lb_Numero.TabIndex = 5;
            this.lb_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_Number_1
            // 
            this.bt_Number_1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Number_1.Location = new System.Drawing.Point(516, 134);
            this.bt_Number_1.Name = "bt_Number_1";
            this.bt_Number_1.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_1.TabIndex = 6;
            this.bt_Number_1.Text = "1";
            this.bt_Number_1.UseVisualStyleBackColor = true;
            this.bt_Number_1.Click += new System.EventHandler(this.bt_Number_1_Click);
            // 
            // bt_Number_2
            // 
            this.bt_Number_2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_2.Location = new System.Drawing.Point(582, 134);
            this.bt_Number_2.Name = "bt_Number_2";
            this.bt_Number_2.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_2.TabIndex = 7;
            this.bt_Number_2.Text = "2";
            this.bt_Number_2.UseVisualStyleBackColor = true;
            this.bt_Number_2.Click += new System.EventHandler(this.bt_Number_2_Click);
            // 
            // bt_Number_3
            // 
            this.bt_Number_3.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_3.Location = new System.Drawing.Point(648, 134);
            this.bt_Number_3.Name = "bt_Number_3";
            this.bt_Number_3.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_3.TabIndex = 8;
            this.bt_Number_3.Text = "3";
            this.bt_Number_3.UseVisualStyleBackColor = true;
            this.bt_Number_3.Click += new System.EventHandler(this.bt_Number_3_Click);
            // 
            // bt_Number_6
            // 
            this.bt_Number_6.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_6.Location = new System.Drawing.Point(648, 200);
            this.bt_Number_6.Name = "bt_Number_6";
            this.bt_Number_6.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_6.TabIndex = 11;
            this.bt_Number_6.Text = "6";
            this.bt_Number_6.UseVisualStyleBackColor = true;
            this.bt_Number_6.Click += new System.EventHandler(this.bt_Number_6_Click);
            // 
            // bt_Number_5
            // 
            this.bt_Number_5.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_5.Location = new System.Drawing.Point(582, 200);
            this.bt_Number_5.Name = "bt_Number_5";
            this.bt_Number_5.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_5.TabIndex = 10;
            this.bt_Number_5.Text = "5";
            this.bt_Number_5.UseVisualStyleBackColor = true;
            this.bt_Number_5.Click += new System.EventHandler(this.bt_Number_5_Click);
            // 
            // bt_Number_4
            // 
            this.bt_Number_4.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_4.Location = new System.Drawing.Point(516, 200);
            this.bt_Number_4.Name = "bt_Number_4";
            this.bt_Number_4.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_4.TabIndex = 9;
            this.bt_Number_4.Text = "4";
            this.bt_Number_4.UseVisualStyleBackColor = true;
            this.bt_Number_4.Click += new System.EventHandler(this.bt_Number_4_Click);
            // 
            // bt_Number_9
            // 
            this.bt_Number_9.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_9.Location = new System.Drawing.Point(648, 266);
            this.bt_Number_9.Name = "bt_Number_9";
            this.bt_Number_9.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_9.TabIndex = 14;
            this.bt_Number_9.Text = "9";
            this.bt_Number_9.UseVisualStyleBackColor = true;
            this.bt_Number_9.Click += new System.EventHandler(this.bt_Number_9_Click);
            // 
            // bt_Number_8
            // 
            this.bt_Number_8.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_8.Location = new System.Drawing.Point(582, 266);
            this.bt_Number_8.Name = "bt_Number_8";
            this.bt_Number_8.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_8.TabIndex = 13;
            this.bt_Number_8.Text = "8";
            this.bt_Number_8.UseVisualStyleBackColor = true;
            this.bt_Number_8.Click += new System.EventHandler(this.bt_Number_8_Click);
            // 
            // bt_Number_7
            // 
            this.bt_Number_7.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_7.Location = new System.Drawing.Point(516, 266);
            this.bt_Number_7.Name = "bt_Number_7";
            this.bt_Number_7.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_7.TabIndex = 12;
            this.bt_Number_7.Text = "7";
            this.bt_Number_7.UseVisualStyleBackColor = true;
            this.bt_Number_7.Click += new System.EventHandler(this.bt_Number_7_Click);
            // 
            // bt_Votar
            // 
            this.bt_Votar.BackColor = System.Drawing.Color.Green;
            this.bt_Votar.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Votar.ForeColor = System.Drawing.Color.White;
            this.bt_Votar.Location = new System.Drawing.Point(648, 332);
            this.bt_Votar.Name = "bt_Votar";
            this.bt_Votar.Size = new System.Drawing.Size(60, 60);
            this.bt_Votar.TabIndex = 17;
            this.bt_Votar.Text = "V";
            this.bt_Votar.UseVisualStyleBackColor = false;
            this.bt_Votar.Click += new System.EventHandler(this.bt_Votar_Click);
            // 
            // bt_Number_0
            // 
            this.bt_Number_0.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Number_0.Location = new System.Drawing.Point(582, 332);
            this.bt_Number_0.Name = "bt_Number_0";
            this.bt_Number_0.Size = new System.Drawing.Size(60, 60);
            this.bt_Number_0.TabIndex = 16;
            this.bt_Number_0.Text = "0";
            this.bt_Number_0.UseVisualStyleBackColor = true;
            this.bt_Number_0.Click += new System.EventHandler(this.bt_Number_0_Click);
            // 
            // bt_Apagar
            // 
            this.bt_Apagar.BackColor = System.Drawing.Color.Red;
            this.bt_Apagar.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.bt_Apagar.ForeColor = System.Drawing.Color.White;
            this.bt_Apagar.Location = new System.Drawing.Point(516, 332);
            this.bt_Apagar.Name = "bt_Apagar";
            this.bt_Apagar.Size = new System.Drawing.Size(60, 60);
            this.bt_Apagar.TabIndex = 15;
            this.bt_Apagar.Text = "D";
            this.bt_Apagar.UseVisualStyleBackColor = false;
            this.bt_Apagar.Click += new System.EventHandler(this.bt_Apagar_Click);
            // 
            // Form_Votacao_Interativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Votar);
            this.Controls.Add(this.bt_Number_0);
            this.Controls.Add(this.bt_Apagar);
            this.Controls.Add(this.bt_Number_9);
            this.Controls.Add(this.bt_Number_8);
            this.Controls.Add(this.bt_Number_7);
            this.Controls.Add(this.bt_Number_6);
            this.Controls.Add(this.bt_Number_5);
            this.Controls.Add(this.bt_Number_4);
            this.Controls.Add(this.bt_Number_3);
            this.Controls.Add(this.bt_Number_2);
            this.Controls.Add(this.bt_Number_1);
            this.Controls.Add(this.lb_Numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCandidatos);
            this.Name = "Form_Votacao_Interativa";
            this.Text = "Form_Votacao_Interativa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Numero;
        private System.Windows.Forms.Button bt_Number_1;
        private System.Windows.Forms.Button bt_Number_2;
        private System.Windows.Forms.Button bt_Number_3;
        private System.Windows.Forms.Button bt_Number_6;
        private System.Windows.Forms.Button bt_Number_5;
        private System.Windows.Forms.Button bt_Number_4;
        private System.Windows.Forms.Button bt_Number_9;
        private System.Windows.Forms.Button bt_Number_8;
        private System.Windows.Forms.Button bt_Number_7;
        private System.Windows.Forms.Button bt_Votar;
        private System.Windows.Forms.Button bt_Number_0;
        private System.Windows.Forms.Button bt_Apagar;
    }
}