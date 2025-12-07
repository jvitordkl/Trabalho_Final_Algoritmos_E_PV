using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_Final.Models;
using ClosedXML.Excel;

namespace Atividade_Final.Forms
{
    public partial class Form_Cadastrar_Candidato : Form
    {
        List <Candidato> lista_Candidato = new List <Candidato>();
        public Form_Cadastrar_Candidato()
        {
            InitializeComponent();
            var pasta = new XLWorkbook("C:\\Users\\Vitor\\Desktop\\Programacao\\Atividade_Final\\candidatos.xlsx");
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = plan1.RowsUsed().Count();
            int linhaLivre = qtdLinhas + 1;

            for(int i = 2;  i <= qtdLinhas; i++)
            {
                Candidato candidato = new Candidato();
                candidato.nome = plan1.Cell(i, 3).Value.ToString();
                candidato.apelido = plan1.Cell(i, 4).Value.ToString();
                candidato.partido = plan1.Cell(i, 5).Value.ToString();
                candidato.numero = Convert.ToInt32(plan1.Cell(i, 2).Value.ToString());
                lista_Candidato.Add(candidato);
                Atualizar_Lista();
            }
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            if(txt_Nome_Completo.Text == "")
            {
                mensagem = mensagem + "Campo Nome Completo não foi preenchido\n";
            }
            if(txt_Partido.Text == "")
            {
                mensagem = mensagem + "Campo Partido não foi preenchido\n";
            }
            if(txt_Apelido.Text == "")
            {
                mensagem = mensagem + "Campo Apelido não foi preenchido\n";
            }
            if(txt_Numero.Text == "")
            {
                mensagem = mensagem + "Campo Numero não foi preenchido\n";
            }


            if(mensagem != "")
            {
                MessageBox.Show(mensagem, "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var pasta = new XLWorkbook("C:\\Users\\Vitor\\Desktop\\Programacao\\Atividade_Final\\candidatos.xlsx");
                var plan1 = pasta.Worksheet(1);
                int qtdLinhas = plan1.RowsUsed().Count();
                int linhaLivre = qtdLinhas + 1;

                Candidato candidato = new Candidato();
                candidato.nome = txt_Nome_Completo.Text.ToString();
                candidato.apelido = txt_Apelido.Text.ToString();
                candidato.partido = txt_Partido.Text.ToString();
                candidato.numero = Convert.ToInt32(txt_Numero.Text.ToString());

                if (lista_Candidato.Any(x => x.numero == candidato.numero))
                {
                    MessageBox.Show("Esse número já está cadastrado",
                                    "ADS",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    plan1.Cell(linhaLivre, 1).Value = qtdLinhas.ToString();
                    plan1.Cell(linhaLivre, 2).Value = candidato.numero.ToString();
                    plan1.Cell(linhaLivre, 3).Value = candidato.nome.ToString();
                    plan1.Cell(linhaLivre, 4).Value = candidato.apelido.ToString();
                    plan1.Cell(linhaLivre, 5).Value = candidato.partido.ToString();
                    plan1.Cell(linhaLivre, 6).Value = 0.ToString();
                    pasta.Save();
                    lista_Candidato.Add(candidato);
                    Atualizar_Lista();
                    Limpar_Campos();
                }
            }
        }

        private void Atualizar_Lista()
        {
            dgv_Candidato.Rows.Clear();
            dgv_Candidato.Refresh();
            foreach (var perfil in lista_Candidato)
            {
                dgv_Candidato.Rows.Add(perfil.numero,
                                        perfil.nome,
                                        perfil.apelido,
                                        perfil.partido);
            }
        }
        private void Limpar_Campos()
        {
            txt_Nome_Completo.Clear();
            txt_Apelido.Clear();
            txt_Partido.Clear();
            txt_Numero.Clear();
            txt_Nome_Completo.Select();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            Limpar_Campos();
        }

        


        private void txt_Numero_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificacaoNumero = false;

            //Verificação do que foi digitado => Número ou Letra
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificacaoNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Decimal) verificacaoNumero = true; // Libera os números
                if (e.KeyCode == Keys.Enter) verificacaoNumero = true; // liberrar a tecla enter
                if (e.KeyCode == Keys.Back) verificacaoNumero = true; // liberar a tela back(apagar)
                if (e.KeyCode == Keys.Tab) verificacaoNumero = true;
            }

