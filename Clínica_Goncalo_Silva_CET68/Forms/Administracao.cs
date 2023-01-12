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
    public partial class Administracao : Form
    {
        /// <summary>
        /// Carrega as cores da classe cores
        /// Escreve na listview a lista de todos os medicos, o seu id e a sua função 
        /// Premite inserir um medico novo, alterar um existente, e apagar todas as consultas de
        /// um medico especifico selecionado na listview
        /// </summary>


        DataClasses1DataContext dc = new DataClasses1DataContext();
        Menssagens aviso = new Menssagens();   
        public Administracao()
        {
            InitializeComponent();
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
            label1.ForeColor = Cores.Primaria;
            label10.ForeColor = Cores.Primaria;
            label11.ForeColor = Cores.Primaria;
            label4.ForeColor = Cores.Primaria;
            label6.ForeColor = Cores.Primaria;
        }

        /// <summary>
        /// escreve a lista dos medicos
        /// </summary>
        private void EscreverLista()
        {
            lstview_medicos.View = View.Details;
            lstview_medicos.Columns.Clear();
            lstview_medicos.Clear();
            lstview_medicos.Columns.Add("Nome");
            lstview_medicos.Columns.Add("ID");
            lstview_medicos.Columns.Add("Função");

            string[] arr = new string[3];
            ListViewItem item;
            foreach (Medicos m in dc.Medicos)
            {
                arr[0] = m.NomeMedico;
                arr[1] = m.IDMedico.ToString();
                arr[2] = m.FuncaoMedico;
                item = new ListViewItem(arr);
                lstview_medicos.Items.Add(item);
            }

            for (int i = 0; i <= 2; i++)
            {
                lstview_medicos.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }




        /// <summary>
        /// Premite selecionar um medico da listview
        /// 
        private void lstview_medicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstview_medicos.FocusedItem == null) return;
                txt_NomeMedico.Text = lstview_medicos.SelectedItems[0].SubItems[0].Text;
                txt_FuncaoMedico.Text = lstview_medicos.SelectedItems[0].SubItems[2].Text;
                txt_IDmedico.Text = lstview_medicos.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Médico!");
            }

        }

        /// <summary>
        /// Premite guardar um medico novo ou alterações fetas a um medico selecionado da listview
        /// </summary>
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (txt_FuncaoMedico.Text != "Cirurgia" && txt_FuncaoMedico.Text != "Consulta" && txt_FuncaoMedico.Text != "Tosquia")
            {
                MessageBox.Show("ERRO -> As funções só podem ser Cirurgia, Consulta ou Tosquia");
                return;
            }

            try
            {
                if (txt_IDmedico.Text != "")
                {
                    var pesquisa = from medi in dc.Medicos
                                   where medi.IDMedico == Convert.ToInt32(txt_IDmedico.Text)
                                   select medi;

                    foreach (Medicos medi in pesquisa)
                    {
                        medi.NomeMedico = txt_NomeMedico.Text;
                        medi.FuncaoMedico = txt_FuncaoMedico.Text;
                        medi.IDMedico = Convert.ToInt32(txt_IDmedico.Text);
                    }

                    dc.SubmitChanges();
                    MessageBox.Show("Medico alterado com sucesso!!");
                }


                if (txt_IDmedico.Text == "")
                {
                    int nm = 0;
                    foreach (Medicos med in dc.Medicos)
                    {
                        if (nm < med.IDMedico)
                        {
                            nm = med.IDMedico;
                        }
                    }

                    Medicos me = new Medicos
                    {
                        NomeMedico = txt_NomeMedico.Text,
                        FuncaoMedico = txt_FuncaoMedico.Text,
                        IDMedico = (nm + 1),
                    };
                    dc.Medicos.InsertOnSubmit(me);

                    dc.SubmitChanges();
                    MessageBox.Show("Medico adicionado com sucesso!!");
                }
                EscreverLista();
            }
            catch (Exception)
            {
                MessageBox.Show("Obrigatorio prencher todos os dados!");
            }
        }

        /// <summary>
        /// Premite apagar um medico selecionado da listview e todas as suas consultas
        /// </summary>
        private void bt_remoMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_IDmedico.Text != "")
                {
                    Medicos me = new Medicos();
                    var remMedico = from med in dc.Medicos
                                    where med.IDMedico == Convert.ToInt32(txt_IDmedico.Text)
                                    select med;

                    me = remMedico.Single();
                    dc.Medicos.DeleteOnSubmit(me);

                    foreach (Consultas cons in dc.Consultas)
                    {
                        if (cons.Medico == Convert.ToInt32(txt_IDmedico.Text))
                        {
                            dc.Consultas.DeleteOnSubmit(cons);
                            
                        }
                    }


                    foreach (Consultas c in dc.Consultas)
                    {
                        if (c.Medico == Convert.ToInt32(txt_IDmedico.Text))
                        {
                            foreach (Animais a in dc.Animais)
                            {
                                foreach (Donos d in dc.Donos)
                                {
                                    foreach (Salas s in dc.Salas)
                                    {
                                        if (c.Chip == a.IDChip && a.IDdono == d.IDCliente && s.NumeroSala == c.Sala)
                                        {
                                            aviso.Cancelamento(d.Email, d.Nome, c.DataHora.ToString(), s.FuncaoSala.ToString(), a.NomeAnimal.ToString(), "Motivos de força maior");
                                        }
                                    }

                                }
                            }
                        }

                    }
                    dc.SubmitChanges();
                    EscreverLista();


                    MessageBox.Show("Médico removido com sucesso!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um médico para remover!");
            }
        }



        /// <summary>
        /// limpa as caixas de texto
        /// </summary>
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_FuncaoMedico.ResetText();
            txt_IDmedico.ResetText();
            txt_NomeMedico.ResetText();
        }


        /// <summary>
        /// Premite cancelar todas as cpnsultas de um medico selecionado na listview
        /// </summary>
        private void bt_cancelarConsultas_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_IDmedico.Text != "")
                {

                    foreach (Consultas c in dc.Consultas)
                    {
                        if (c.Medico == Convert.ToInt32(txt_IDmedico.Text))
                        {
                            foreach (Animais a in dc.Animais)
                            {
                                foreach (Donos d in dc.Donos)
                                {
                                    foreach (Salas s in dc.Salas)
                                    {
                                        if (c.Chip == a.IDChip && a.IDdono == d.IDCliente && s.NumeroSala == c.Sala)
                                        {
                                            aviso.Cancelamento(d.Email, d.Nome, c.DataHora.ToString(), s.FuncaoSala.ToString(), a.NomeAnimal.ToString(), "Motivos de força maior");
                                        }
                                    }

                                }
                            }
                        }

                    }
                    foreach (Consultas cons in dc.Consultas)
                    {
                        if (cons.Medico == Convert.ToInt32(txt_IDmedico.Text))
                        {
                            dc.Consultas.DeleteOnSubmit(cons);
                            dc.SubmitChanges();
                        }
                    }
                    MessageBox.Show("Consultas do médico canceladas com sucesso!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um médico para cancelar consultas!");
            }
        }
    }










}

