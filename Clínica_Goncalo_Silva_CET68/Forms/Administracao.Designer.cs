namespace Clínica_Goncalo_Silva_CET68.Forms
{
    partial class Administracao
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
            this.lstview_medicos = new System.Windows.Forms.ListView();
            this.bt_cancelarConsultas = new System.Windows.Forms.Button();
            this.bt_remoMedico = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_NomeMedico = new System.Windows.Forms.TextBox();
            this.txt_FuncaoMedico = new System.Windows.Forms.TextBox();
            this.txt_IDmedico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstview_medicos
            // 
            this.lstview_medicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstview_medicos.FullRowSelect = true;
            this.lstview_medicos.GridLines = true;
            this.lstview_medicos.HideSelection = false;
            this.lstview_medicos.Location = new System.Drawing.Point(54, 69);
            this.lstview_medicos.MultiSelect = false;
            this.lstview_medicos.Name = "lstview_medicos";
            this.lstview_medicos.Size = new System.Drawing.Size(191, 287);
            this.lstview_medicos.TabIndex = 86;
            this.lstview_medicos.UseCompatibleStateImageBehavior = false;
            this.lstview_medicos.SelectedIndexChanged += new System.EventHandler(this.lstview_medicos_SelectedIndexChanged);
            // 
            // bt_cancelarConsultas
            // 
            this.bt_cancelarConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cancelarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelarConsultas.Location = new System.Drawing.Point(54, 385);
            this.bt_cancelarConsultas.Name = "bt_cancelarConsultas";
            this.bt_cancelarConsultas.Size = new System.Drawing.Size(191, 31);
            this.bt_cancelarConsultas.TabIndex = 84;
            this.bt_cancelarConsultas.Text = "Cancelar Consultas";
            this.bt_cancelarConsultas.UseVisualStyleBackColor = true;
            this.bt_cancelarConsultas.Click += new System.EventHandler(this.bt_cancelarConsultas_Click);
            // 
            // bt_remoMedico
            // 
            this.bt_remoMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_remoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remoMedico.Location = new System.Drawing.Point(377, 385);
            this.bt_remoMedico.Name = "bt_remoMedico";
            this.bt_remoMedico.Size = new System.Drawing.Size(155, 31);
            this.bt_remoMedico.TabIndex = 85;
            this.bt_remoMedico.Text = "Remover Médico";
            this.bt_remoMedico.UseVisualStyleBackColor = true;
            this.bt_remoMedico.Click += new System.EventHandler(this.bt_remoMedico_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(535, 254);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 31);
            this.bt_limpar.TabIndex = 82;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.Location = new System.Drawing.Point(377, 325);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(98, 31);
            this.bt_salvar.TabIndex = 83;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Função:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "ID Médico:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 24);
            this.label10.TabIndex = 78;
            this.label10.Text = "Dados do Médico";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 31);
            this.label11.TabIndex = 77;
            this.label11.Text = "Médicos";
            // 
            // txt_NomeMedico
            // 
            this.txt_NomeMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NomeMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeMedico.Location = new System.Drawing.Point(377, 130);
            this.txt_NomeMedico.Name = "txt_NomeMedico";
            this.txt_NomeMedico.Size = new System.Drawing.Size(220, 26);
            this.txt_NomeMedico.TabIndex = 76;
            // 
            // txt_FuncaoMedico
            // 
            this.txt_FuncaoMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_FuncaoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FuncaoMedico.Location = new System.Drawing.Point(377, 193);
            this.txt_FuncaoMedico.Name = "txt_FuncaoMedico";
            this.txt_FuncaoMedico.Size = new System.Drawing.Size(220, 26);
            this.txt_FuncaoMedico.TabIndex = 75;
            // 
            // txt_IDmedico
            // 
            this.txt_IDmedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDmedico.Enabled = false;
            this.txt_IDmedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDmedico.Location = new System.Drawing.Point(377, 256);
            this.txt_IDmedico.Name = "txt_IDmedico";
            this.txt_IDmedico.Size = new System.Drawing.Size(140, 26);
            this.txt_IDmedico.TabIndex = 74;
            // 
            // Administracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.lstview_medicos);
            this.Controls.Add(this.bt_cancelarConsultas);
            this.Controls.Add(this.bt_remoMedico);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_NomeMedico);
            this.Controls.Add(this.txt_FuncaoMedico);
            this.Controls.Add(this.txt_IDmedico);
            this.MinimumSize = new System.Drawing.Size(720, 530);
            this.Name = "Administracao";
            this.Text = "Administracao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstview_medicos;
        private System.Windows.Forms.Button bt_cancelarConsultas;
        private System.Windows.Forms.Button bt_remoMedico;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_NomeMedico;
        private System.Windows.Forms.TextBox txt_FuncaoMedico;
        private System.Windows.Forms.TextBox txt_IDmedico;
    }
}