using Atividade_Final.Forms;
using Atividade_Final.Models;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Cadastrar_Candidato form = new Form_Cadastrar_Candidato();
            form.ShowDialog();

            Disponibilizar_Votacao();
        }

        private void bt_Votacao_Interativa_Click(object sender, EventArgs e)
        {
            Form_Votacao_Interativa form = new Form_Votacao_Interativa();
            form.ShowDialog();
        }


        private void Resetar_Simulacao()
        {
            var pasta = new XLWorkbook("..\\..\\candidatos.xlsx");
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = plan1.RowsUsed().Count();
            int linhaLivre = qtdLinhas + 1;


            // Limpa todos os dados da planilha exel para que toda vez que o sistema se inicializar ele simular uma "nova" votação
            plan1.Cell(1, 8).Value = "0";
            plan1.Cell(1, 9).Value = "0";

            for (int i = qtdLinhas; i >= 2; i--)
            {
                plan1.Cell(i, 1).Value = "";
                plan1.Cell(i, 2).Value = "";
                plan1.Cell(i, 3).Value = "";
                plan1.Cell(i, 4).Value = "";
                plan1.Cell(i, 5).Value = "";
                plan1.Cell(i, 6).Value = "";
            }

            pasta.Save();

            Disponibilizar_Votacao();
        }

        private void Disponibilizar_Votacao()
        {
            var pasta = new XLWorkbook("..\\..\\candidatos.xlsx");
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = plan1.RowsUsed().Count();
            int linhaLivre = qtdLinhas + 1;

            if (plan1.RowsUsed().Count() > 2)
            {
                bt_Votacao_Interativa.Enabled = true;
            }
            else
            {
                bt_Votacao_Interativa.Enabled = false;
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            Resetar_Simulacao();
        }
    }
}
