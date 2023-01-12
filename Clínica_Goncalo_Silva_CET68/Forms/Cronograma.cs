using Clínica_Goncalo_Silva_CET68.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clínica_Goncalo_Silva_CET68.Forms
{
    public partial class Cronograma : Form
    {
        /// <summary>
        /// Recebe as cores para o childform e escreve numa datagridview a lista de todas as consultas
        /// existentes na base de dados
        /// </summary>


        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Cronograma()
        {
            InitializeComponent();
            CarregarCor();
            EscreverLista();


        }

        private void CarregarCor()
        {
            foreach (Control bt in this.Controls)
            {
                if (bt.GetType() == typeof(Button))
                {
                    Button btn = (Button)bt;
                    btn.BackColor = Cores.Primaria;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Cores.Secundaria;
                }
            }
            label11.ForeColor = Cores.Secundaria;
            

        }

        /// <summary>
        /// Escreve a lista com todas as consultas
        /// </summary>
        private void EscreverLista()
        {
            string nomemed = "";
            string tipo = "";
            string nomeani = "";

            dataGridView1.Columns.Add("colId", "Paciente");
            dataGridView1.Columns.Add("colTitulo", "Sala");
            dataGridView1.Columns.Add("colCategoria", "Data - Hora");
            dataGridView1.Columns.Add("colId", "Consulta");
            dataGridView1.Columns.Add("colTitulo", "Médico");
            dataGridView1.Columns.Add("colCategoria", "Tipo de Consulta");

            var outralista = from Consultas in dc.Consultas select Consultas;
            int linha = 0;
            DataGridViewCellStyle estilo = new DataGridViewCellStyle();


            foreach (Consultas c in dc.Consultas)
            {
                DataGridViewRow registo = new DataGridViewRow();
                foreach (Animais a in dc.Animais)
                {
                    if (a.IDChip == c.Chip)
                    {
                        nomeani = a.NomeAnimal;
                    }
                }
                foreach (Medicos m in dc.Medicos)
                {
                    if (m.IDMedico == c.Medico)
                    {
                        nomemed = m.NomeMedico;
                    }
                }
                foreach (Salas s in dc.Salas)
                {
                    if (s.NumeroSala == c.Sala)
                    {
                        tipo = s.FuncaoSala;
                    }
                }
                dataGridView1.Rows.Add(registo);
                dataGridView1.Rows[linha].Cells[0].Value = nomeani;
                dataGridView1.Rows[linha].Cells[1].Value = c.Sala.ToString();
                dataGridView1.Rows[linha].Cells[2].Value = c.DataHora.ToString();
                dataGridView1.Rows[linha].Cells[3].Value = c.IDConsulta.ToString();
                dataGridView1.Rows[linha].Cells[4].Value = nomemed;
                dataGridView1.Rows[linha].Cells[5].Value = tipo.ToString();

                linha++;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
