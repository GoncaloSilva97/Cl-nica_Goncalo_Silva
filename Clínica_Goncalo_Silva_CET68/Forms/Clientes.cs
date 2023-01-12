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
    public partial class Clientes : Form
    {
        /// <summary>
        /// Carrega as cores da classe cores
        /// 
        ///                 Pergunta se quremos adicionar um cliente novo
        ///                 Se a resposta for SIM
        ///
        /// Deixa todas as caixas e a listview em branco iserimos os dados do dono e do seu animal e clicamos "Salvar"
        /// Ele vai guardar o dono e o seu animal e popular a list view com esse animal.
        /// 
        ///                  Se a resposta for NÃO
        ///
        /// Vai prencher as caixas e a list view com os dados do cliente que recebeu do MainForm em paramtro
        /// Vai premitir remover esse cliente apagando os seus animais e as respectivas consultas enviando email de cancelamento
        /// com o motivo de desinscrição do cliente.
        /// Premite adicionar mais animais ao dono. 
        /// Premite remover o animal que seja selecionado na listview enviando email de cancelamento
        /// com o motivo de desinscrição do animal.
        /// Premite atravez do botao "Salvar" guardar alterações feitas ao animal.
        /// 
        /// </summary>


        DataClasses1DataContext dc = new DataClasses1DataContext();
        Menssagens aviso = new Menssagens();
        int don = -1;
        public Clientes(int Dselect)
        {
            InitializeComponent();
            don = Dselect;
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
            label1.ForeColor = Cores.Secundaria;
            label10.ForeColor = Cores.Primaria;
            label11.ForeColor = Cores.Secundaria;
            label4.ForeColor = Cores.Primaria;
            label6.ForeColor = Cores.Secundaria;

        }

        
        
        
        /// <summary>
        /// Seleciona um animal da list view
        /// </summary>
        private void lstview_animais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstview_animais.FocusedItem == null) return;
                txt_idchip.Text = lstview_animais.SelectedItems[0].SubItems[0].Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um animal!");
            }
            
        }


        /// <summary>
        /// Ao alterar o id do animal escreve os seus dados nas caixas
        /// </summary>
        private void txt_idchip_TextChanged(object sender, EventArgs e)
        {
            if (txt_idchip.Text == "")
            {
                txt_NomeAnimal.ResetText();
                txt_racaespecie.ResetText();
                txt_datanascimento.ResetText();
                return;
            }
            foreach (Animais a in dc.Animais)
            {
                if (a.IDChip == Convert.ToInt32(txt_idchip.Text))
                {
                    txt_NomeAnimal.Text = a.NomeAnimal;
                    txt_racaespecie.Text = a.EspecieRaça;
                    txt_datanascimento.Text = a.DataNascimento.ToString();
                    return;
                }
            }
        }

        /// <summary>
        /// Escreve os animais do dono em paramtro na listview
        /// </summary>
        private void EscreverLista()
        {
            lstview_animais.View = View.Details;
            lstview_animais.Columns.Clear();
            lstview_animais.Clear();
            lstview_animais.Columns.Add("IDChip");
            lstview_animais.Columns.Add("NomeAnimal");
            lstview_animais.Columns.Add("EspeciRaça");
            lstview_animais.Columns.Add("DataNascimento");

            string[] arr = new string[4];
            ListViewItem item;
            foreach (Animais a in dc.Animais)
            {
                if (don == a.IDdono)
                {
                    arr[0] = a.IDChip.ToString();
                    arr[1] = a.NomeAnimal.ToString();
                    arr[2] = a.EspecieRaça.ToString();
                    arr[3] = Convert.ToDateTime(a.DataNascimento).ToString("dd-MM-yyyy");
                    item = new ListViewItem(arr);
                    lstview_animais.Items.Add(item);
                }
            }

            for (int i = 0; i <= 3; i++)
            {
                lstview_animais.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }


        /// <summary>
        /// se o botao for SIM
        /// Registra um dono novo e o seu animal
        /// 
        /// se o botao for NÃO
        /// Registra alterações feitas ao dono selecionado no mainform
        /// 
        /// </summary>

        private void bt_guardarAlteracoes_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_Sim1.Checked == true)
                {
                    Donos d = new Donos
                    {
                        Nome = txt_dono.Text,
                        Email = txt_emaildono.Text,
                        IDCliente = Convert.ToInt32(txt_IDdono.Text),
                    };

                    Animais a = new Animais
                    {
                        NomeAnimal = txt_NomeAnimal.Text,
                        EspecieRaça = txt_racaespecie.Text,
                        IDChip = Convert.ToInt32(txt_idchip.Text),
                        DataNascimento = Convert.ToDateTime(txt_datanascimento.Text),
                        IDdono = Convert.ToInt32(txt_IDdono.Text),
                        
                    };
                    dc.Donos.InsertOnSubmit(d);
                    dc.Animais.InsertOnSubmit(a);
                    dc.SubmitChanges();
                    don = Convert.ToInt32(txt_IDdono.Text);
                    EscreverLista();
                   

                    MessageBox.Show("Cliente guardado com sucesso!!");
                }

                if (rbt_Nao1.Checked == true)
                {
                    var pesquisa = from don in dc.Donos
                                   where don.IDCliente == Convert.ToInt32(txt_IDdono.Text)
                                   select don;

                    foreach (Donos don in pesquisa)
                    {
                        don.Nome = txt_dono.Text;
                        don.Email = txt_emaildono.Text;
                        don.IDCliente = Convert.ToInt32(txt_IDdono.Text);
                    }

                    var pesquisa2 = from an in dc.Animais
                                    where an.IDdono == Convert.ToInt32(txt_IDdono.Text)
                                    select an;

                    foreach (Animais an in pesquisa2)
                    {
                        an.NomeAnimal = txt_NomeAnimal.Text;
                        an.EspecieRaça = txt_racaespecie.Text;
                        an.IDChip = Convert.ToInt32(txt_idchip.Text);
                        an.DataNascimento = Convert.ToDateTime(txt_datanascimento.Text);
                        an.IDdono = Convert.ToInt32(txt_IDdono.Text);
                    }

                    dc.SubmitChanges();
                    EscreverLista();
                    MessageBox.Show("Cliente alterado com sucesso!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Confirme que prencheu todos os dados corretamente!");
                
            }

        }

        private void bt_AddAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_Nao1.Checked == true)
                {
                    int n = 0;
                    foreach (Animais an in dc.Animais)
                    {
                        if (n < an.IDChip)
                        {
                            n = an.IDChip;
                        }
                    }
                    txt_idchip.Text = (n + 1).ToString();
                    Animais animo = new Animais
                    {
                        NomeAnimal = txt_NomeAnimal.Text,
                        EspecieRaça = txt_racaespecie.Text,
                        IDChip = Convert.ToInt32(txt_idchip.Text),
                        DataNascimento = Convert.ToDateTime(txt_datanascimento.Text),
                        IDdono = Convert.ToInt32(txt_IDdono.Text),
                    };
                    dc.Animais.InsertOnSubmit(animo);
                    dc.SubmitChanges();
                    don = Convert.ToInt32(txt_IDdono.Text);
                    EscreverLista();
                    txt_NomeAnimal.ResetText();
                    txt_racaespecie.ResetText();
                    txt_datanascimento.ResetText();
                    txt_idchip.ResetText();
                    MessageBox.Show("Animal adicionado com sucesso!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente ou verifique os dados que inseriu!");
            }


        }

        /// <summary>
        /// remove animais selecionado e as respetivas consultas e envia email de cancelamento
        /// </summary>
        private void bt_remoAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_Nao1.Checked == true)
                {
                    Animais an = new Animais();
                    var remAnimal = from ani in dc.Animais
                                    where ani.IDChip == Convert.ToInt32(txt_idchip.Text)
                                    select ani;

                    an = remAnimal.Single();
                    dc.Animais.DeleteOnSubmit(an);


                    foreach (Consultas cons in dc.Consultas)
                    {
                        if (cons.Chip == Convert.ToInt32(txt_idchip.Text))
                        {
                            dc.Consultas.DeleteOnSubmit(cons);

                            foreach (Animais a in dc.Animais)
                            {
                                foreach (Donos d in dc.Donos)
                                {
                                    foreach (Salas s in dc.Salas)
                                    {
                                        if (cons.Chip == a.IDChip && a.IDdono == d.IDCliente && s.NumeroSala == cons.Sala)
                                        {
                                            aviso.Cancelamento(d.Email, d.Nome, cons.DataHora.ToString(), s.FuncaoSala.ToString(), a.NomeAnimal.ToString(), "Desinscrição do animal na clinica");
                                        }
                                    }

                                }
                            }
                        }
                    }

                    dc.SubmitChanges();
                    EscreverLista();



                    MessageBox.Show("Animal removido com sucesso!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente e um animal!");
            }
        }

        /// <summary>
        /// remove o cliente selecionadp os animais as respetivas consultas e envia email de cancelamento
        /// </summary>
        private void bt_removercliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_Nao1.Checked == true)
                {
                    foreach (Animais a in dc.Animais)
                    {
                        if (a.IDdono == Convert.ToInt32(txt_IDdono.Text))
                        {
                            dc.Animais.DeleteOnSubmit(a);
                            foreach (Consultas cons in dc.Consultas)
                            {
                                if (cons.Chip == a.IDChip)
                                {
                                    dc.Consultas.DeleteOnSubmit(cons);
                                }
                            }
                        }

                    }
                    Donos d = new Donos();
                    var remDonos = from don in dc.Donos
                                   where don.IDCliente == Convert.ToInt32(txt_IDdono.Text)
                                   select don;

                    d = remDonos.Single();
                    dc.Donos.DeleteOnSubmit(d);
                    foreach (Donos don in dc.Donos)
                    {
                        if (don.IDCliente == Convert.ToInt32(txt_IDdono.Text))
                        {
                            foreach (Consultas cons in dc.Consultas)
                            {
                                foreach (Animais a in dc.Animais)
                                {
                                    foreach (Salas s in dc.Salas)
                                    {
                                        if (cons.Chip == a.IDChip && a.IDdono == don.IDCliente && s.NumeroSala == cons.Sala)
                                        {
                                            aviso.Cancelamento(don.Email, don.Nome, cons.DataHora.ToString(), s.FuncaoSala.ToString(), a.NomeAnimal.ToString(), "Desinscrição do cliente na clinica");
                                        }
                                    }
                                }
                            }
                        }

                    }

                    dc.SubmitChanges();
                    EscreverLista();


                    MessageBox.Show("Cliente removido com sucesso!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente para remover!");
            }
        }


        /// <summary>
        /// escreve nas caixas o cliente selecionado no mainform
        /// </summary>
        private void rbt_Nao1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Donos d in dc.Donos)
            {
                if (d.IDCliente == don)
                {
                    txt_dono.Text = d.Nome;
                    txt_IDdono.Text = d.IDCliente.ToString();
                    txt_emaildono.Text = d.Email;
                }
            }
            EscreverLista();
        }

        /// <summary>
        /// Limpa as caixas e cria os novos "id"s do cliente e animal
        /// </summary>
        private void rbt_Sim1_CheckedChanged(object sender, EventArgs e)
        {
            txt_datanascimento.ResetText();
            txt_dono.ResetText();
            txt_emaildono.ResetText();
            txt_idchip.ResetText();
            txt_IDdono.ResetText();
            txt_racaespecie.ResetText();
            lstview_animais.Items.Clear();
            lstview_animais.ResetText();


            int nd = 0;
            foreach (Donos don in dc.Donos)
            {
                if (nd < don.IDCliente)
                {
                    nd = don.IDCliente;
                    
                }
            }
            txt_IDdono.Text = (nd + 1).ToString();
            int na = 0;
            foreach (Animais an in dc.Animais)
            {
                if (na < an.IDChip)
                {
                    na = an.IDChip;

                }
            }
            txt_idchip.Text = (na + 1).ToString();
        }
    }
}
