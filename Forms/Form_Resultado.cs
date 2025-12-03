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
    public partial class Form_Resultado : Form
    {
        List<Candidato> lista_Candidato = new List<Candidato>();
        public Form_Resultado()
        {
            InitializeComponent();

            var pasta = new XLWorkbook("C:\\Users\\Vitor\\Desktop\\Programacao\\Atividade_Final\\candidatos.xlsx");
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
                candidato.voto = Convert.ToInt32(plan1.Cell(i, 6).Value.ToString());

                lista_Candidato.Add(candidato);
            }
            lista_Candidato.OrderBy(x => x.voto);
            foreach (var perfil in lista_Candidato)
            {
                dgvCandidatos.Rows.Add(perfil.numero,
                                        perfil.nome,
                                        perfil.apelido,
                                        perfil.voto);
            }

            lb_Votos_Branco.Text = plan1.Cell(1,8).Value.ToString();
            lb_Votos_Nulos.Text = plan1.Cell(1,9).Value.ToString();
        }
    }
}
