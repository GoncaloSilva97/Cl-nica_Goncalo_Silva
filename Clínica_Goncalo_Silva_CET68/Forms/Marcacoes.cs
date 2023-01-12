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
    public partial class Marcacoes : Form
    {
        /// <summary>
        /// Carrega as cores da classe cores
        /// Vai prencher a combobox dos animais com os animais do cliente que recebeu do MainForm em paramtro
        /// Ao selecionar um animal vai escrever na datagridview a lista de todas as suas consultas marcadas e nas caixas 
        /// dos "Dados do Animal" a sua raça/especie, o numero de identificação e a data de nascimento.
        /// Ao selecionar uma consulta podemos apagala atravez do botão "Apagar Marcações"
        /// 
        ///                     Para fazer marcações
        ///                     
        /// Selecionamos o tipo de consulta (cirurgia, Consulta e Tosquia), selecionamos um dos horarios disponivei
        /// uma sala e um medico (a sala como o medico são disponibilizados consuante a sua função que vai ser igual ao 
        /// tipo de consulta selecionado )
        /// 
        ///         A aplicação não premite nem um medico nem um animal ter duas consultas a mesma hora, se o medico ou a sala 
        ///         ja estiverem ocupados não vai ser possivel selecionalos
        ///    
        /// Ao clicar fazer marcaçao ele regista a consulta
        /// </summary>




        DataClasses1DataContext dc = new DataClasses1DataContext();
        Menssagens aviso = new Menssagens();

        int don = -1;
        int index = -1;
        public Marcacoes(int Dselect)
        {
            InitializeComponent();
            don = Dselect;
            txt_idchip.Clear();
            txt_racaespecie.Clear();
            txt_datanascimento.Clear();
            PopularAnimais();
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
        private void Marcacoes_Load(object sender, EventArgs e)
        {
            
            radioButtonCirurgia.Enabled = false;
            radioButtonConsulta.Enabled = false;
            radioButtonTosquia.Enabled = false;
            comboBoxMedico.Enabled = false;
            comboBoxHorario.Enabled = false;
            comboBoxSala.Enabled = false;
            buttonFazerMarcacao.Enabled = false;

        } 

        /// <summary>
        /// Escreve a lista de animais na combobox
        /// </summary>
        private void PopularAnimais()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dataGridView1.Columns.Clear();
            foreach (Donos d in dc.Donos)
            {
                if (d.IDCliente == don)
                {
                    
                    comboBoxAnimais.Items.Clear();
                    comboBoxAnimais.ResetText();
                    foreach (Animais a in dc.Animais)
                    {
                        if (don == a.IDdono)
                        {
                            comboBoxAnimais.Items.Add(a.NomeAnimal);
                        }
                    }
                }
            }
        } 

        /// <summary>
        /// Escreve as caixas dos dados do animal selecionado
        /// Verifica se ha medicos de cada tipo de consulta se por ex: nao houver nenhum de tosquia 
        /// a opção de tosquia fica desativada
        /// </summary>
        private void comboBoxAnimais_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxAnimais.Text == "")
            {
                radioButtonCirurgia.Enabled = false;
                radioButtonConsulta.Enabled = false;
                radioButtonTosquia.Enabled = false;
                comboBoxMedico.Enabled = false;
                comboBoxHorario.Enabled = false;
                comboBoxSala.Enabled = false;
                buttonFazerMarcacao.Enabled = false;
            }
            foreach (Animais a in dc.Animais)
            {
                if (a.NomeAnimal == comboBoxAnimais.Text && a.IDdono == don)
                {
                    txt_racaespecie.Text = a.EspecieRaça;
                    txt_idchip.Text = a.IDChip.ToString();
                    txt_datanascimento.Text = a.DataNascimento.ToString();
                    EscreverMarcacao(a.IDChip);
                    break;
                }
            }
            if (comboBoxAnimais.Text != "")
            {
                foreach (Medicos m in dc.Medicos)
                {
                    if (m.FuncaoMedico == "Tosquia")
                    {
                        radioButtonTosquia.Enabled = true;
                    }
                    if (m.FuncaoMedico == "Cirurgia")
                    {
                        radioButtonCirurgia.Enabled = true;
                    }
                    if (m.FuncaoMedico == "Consulta")
                    {
                        radioButtonConsulta.Enabled = true;
                    }
                }





            }

        }

        /// <summary>
        /// Escreve na datagrid view as consultas do animal selecionado
        /// </summary>
        private void EscreverMarcacao(int ID)
        {
            string nomemed = "";
            string tipo = "";
            string nomeani = "";
            dataGridView1.Columns.Clear();
            var outralista = from Consultas in dc.Consultas select Consultas;
            int linha = 0;

            dataGridView1.Columns.Add("nompaciente", "Paciente");
            dataGridView1.Columns.Add("numsala", "Sala");
            dataGridView1.Columns.Add("data", "Data - Hora");
            dataGridView1.Columns.Add("numconsulta", "Consulta");
            dataGridView1.Columns.Add("nommedico", "Médico");
            dataGridView1.Columns.Add("tipoconsulta", "Tipo de Consulta");


            try
            {
                foreach (Consultas c in dc.Consultas)
                {
                    if (ID == c.Chip)
                    {
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
                        DataGridViewRow registo = new DataGridViewRow();
                        dataGridView1.Rows.Add(registo);
                        dataGridView1.Rows[linha].Cells[0].Value = nomeani;
                        dataGridView1.Rows[linha].Cells[1].Value = c.Sala.ToString();
                        dataGridView1.Rows[linha].Cells[2].Value = c.DataHora.ToString();
                        dataGridView1.Rows[linha].Cells[3].Value = c.IDConsulta.ToString();
                        dataGridView1.Rows[linha].Cells[4].Value = nomemed;
                        dataGridView1.Rows[linha].Cells[5].Value = tipo.ToString();
                        linha++;
                    }

                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!!");
            }


        }    

        /// <summary>
        /// Escreve os horarios disponiveis são sempre das 18h as 20h e dos 3 dias asseguir
        /// </summary>
        private void DadosMarcacoes()
        {
            comboBoxHorario.Items.Clear();
            comboBoxMedico.Items.Clear();
            comboBoxSala.Items.Clear();
            comboBoxHorario.ResetText();
            comboBoxMedico.ResetText();
            comboBoxSala.ResetText();
            comboBoxHorario.Enabled = true;

            for (int i = 1; i <= 3; i++)
            {

                comboBoxHorario.Items.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy 18:00:00"));
                comboBoxHorario.Items.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy 18:30:00"));
                comboBoxHorario.Items.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy 19:00:00"));
                comboBoxHorario.Items.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy 19:30:00"));
                comboBoxHorario.Items.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy 20:00:00"));


            }

        }

        /// <summary>
        /// Recebe o tipo de consulta e a sua hora para escreve nas respetivas comboboxes os 
        /// medicos e as salas que tem como função o tipo de consulta selecionado e estão disponiveis
        /// aquela hora
        /// </summary>
        private void DadosMedSala(string tipoconsulta, DateTime hor)
        {

            foreach (Medicos m in dc.Medicos)
            {
                if (m.FuncaoMedico == tipoconsulta)
                {
                    comboBoxMedico.Items.Add(m.NomeMedico);
                    foreach (Consultas c in dc.Consultas)
                    {
                        if (m.IDMedico == c.Medico)
                            if (hor == c.DataHora)
                            {
                                comboBoxMedico.Items.Remove(m.NomeMedico);
                            }
                    }
                }

            }
            foreach (Salas s in dc.Salas)
            {
                if (s.FuncaoSala == tipoconsulta)
                {
                    comboBoxSala.Items.Add(s.NumeroSala);
                    foreach (Consultas co in dc.Consultas)
                    {
                        if (s.NumeroSala == co.Sala)
                            if (hor == co.DataHora)
                            {
                                comboBoxSala.Items.Remove(s.NumeroSala);
                            }

                    }

                }
            }


        }

        /// <summary>
        /// os radioButtons que premitem selecionar o tipo de consulta
        /// </summary>
        private void radioButtonTosquia_CheckedChanged(object sender, EventArgs e)
        {
            DadosMarcacoes();
        }
        private void radioButtonConsulta_CheckedChanged(object sender, EventArgs e)
        {
            DadosMarcacoes();
        }
        private void radioButtonCirurgia_CheckedChanged(object sender, EventArgs e)
        {
            DadosMarcacoes();
        }

        /// <summary>
        /// depois de de selecionada a sala premite selecionar o medico
        /// </summary>
        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMedico.Enabled = true;
        }

        /// <summary>
        /// depois de de selecionada o medico premite fazer a marcação
        /// </summary>
        private void comboBoxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonFazerMarcacao.Enabled = true;
        }

        /// <summary>
        /// Ao ter um horario selecionado premite selecionar a sala
        /// </summary>
        private void comboBoxHorario_TextChanged(object sender, EventArgs e)
        {
            comboBoxSala.Enabled = true;
        }

        /// <summary>
        /// Regista a consulta atualiza a data gridview e envia e mail a comfirmar que marcou uma consulta
        /// </summary>
        private void buttonFazerMarcacao_Click(object sender, EventArgs e)
        {
            int med = 0;
            foreach (Medicos m in dc.Medicos)
            {
                if (m.NomeMedico == comboBoxMedico.Text)
                {
                    med = m.IDMedico;
                }
            }

            int nc = 0;
            foreach (Consultas co in dc.Consultas)
            {
                if (nc < co.IDConsulta)
                {
                    nc = co.IDConsulta;
                }
            }

            bool b = false;
            foreach (Consultas co in dc.Consultas)
            {
                if (co.Chip == Convert.ToInt32(txt_idchip.Text) && co.DataHora == Convert.ToDateTime(comboBoxHorario.Text))
                {
                    MessageBox.Show("Já tem marcação para essa hora!");
                    b = false;
                    comboBoxMedico.Items.Clear();
                    comboBoxMedico.ResetText();
                    comboBoxSala.Items.Clear();
                    comboBoxSala.ResetText();
                    comboBoxHorario.Items.Clear();
                    comboBoxHorario.ResetText();
                    radioButtonTosquia.Checked = false;
                    radioButtonCirurgia.Checked = false;
                    radioButtonConsulta.Checked = false;
                    return;
                }
                else
                {
                    b = true;
                }
            }

            try
            {
                if (b == true || dc.Consultas.Count() == 0)
                {
                    Consultas c = new Consultas
                    {
                        Medico = med,
                        Sala = Convert.ToInt32(comboBoxSala.Text),
                        Chip = Convert.ToInt32(txt_idchip.Text),
                        IDConsulta = (nc + 1),
                        DataHora = Convert.ToDateTime(comboBoxHorario.Text),
                    };
                    dc.Consultas.InsertOnSubmit(c);
                    dc.SubmitChanges();

                    foreach (Consultas con in dc.Consultas)
                    {
                        foreach (Animais a in dc.Animais)
                        {
                            foreach (Donos d in dc.Donos)
                            {
                                foreach (Salas s in dc.Salas)
                                {
                                    if (con.Chip == a.IDChip && a.IDdono == d.IDCliente && con.IDConsulta == (nc + 1) && s.NumeroSala == con.Sala)
                                    {
                                        aviso.Marcacao(d.Email, d.Nome, con.DataHora.ToString(), a.NomeAnimal, s.FuncaoSala);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro tente novamente!");
            }

            comboBoxHorario.Items.Clear();
            comboBoxMedico.Items.Clear();
            comboBoxSala.Items.Clear();
            comboBoxHorario.ResetText();
            comboBoxMedico.ResetText();
            comboBoxSala.ResetText();
            radioButtonCirurgia.Checked = false;
            radioButtonConsulta.Checked = false;
            radioButtonTosquia.Checked = false;
            comboBoxMedico.Enabled = false;
            comboBoxHorario.Enabled = false;
            comboBoxSala.Enabled = false;
            buttonFazerMarcacao.Enabled = false;
            EscreverMarcacao(Convert.ToInt32(txt_idchip.Text));
        }

        /// <summary>
        /// ao selecionar o horario procura o tipo de consulta e a sua hora e envia como paramtro para o
        /// "DadosMedSala();"
        /// </summary>
        private void comboBoxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hor = Convert.ToDateTime(comboBoxHorario.Text);
            string str = "";
            if (radioButtonCirurgia.Checked == true)
                str = "Cirurgia";
            if (radioButtonConsulta.Checked == true)
                str = "Consulta";
            if (radioButtonTosquia.Checked == true)
                str = "Tosquia";
            comboBoxMedico.Items.Clear();
            comboBoxMedico.ResetText();
            comboBoxSala.Items.Clear();
            comboBoxSala.ResetText();
            comboBoxSala.Enabled = true;
            comboBoxMedico.Enabled = true;
            DadosMedSala(str, hor);
        }

        /// <summary>
        /// Ao clicar na consulta que pretendemos apagar ele retira o "id" da consulta e escreve na variavel "index"
        /// </summary>
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                index = Convert.ToInt32(row.Cells[3].Value);
            }
        }

        /// <summary>
        /// Ao clicar no botão  "Apagar Marcação" vai procurar a consulta com o "id" igual ao index
        /// vai apagala e vai enviar um email a avisar que a consulta foi cancelada
        /// Vai depois atualizar a data grid view
        /// </summary>
        private void bt_apagarMarcacao_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Consultas c in dc.Consultas)
                {
                    if (c.IDConsulta == index)
                    {
                        dc.Consultas.DeleteOnSubmit(c);

                        foreach (Animais a in dc.Animais)
                        {
                            foreach (Donos d in dc.Donos)
                            {
                                foreach (Salas s in dc.Salas)
                                {
                                    if (c.Chip == a.IDChip && a.IDdono == d.IDCliente && s.NumeroSala == c.Sala)
                                    {
                                        aviso.Cancelamento(d.Email, d.Nome, c.DataHora.ToString(), s.FuncaoSala.ToString(), a.NomeAnimal.ToString(), "Motivo de força maior");
                                    }
                                }

                            }
                        }

                        dc.SubmitChanges();
                        EscreverMarcacao(Convert.ToInt32(txt_idchip.Text.ToString()));
                        index = -1;
                        MessageBox.Show("Consulta removida com sucesso!!");


                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma consulta para remover!");
            }
        }
        

       
       

        
    }

}

