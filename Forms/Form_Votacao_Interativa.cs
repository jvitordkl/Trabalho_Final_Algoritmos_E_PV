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

namespace Atividade_Final.Forms
{
    public partial class Form_Votacao_Interativa : Form
    {
        List<Candidato> lista_Candidato = new List<Candidato>();
        public Form_Votacao_Interativa()
        {
            InitializeComponent();
            var pasta = new XLWorkbook("..\\..\\candidatos.xlsx");
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = plan1.RowsUsed().Count();
            int linhaLivre = qtdLinhas + 1;

            for (int i = 2; i <= qtdLinhas; i++)
            {
                Candidato candidato = new Candidato();
                candidato.Id = Convert.ToInt32(plan1.Cell(i, 1).Value.ToString());
                candidato.nome = plan1.Cell(i, 3).Value.ToString();
                candidato.apelido = plan1.Cell(i, 4).Value.ToString();
                candidato.partido = plan1.Cell(i, 5).Value.ToString();
                candidato.numero = Convert.ToInt32(plan1.Cell(i, 2).Value.ToString());

                lista_Candidato.Add(candidato);
            }
            foreach (var perfil in lista_Candidato)
            {
                dgvCandidatos.Rows.Add(perfil.numero,
                                        perfil.nome);
            }


            Habilitar();
        }

        private void Adicionar_Numero(string digito)
        {
            string numero = lb_Numero.Text.ToString();
            numero = numero + digito;
            lb_Numero.Text = numero;
            Habilitar();
        }

        private void Habilitar()
        {
            if (lb_Numero.Text.Length == 0)
            {
                bt_Votar.Enabled = false;
                bt_Apagar.Enabled = false;
            }
            else
                if(lb_Numero.Text.Length > 0)
                {
                    bt_Votar.Enabled = true;
                    bt_Apagar.Enabled = true;
                }
        }

        private void bt_Number_1_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("1");
        }

        private void bt_Number_2_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("2");
        }

        private void bt_Number_3_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("3");
        }

        private void bt_Number_4_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("4");
        }

        private void bt_Number_5_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("5");
        }

        private void bt_Number_6_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("6");
        }

        private void bt_Number_7_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("7");
        }

        private void bt_Number_8_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("8");
        }

        private void bt_Number_9_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("9");
        }

        private void bt_Number_0_Click(object sender, EventArgs e)
        {
            Adicionar_Numero("0");
        }

        private void bt_Apagar_Click(object sender, EventArgs e)
        {
            string numero = lb_Numero.Text;
            int caracteres = lb_Numero.Text.Length;
            numero = numero.Substring(0, caracteres - 1);
            lb_Numero.Text = numero;
            Habilitar();
        }

        private void bt_Votar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook("..\\..\\candidatos.xlsx");
            var plan1 = pasta.Worksheet(1);

            string digitado = lb_Numero.Text;
            if(digitado == "00")       //Se o número digitado for igual a 00 o voto é em branco
            {
                int votos_brancos = Convert.ToInt32(plan1.Cell(1, 8).Value.ToString());
                votos_brancos = votos_brancos + 1;
                plan1.Cell(1, 8).Value = votos_brancos.ToString();
                pasta.Save();
            }
            else
                if((lista_Candidato.Any(x => x.numero.ToString() == digitado)) == false) // Verifica se o número digitado existe na lista
                                                                              // de candidatos, se não existe é considerado nulo
            {
                int votos_nulos = Convert.ToInt32(plan1.Cell(1, 9).Value.ToString());
                votos_nulos = votos_nulos + 1;
                plan1.Cell(1, 9).Value = votos_nulos.ToString();
                pasta.Save();









            }
            else   // Caso ele não entre na validação anterior significa que o número existe na lista dos candidatos, logo atribuirá o voto
                   // a ele
            {
                foreach (var escolhido in lista_Candidato)
                {
                    if (escolhido.numero == Convert.ToInt32(lb_Numero.Text))
                    {
                        int posicao = escolhido.Id + 1;
                        int qtdVotos = Convert.ToInt32(plan1.Cell(posicao, 6).Value.ToString());
                        plan1.Cell(posicao, 6).Value = qtdVotos + 1;
                        pasta.Save();
                    }
                }
            }
            lb_Numero.Text = "";
            bt_Apagar.Enabled = false;
        }

        private void bt_Encerrar_Click(object sender, EventArgs e)
        {
            Form_Resultado form = new Form_Resultado();
            form.ShowDialog();
        }

    }
}