            // Validação Final => a mensagem vai aparecer se um dos itens não foi atendido
            if (verificacaoNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Numero.Text = txt_Numero.Text.Remove(txt_Numero.Text.Length - 1);
            }
        }

        private void txt_Apelido_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificacaoNumero = false;

            //Verificação do que foi digitado => Número ou Letra
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)))
            //A exclamão inverte o valor, liberando todas as teclas menos os números
            {
                verificacaoNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Decimal) verificacaoNumero = true; // Libera os números
                if (e.KeyCode == Keys.Enter) verificacaoNumero = true; // liberrar a tecla enter
                if (e.KeyCode == Keys.Back) verificacaoNumero = true; // liberar a tela back(apagar)
            }

            // Validação Final => a mensagem vai aparecer se um dos itens não foi atendido
            if (verificacaoNumero == false)
            {
                MessageBox.Show("Somente letras", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Apelido.Text = txt_Apelido.Text.Remove(txt_Apelido.Text.Length - 1);
            }
        }

        private void txt_Nome_Completo_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificacaoNumero = false;

            //Verificação do que foi digitado => Número ou Letra
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)))
            //A exclamão inverte o valor, liberando todas as teclas menos os números
            {
                verificacaoNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Decimal) verificacaoNumero = true; // Libera os números
                if (e.KeyCode == Keys.Enter) verificacaoNumero = true; // liberrar a tecla enter
                if (e.KeyCode == Keys.Back) verificacaoNumero = true; // liberar a tela back(apagar)
            }

            // Validação Final => a mensagem vai aparecer se um dos itens não foi atendido
            if (verificacaoNumero == false)
            {
                MessageBox.Show("Somente letras", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome_Completo.Text = txt_Nome_Completo.Text.Remove(txt_Nome_Completo.Text.Length - 1);
            }
        }

        private void txt_Partido_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificacaoNumero = false;

            //Verificação do que foi digitado => Número ou Letra
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)))
            //A exclamão inverte o valor, liberando todas as teclas menos os números
            {
                verificacaoNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Decimal) verificacaoNumero = true; // Libera os números
                if (e.KeyCode == Keys.Enter) verificacaoNumero = true; // liberrar a tecla enter
                if (e.KeyCode == Keys.Back) verificacaoNumero = true; // liberar a tela back(apagar)
            }

            // Validação Final => a mensagem vai aparecer se um dos itens não foi atendido
            if (verificacaoNumero == false)
            {
                MessageBox.Show("Somente letras", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Partido.Text = txt_Partido.Text.Remove(txt_Partido.Text.Length - 1);
            }
        }

        private void txt_Partido_Leave(object sender, EventArgs e)
        {
            if(txt_Partido.Text == "")
            {
                MessageBox.Show("Preencha corretamente o Campo Partido", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Partido.Select();
            }
            else
            {
                txt_Partido.Text = txt_Partido.Text.ToUpper();
            }
                
        }

        private void txt_Nome_Completo_Leave(object sender, EventArgs e)
        {
            if (txt_Nome_Completo.Text == "")
            {
                MessageBox.Show("Preencha corretamente o campo Nome Completo", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome_Completo.Select();
            }
        }

        private void txt_Apelido_Leave(object sender, EventArgs e)
        {
            if (txt_Apelido.Text == "")
            {
                MessageBox.Show("Preencha corretamente o campo Apelido", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Apelido.Select();
            }
        }

        private void txt_Numero_Leave(object sender, EventArgs e)
        {
            if (txt_Numero.Text == "")
            {
                MessageBox.Show("Preencha corretamente o campo Numero", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Numero.Select();
            }
        }
    }
}
