namespace Clínica_Goncalo_Silva_CET68.Forms
{
    partial class Clientes
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
            this.lstview_animais = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.rbt_Nao = new System.Windows.Forms.RadioButton();
            this.rbt_Sim = new System.Windows.Forms.RadioButton();
            this.bt_removercliente = new System.Windows.Forms.Button();
            this.bt_remoAnimal = new System.Windows.Forms.Button();
            this.bt_AddAnimal = new System.Windows.Forms.Button();
            this.bt_guardarAlteracoes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dono = new System.Windows.Forms.TextBox();
            this.txt_emaildono = new System.Windows.Forms.TextBox();
            this.txt_datanascimento = new System.Windows.Forms.TextBox();
            this.txt_NomeAnimal = new System.Windows.Forms.TextBox();
            this.txt_idchip = new System.Windows.Forms.TextBox();
            this.txt_racaespecie = new System.Windows.Forms.TextBox();
            this.txt_IDdono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbt_Nao1 = new System.Windows.Forms.RadioButton();
            this.rbt_Sim1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstview_animais
            // 
            this.lstview_animais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstview_animais.FullRowSelect = true;
            this.lstview_animais.GridLines = true;
            this.lstview_animais.HideSelection = false;
            this.lstview_animais.Location = new System.Drawing.Point(23, 290);
            this.lstview_animais.MultiSelect = false;
            this.lstview_animais.Name = "lstview_animais";
            this.lstview_animais.Size = new System.Drawing.Size(387, 189);
            this.lstview_animais.TabIndex = 73;
            this.lstview_animais.UseCompatibleStateImageBehavior = false;
            this.lstview_animais.SelectedIndexChanged += new System.EventHandler(this.lstview_animais_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, -42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(332, 24);
            this.label9.TabIndex = 72;
            this.label9.Text = "Deseja adicionar um cliente novo?";
            // 
            // rbt_Nao
            // 
            this.rbt_Nao.AutoSize = true;
            this.rbt_Nao.Location = new System.Drawing.Point(518, -38);
            this.rbt_Nao.Name = "rbt_Nao";
            this.rbt_Nao.Size = new System.Drawing.Size(45, 17);
            this.rbt_Nao.TabIndex = 71;
            this.rbt_Nao.TabStop = true;
            this.rbt_Nao.Text = "Não";
            this.rbt_Nao.UseVisualStyleBackColor = true;
            // 
            // rbt_Sim
            // 
            this.rbt_Sim.AutoSize = true;
            this.rbt_Sim.Location = new System.Drawing.Point(454, -39);
            this.rbt_Sim.Name = "rbt_Sim";
            this.rbt_Sim.Size = new System.Drawing.Size(42, 17);
            this.rbt_Sim.TabIndex = 70;
            this.rbt_Sim.TabStop = true;
            this.rbt_Sim.Text = "Sim";
            this.rbt_Sim.UseVisualStyleBackColor = true;
            // 
            // bt_removercliente
            // 
            this.bt_removercliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_removercliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_removercliente.Location = new System.Drawing.Point(513, 450);
            this.bt_removercliente.Name = "bt_removercliente";
            this.bt_removercliente.Size = new System.Drawing.Size(155, 31);
            this.bt_removercliente.TabIndex = 69;
            this.bt_removercliente.Text = "Remover Cliente";
            this.bt_removercliente.UseVisualStyleBackColor = true;
            this.bt_removercliente.Click += new System.EventHandler(this.bt_removercliente_Click);
            // 
            // bt_remoAnimal
            // 
            this.bt_remoAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_remoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remoAnimal.Location = new System.Drawing.Point(513, 401);
            this.bt_remoAnimal.Name = "bt_remoAnimal";
            this.bt_remoAnimal.Size = new System.Drawing.Size(155, 31);
            this.bt_remoAnimal.TabIndex = 68;
            this.bt_remoAnimal.Text = "Remover Animal";
            this.bt_remoAnimal.UseVisualStyleBackColor = true;
            this.bt_remoAnimal.Click += new System.EventHandler(this.bt_remoAnimal_Click);
            // 
            // bt_AddAnimal
            // 
            this.bt_AddAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_AddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddAnimal.Location = new System.Drawing.Point(513, 349);
            this.bt_AddAnimal.Name = "bt_AddAnimal";
            this.bt_AddAnimal.Size = new System.Drawing.Size(155, 31);
            this.bt_AddAnimal.TabIndex = 67;
            this.bt_AddAnimal.Text = "Adicionar Animal";
            this.bt_AddAnimal.UseVisualStyleBackColor = true;
            this.bt_AddAnimal.Click += new System.EventHandler(this.bt_AddAnimal_Click);
            // 
            // bt_guardarAlteracoes
            // 
            this.bt_guardarAlteracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_guardarAlteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardarAlteracoes.Location = new System.Drawing.Point(513, 298);
            this.bt_guardarAlteracoes.Name = "bt_guardarAlteracoes";
            this.bt_guardarAlteracoes.Size = new System.Drawing.Size(98, 31);
            this.bt_guardarAlteracoes.TabIndex = 66;
            this.bt_guardarAlteracoes.Text = "Salvar";
            this.bt_guardarAlteracoes.UseVisualStyleBackColor = true;
            this.bt_guardarAlteracoes.Click += new System.EventHandler(this.bt_guardarAlteracoes_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "Nome Dono:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "E-Mail:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Numero de Cliente:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Numero de Chip:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Dados do Cliente";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 59;
            this.label11.Text = "Animais";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 24);
            this.label8.TabIndex = 58;
            this.label8.Text = "Dados do Animal";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Raça / Especie:";
            // 
            // txt_dono
            // 
            this.txt_dono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dono.Location = new System.Drawing.Point(23, 130);
            this.txt_dono.Name = "txt_dono";
            this.txt_dono.Size = new System.Drawing.Size(267, 26);
            this.txt_dono.TabIndex = 55;
            // 
            // txt_emaildono
            // 
            this.txt_emaildono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_emaildono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emaildono.Location = new System.Drawing.Point(23, 178);
            this.txt_emaildono.Name = "txt_emaildono";
            this.txt_emaildono.Size = new System.Drawing.Size(267, 26);
            this.txt_emaildono.TabIndex = 54;
            // 
            // txt_datanascimento
            // 
            this.txt_datanascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_datanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datanascimento.Location = new System.Drawing.Point(422, 237);
            this.txt_datanascimento.Name = "txt_datanascimento";
            this.txt_datanascimento.Size = new System.Drawing.Size(90, 26);
            this.txt_datanascimento.TabIndex = 51;
            // 
            // txt_NomeAnimal
            // 
            this.txt_NomeAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NomeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeAnimal.Location = new System.Drawing.Point(422, 67);
            this.txt_NomeAnimal.Name = "txt_NomeAnimal";
            this.txt_NomeAnimal.Size = new System.Drawing.Size(192, 26);
            this.txt_NomeAnimal.TabIndex = 52;
            // 
            // txt_idchip
            // 
            this.txt_idchip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_idchip.Enabled = false;
            this.txt_idchip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idchip.Location = new System.Drawing.Point(422, 181);
            this.txt_idchip.Name = "txt_idchip";
            this.txt_idchip.Size = new System.Drawing.Size(90, 26);
            this.txt_idchip.TabIndex = 50;
            this.txt_idchip.TextChanged += new System.EventHandler(this.txt_idchip_TextChanged);
            // 
            // txt_racaespecie
            // 
            this.txt_racaespecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_racaespecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_racaespecie.Location = new System.Drawing.Point(422, 121);
            this.txt_racaespecie.Name = "txt_racaespecie";
            this.txt_racaespecie.Size = new System.Drawing.Size(192, 26);
            this.txt_racaespecie.TabIndex = 53;
            // 
            // txt_IDdono
            // 
            this.txt_IDdono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDdono.Enabled = false;
            this.txt_IDdono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDdono.Location = new System.Drawing.Point(23, 226);
            this.txt_IDdono.Name = "txt_IDdono";
            this.txt_IDdono.Size = new System.Drawing.Size(192, 26);
            this.txt_IDdono.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(332, 24);
            this.label12.TabIndex = 76;
            this.label12.Text = "Deseja adicionar um cliente novo?";
            // 
            // rbt_Nao1
            // 
            this.rbt_Nao1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbt_Nao1.AutoSize = true;
            this.rbt_Nao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Nao1.Location = new System.Drawing.Point(181, 36);
            this.rbt_Nao1.Name = "rbt_Nao1";
            this.rbt_Nao1.Size = new System.Drawing.Size(66, 28);
            this.rbt_Nao1.TabIndex = 74;
            this.rbt_Nao1.TabStop = true;
            this.rbt_Nao1.Text = "Não";
            this.rbt_Nao1.UseVisualStyleBackColor = true;
            this.rbt_Nao1.CheckedChanged += new System.EventHandler(this.rbt_Nao1_CheckedChanged);
            // 
            // rbt_Sim1
            // 
            this.rbt_Sim1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbt_Sim1.AutoSize = true;
            this.rbt_Sim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Sim1.Location = new System.Drawing.Point(68, 36);
            this.rbt_Sim1.Name = "rbt_Sim1";
            this.rbt_Sim1.Size = new System.Drawing.Size(63, 28);
            this.rbt_Sim1.TabIndex = 75;
            this.rbt_Sim1.TabStop = true;
            this.rbt_Sim1.Text = "Sim";
            this.rbt_Sim1.UseVisualStyleBackColor = true;
            this.rbt_Sim1.CheckedChanged += new System.EventHandler(this.rbt_Sim1_CheckedChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbt_Nao1);
            this.Controls.Add(this.rbt_Sim1);
            this.Controls.Add(this.lstview_animais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbt_Nao);
            this.Controls.Add(this.rbt_Sim);
            this.Controls.Add(this.bt_removercliente);
            this.Controls.Add(this.bt_remoAnimal);
            this.Controls.Add(this.bt_AddAnimal);
            this.Controls.Add(this.bt_guardarAlteracoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dono);
            this.Controls.Add(this.txt_emaildono);
            this.Controls.Add(this.txt_datanascimento);
            this.Controls.Add(this.txt_NomeAnimal);
            this.Controls.Add(this.txt_idchip);
            this.Controls.Add(this.txt_racaespecie);
            this.Controls.Add(this.txt_IDdono);
            this.MinimumSize = new System.Drawing.Size(720, 530);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstview_animais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbt_Nao;
        private System.Windows.Forms.RadioButton rbt_Sim;
        private System.Windows.Forms.Button bt_removercliente;
        private System.Windows.Forms.Button bt_remoAnimal;
        private System.Windows.Forms.Button bt_AddAnimal;
        private System.Windows.Forms.Button bt_guardarAlteracoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dono;
        private System.Windows.Forms.TextBox txt_emaildono;
        private System.Windows.Forms.TextBox txt_datanascimento;
        private System.Windows.Forms.TextBox txt_NomeAnimal;
        private System.Windows.Forms.TextBox txt_idchip;
        private System.Windows.Forms.TextBox txt_racaespecie;
        private System.Windows.Forms.TextBox txt_IDdono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbt_Nao1;
        private System.Windows.Forms.RadioButton rbt_Sim1;
    }
}