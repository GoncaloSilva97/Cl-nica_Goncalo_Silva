using Clínica_Goncalo_Silva_CET68.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clínica_Goncalo_Silva_CET68.Forms
{

    public partial class MainForm : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        Menssagens aviso = new Menssagens();
        int Dselect = -1;
        
        //Campos
        private Button btCorrente;
        private Random random;
        private int tempIndex;
        private Form formActivo;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            PopularNomes();
            random = new Random();
            BT_fecharChildForm.Visible = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //Methods


        /// <summary>
        /// Procura consultas que ja tenhao passado apagas e envia email a  dizer que foram canceladas
        /// por falta de comparecencia
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {

            foreach (Consultas c in dc.Consultas)
            {
                if (c.DataHora < DateTime.Now)
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
                                    aviso.Cancelamento(d.Email, d.Nome, c.DataHora.ToString(), s.FuncaoSala.ToString(), a.NomeAnimal.ToString(), "Não ter comparecido");
                                }
                            }

                        }
                    }
                    dc.SubmitChanges();
                }
            }

            foreach (Consultas c in dc.Consultas)
            {
                if (c.DataHora.Date == DateTime.Now.Date.AddDays(1))
                {
                    foreach (Animais a in dc.Animais)
                    {
                        foreach (Donos d in dc.Donos)
                        {
                            foreach (Salas s in dc.Salas)
                            {
                                if (c.Chip == a.IDChip && a.IDdono == d.IDCliente && s.NumeroSala == c.Sala)
                                {
                                    aviso.DiaSeguinte(d.Email, d.Nome, c.DataHora.ToString(), a.NomeAnimal.ToString(), s.FuncaoSala.ToString());
                                }
                            }

                        }
                    }
                }
            }
        }


        /// <summary>
        /// escreve os nomes dos donos na combobox
        /// </summary>
        private void PopularNomes()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            combobox_nomedono.DataSource = dc.Donos;
            combobox_nomedono.DisplayMember = "Nome";
            combobox_nomedono.AutoCompleteMode = AutoCompleteMode.Suggest;
            combobox_nomedono.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        /// <summary>
        /// Ao selecionar um dono escreve o sei id na caixa de texto
        /// </summary>
        private void combobox_nomedono_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Donos d in dc.Donos)
            {
                if (d.Nome == combobox_nomedono.Text)
                {
                    txt_IDdono.Text = d.IDCliente.ToString();   
                }
            }
        }


        /// <summary>
        /// Ao escrever o id do dono prenche o resto das caixas com os dados do mesmo
        /// </summary>
        private void txt_IDdono_TextChanged(object sender, EventArgs e)
        {
            foreach (Donos d in dc.Donos)
            {
                if (d.IDCliente == Convert.ToInt32(txt_IDdono.Text))
                {
                    txt_IDdono.Text = d.IDCliente.ToString();
                    Dselect = d.IDCliente;
                    combobox_nomedono.Text = d.Nome;
                    txt_emaildono.Text = d.Email;
                }
            }

            
        }




        /// <summary>
        /// Escolhe uma cor random da classde cores envia para o childform e 
        /// </summary>
        private Color SelectCor()
        {
            int index = random.Next(Cores.ListaCores.Count);
            while (tempIndex == index)
            {
                index = random.Next(Cores.ListaCores.Count);
            }
            tempIndex = index;
            string cor = Cores.ListaCores[index];
            return ColorTranslator.FromHtml(cor);
        }

        /// <summary>
        /// Ativa o botao para  fechar o childform
        /// e atualiza as cores da user interface
        /// </summary>
        private void ActivarBt(object btnSender)
        {
            if (btnSender != null)
            {
                if (btCorrente != (Button)btnSender)
                {
                    DesativarBt();
                    Color cor = SelectCor();
                    btCorrente = (Button)btnSender;
                    btCorrente.BackColor = cor;
                    btCorrente.ForeColor = Color.White;
                    btCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PN_titulo.BackColor = cor;
                    PN_logotipo.BackColor = Cores.MudarBrilho(cor, -0.3);
                    Cores.Primaria = cor;
                    Cores.Secundaria = Cores.MudarBrilho(cor, -0.3);
                    BT_fecharChildForm.Visible = true;
                }
            }
        }

        /// <summary>
        /// Desativa o botao parafechar o childform
        /// </summary>
        private void DesativarBt()
        {
            foreach (Control previousBtn in Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 70);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        /// <summary>
        /// Abre o childform
        /// </summary>
        private void AbrirChildForm(Form childForm, object btSender)
        {
            if (formActivo != null)
                formActivo.Close();
            ActivarBt(btSender);
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PN_desktop.Controls.Add(childForm);
            this.PN_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LBL_escolha.Text = childForm.Text;
        }


        /// <summary>
        /// Fecha o childform e faz reset a user interface
        /// </summary>
        private void BT_fecharChildForm_Click(object sender, EventArgs e)
        {
            FecharChildForm();
        }
        private void FecharChildForm()
        {
            if (formActivo != null)
                formActivo.Close();
            Reset();
        }

        private void Reset()
        {
            DesativarBt();
            LBL_escolha.Text = "";
            PN_titulo.BackColor = Color.FromArgb(0, 150, 136);
            PN_logotipo.BackColor = Color.FromArgb(39, 39, 58);
            btCorrente = null;
            BT_fecharChildForm.Visible = false;
            PopularNomes();
        }

        /// <summary>
        /// Cada botão abre um dos childforms e envia os paramtros nessecarios
        /// </summary>
        private void BT_consultas_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new Forms.Marcacoes(Dselect), sender);
        }
        private void BT_administracao_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new Forms.Administracao(), sender);
        }
        private void BT_cronograma_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new Forms.Cronograma(), sender);
        }
        private void BT_clientes_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new Forms.Clientes(Dselect), sender);
        }
        private void BT_comunicacoes_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new Forms.Comunicacoes(), sender);
        }
        private void BT_creditos_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new Forms.Creditos(), sender);
        }

        
    }
}
