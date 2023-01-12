namespace Clínica_Goncalo_Silva_CET68.Forms
{
    partial class Marcacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonCirurgia = new System.Windows.Forms.RadioButton();
            this.radioButtonConsulta = new System.Windows.Forms.RadioButton();
            this.radioButtonTosquia = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxMedico = new System.Windows.Forms.ComboBox();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.comboBoxHorario = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_datanascimento = new System.Windows.Forms.TextBox();
            this.txt_idchip = new System.Windows.Forms.TextBox();
            this.txt_racaespecie = new System.Windows.Forms.TextBox();
            this.bt_apagarMarcacao = new System.Windows.Forms.Button();
            this.buttonFazerMarcacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonCirurgia
            // 
            this.radioButtonCirurgia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCirurgia.AutoSize = true;
            this.radioButtonCirurgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCirurgia.Location = new System.Drawing.Point(578, 59);
            this.radioButtonCirurgia.Name = "radioButtonCirurgia";
            this.radioButtonCirurgia.Size = new System.Drawing.Size(101, 28);
            this.radioButtonCirurgia.TabIndex = 59;
            this.radioButtonCirurgia.TabStop = true;
            this.radioButtonCirurgia.Text = "Cirurgia";
            this.radioButtonCirurgia.UseVisualStyleBackColor = true;
            this.radioButtonCirurgia.CheckedChanged += new System.EventHandler(this.radioButtonCirurgia_CheckedChanged);
            // 
            // radioButtonConsulta
            // 
            this.radioButtonConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonConsulta.AutoSize = true;
            this.radioButtonConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonConsulta.Location = new System.Drawing.Point(578, 99);
            this.radioButtonConsulta.Name = "radioButtonConsulta";
            this.radioButtonConsulta.Size = new System.Drawing.Size(115, 28);
            this.radioButtonConsulta.TabIndex = 58;
            this.radioButtonConsulta.TabStop = true;
            this.radioButtonConsulta.Text = "Consulta ";
            this.radioButtonConsulta.UseVisualStyleBackColor = true;
            this.radioButtonConsulta.CheckedChanged += new System.EventHandler(this.radioButtonConsulta_CheckedChanged);
            // 
            // radioButtonTosquia
            // 
            this.radioButtonTosquia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonTosquia.AutoSize = true;
            this.radioButtonTosquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTosquia.Location = new System.Drawing.Point(578, 140);
            this.radioButtonTosquia.Name = "radioButtonTosquia";
            this.radioButtonTosquia.Size = new System.Drawing.Size(103, 28);
            this.radioButtonTosquia.TabIndex = 57;
            this.radioButtonTosquia.TabStop = true;
            this.radioButtonTosquia.Text = "Tosquia";
            this.radioButtonTosquia.UseVisualStyleBackColor = true;
            this.radioButtonTosquia.CheckedChanged += new System.EventHandler(this.radioButtonTosquia_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 166);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // comboBoxMedico
            // 
            this.comboBoxMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMedico.FormattingEnabled = true;
            this.comboBoxMedico.Location = new System.Drawing.Point(332, 168);
            this.comboBoxMedico.Name = "comboBoxMedico";
            this.comboBoxMedico.Size = new System.Drawing.Size(204, 24);
            this.comboBoxMedico.TabIndex = 51;
            this.comboBoxMedico.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedico_SelectedIndexChanged);
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(332, 114);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(204, 24);
            this.comboBoxSala.TabIndex = 50;
            this.comboBoxSala.SelectedIndexChanged += new System.EventHandler(this.comboBoxSala_SelectedIndexChanged);
            // 
            // comboBoxHorario
            // 
            this.comboBoxHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHorario.FormattingEnabled = true;
            this.comboBoxHorario.Location = new System.Drawing.Point(332, 59);
            this.comboBoxHorario.Name = "comboBoxHorario";
            this.comboBoxHorario.Size = new System.Drawing.Size(204, 24);
            this.comboBoxHorario.TabIndex = 49;
            this.comboBoxHorario.SelectedIndexChanged += new System.EventHandler(this.comboBoxHorario_SelectedIndexChanged);
            this.comboBoxHorario.TextChanged += new System.EventHandler(this.comboBoxHorario_TextChanged);
            // 
            // comboBoxAnimais
            // 
            this.comboBoxAnimais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAnimais.FormattingEnabled = true;
            this.comboBoxAnimais.Location = new System.Drawing.Point(12, 36);
            this.comboBoxAnimais.Name = "comboBoxAnimais";
            this.comboBoxAnimais.Size = new System.Drawing.Size(290, 24);
            this.comboBoxAnimais.TabIndex = 48;
            this.comboBoxAnimais.TextChanged += new System.EventHandler(this.comboBoxAnimais_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Numero de Chip:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Fazer Marcações";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(329, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 16);
            this.label14.TabIndex = 43;
            this.label14.Text = "Selecionar Medico:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 24);
            this.label11.TabIndex = 42;
            this.label11.Text = "Consultas Marcadas";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(329, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Selecionar Sala:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Dados do Animal";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Selecionar Horario:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Raça / Especie:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Selecionar Animal";
            // 
            // txt_datanascimento
            // 
            this.txt_datanascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_datanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datanascimento.Location = new System.Drawing.Point(12, 244);
            this.txt_datanascimento.Name = "txt_datanascimento";
            this.txt_datanascimento.Size = new System.Drawing.Size(89, 26);
            this.txt_datanascimento.TabIndex = 35;
            // 
            // txt_idchip
            // 
            this.txt_idchip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_idchip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idchip.Location = new System.Drawing.Point(15, 182);
            this.txt_idchip.Name = "txt_idchip";
            this.txt_idchip.Size = new System.Drawing.Size(119, 26);
            this.txt_idchip.TabIndex = 34;
            // 
            // txt_racaespecie
            // 
            this.txt_racaespecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_racaespecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_racaespecie.Location = new System.Drawing.Point(15, 130);
            this.txt_racaespecie.Name = "txt_racaespecie";
            this.txt_racaespecie.Size = new System.Drawing.Size(287, 26);
            this.txt_racaespecie.TabIndex = 33;
            // 
            // bt_apagarMarcacao
            // 
            this.bt_apagarMarcacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_apagarMarcacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_apagarMarcacao.Location = new System.Drawing.Point(496, 250);
            this.bt_apagarMarcacao.Name = "bt_apagarMarcacao";
            this.bt_apagarMarcacao.Size = new System.Drawing.Size(167, 31);
            this.bt_apagarMarcacao.TabIndex = 31;
            this.bt_apagarMarcacao.Text = "Apagar  Marcação";
            this.bt_apagarMarcacao.UseVisualStyleBackColor = true;
            this.bt_apagarMarcacao.Click += new System.EventHandler(this.bt_apagarMarcacao_Click);
            // 
            // buttonFazerMarcacao
            // 
            this.buttonFazerMarcacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFazerMarcacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFazerMarcacao.Location = new System.Drawing.Point(304, 250);
            this.buttonFazerMarcacao.Name = "buttonFazerMarcacao";
            this.buttonFazerMarcacao.Size = new System.Drawing.Size(167, 31);
            this.buttonFazerMarcacao.TabIndex = 29;
            this.buttonFazerMarcacao.Text = "Fazer  Marcação";
            this.buttonFazerMarcacao.UseVisualStyleBackColor = true;
            this.buttonFazerMarcacao.Click += new System.EventHandler(this.buttonFazerMarcacao_Click);
            // 
            // Marcacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.radioButtonCirurgia);
            this.Controls.Add(this.radioButtonConsulta);
            this.Controls.Add(this.radioButtonTosquia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxMedico);
            this.Controls.Add(this.comboBoxSala);
            this.Controls.Add(this.comboBoxHorario);
            this.Controls.Add(this.comboBoxAnimais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_datanascimento);
            this.Controls.Add(this.txt_idchip);
            this.Controls.Add(this.txt_racaespecie);
            this.Controls.Add(this.bt_apagarMarcacao);
            this.Controls.Add(this.buttonFazerMarcacao);
            this.MinimumSize = new System.Drawing.Size(720, 530);
            this.Name = "Marcacoes";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Marcacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCirurgia;
        private System.Windows.Forms.RadioButton radioButtonConsulta;
        private System.Windows.Forms.RadioButton radioButtonTosquia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxMedico;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.ComboBox comboBoxHorario;
        private System.Windows.Forms.ComboBox comboBoxAnimais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_datanascimento;
        private System.Windows.Forms.TextBox txt_idchip;
        private System.Windows.Forms.TextBox txt_racaespecie;
        private System.Windows.Forms.Button bt_apagarMarcacao;
        private System.Windows.Forms.Button buttonFazerMarcacao;
    }
}