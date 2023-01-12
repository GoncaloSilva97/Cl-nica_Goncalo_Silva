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
    public partial class Comunicacoes : Form
    {
        /// <summary>
        /// Serve para enviar uma mensagem personalisada que segue para todos os clientes
        /// recebe o assumto e o texto do email e vai enviar para cada cliente o mesmo email
        /// </summary>



        DataClasses1DataContext dc = new DataClasses1DataContext();
        Menssagens aviso = new Menssagens();
        public Comunicacoes()
        {
            InitializeComponent();
        }

        private void bt_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Donos d in dc.Donos)
                {
                    aviso.MensagemGeral(d.Email, txt_mensagens.Text.ToString(), txt_assunto.Text.ToString());
                }
                MessageBox.Show("Comunicações enviadas com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma consulta para remover!");
            }




        }
    }
}
