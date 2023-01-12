namespace Clínica_Goncalo_Silva_CET68.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu = new System.Windows.Forms.Panel();
            this.BT_consultas = new System.Windows.Forms.Button();
            this.BT_comunicacoes = new System.Windows.Forms.Button();
            this.BT_clientes = new System.Windows.Forms.Button();
            this.BT_cronograma = new System.Windows.Forms.Button();
            this.BT_administracao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_IDdono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combobox_nomedono = new System.Windows.Forms.ComboBox();
            this.txt_emaildono = new System.Windows.Forms.TextBox();
            this.BT_creditos = new System.Windows.Forms.Button();
            this.PN_logotipo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_titulo = new System.Windows.Forms.Panel();
            this.LBL_escolha = new System.Windows.Forms.Label();
            this.BT_fecharChildForm = new System.Windows.Forms.Button();
            this.PN_desktop = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PN_logotipo.SuspendLayout();
            this.PN_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.Menu.Controls.Add(this.BT_consultas);
            this.Menu.Controls.Add(this.BT_comunicacoes);
            this.Menu.Controls.Add(this.BT_clientes);
            this.Menu.Controls.Add(this.BT_cronograma);
            this.Menu.Controls.Add(this.BT_administracao);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.BT_creditos);
            this.Menu.Controls.Add(this.PN_logotipo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(220, 669);
            this.Menu.TabIndex = 0;
            // 
            // BT_consultas
            // 
            this.BT_consultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_consultas.FlatAppearance.BorderSize = 0;
            this.BT_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_consultas.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_consultas.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_consultas.Image = ((System.Drawing.Image)(resources.GetObject("BT_consultas.Image")));
            this.BT_consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_consultas.Location = new System.Drawing.Point(0, 535);
            this.BT_consultas.Name = "BT_consultas";
            this.BT_consultas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BT_consultas.Size = new System.Drawing.Size(220, 60);
            this.BT_consultas.TabIndex = 11;
            this.BT_consultas.Text = "Consultas ";
            this.BT_consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_consultas.UseVisualStyleBackColor = true;
            this.BT_consultas.Click += new System.EventHandler(this.BT_consultas_Click);
            // 
            // BT_comunicacoes
            // 
            this.BT_comunicacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_comunicacoes.FlatAppearance.BorderSize = 0;
            this.BT_comunicacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_comunicacoes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_comunicacoes.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_comunicacoes.Image = ((System.Drawing.Image)(resources.GetObject("BT_comunicacoes.Image")));
            this.BT_comunicacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_comunicacoes.Location = new System.Drawing.Point(0, 475);
            this.BT_comunicacoes.Name = "BT_comunicacoes";
            this.BT_comunicacoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BT_comunicacoes.Size = new System.Drawing.Size(220, 60);
            this.BT_comunicacoes.TabIndex = 10;
            this.BT_comunicacoes.Text = "Comunicações";
            this.BT_comunicacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_comunicacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_comunicacoes.UseVisualStyleBackColor = true;
            this.BT_comunicacoes.Click += new System.EventHandler(this.BT_comunicacoes_Click);
            // 
            // BT_clientes
            // 
            this.BT_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_clientes.FlatAppearance.BorderSize = 0;
            this.BT_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_clientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_clientes.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_clientes.Image = ((System.Drawing.Image)(resources.GetObject("BT_clientes.Image")));
            this.BT_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_clientes.Location = new System.Drawing.Point(0, 415);
            this.BT_clientes.Name = "BT_clientes";
            this.BT_clientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BT_clientes.Size = new System.Drawing.Size(220, 60);
            this.BT_clientes.TabIndex = 9;
            this.BT_clientes.Text = "Clientes";
            this.BT_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_clientes.UseVisualStyleBackColor = true;
            this.BT_clientes.Click += new System.EventHandler(this.BT_clientes_Click);
            // 
            // BT_cronograma
            // 
            this.BT_cronograma.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_cronograma.FlatAppearance.BorderSize = 0;
            this.BT_cronograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_cronograma.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cronograma.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_cronograma.Image = ((System.Drawing.Image)(resources.GetObject("BT_cronograma.Image")));
            this.BT_cronograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_cronograma.Location = new System.Drawing.Point(0, 355);
            this.BT_cronograma.Name = "BT_cronograma";
            this.BT_cronograma.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BT_cronograma.Size = new System.Drawing.Size(220, 60);
            this.BT_cronograma.TabIndex = 8;
            this.BT_cronograma.Text = "Cronograma";
            this.BT_cronograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_cronograma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_cronograma.UseVisualStyleBackColor = true;
            this.BT_cronograma.Click += new System.EventHandler(this.BT_cronograma_Click);
            // 
            // BT_administracao
            // 
            this.BT_administracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_administracao.FlatAppearance.BorderSize = 0;
            this.BT_administracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_administracao.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_administracao.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_administracao.Image = ((System.Drawing.Image)(resources.GetObject("BT_administracao.Image")));
            this.BT_administracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_administracao.Location = new System.Drawing.Point(0, 295);
            this.BT_administracao.Name = "BT_administracao";
            this.BT_administracao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BT_administracao.Size = new System.Drawing.Size(220, 60);
            this.BT_administracao.TabIndex = 7;
            this.BT_administracao.Text = "Administração ";
            this.BT_administracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_administracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_administracao.UseVisualStyleBackColor = true;
            this.BT_administracao.Click += new System.EventHandler(this.BT_administracao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_IDdono);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.combobox_nomedono);
            this.panel1.Controls.Add(this.txt_emaildono);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.MinimumSize = new System.Drawing.Size(220, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 6;
            // 
            // txt_IDdono
            // 
            this.txt_IDdono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDdono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDdono.Location = new System.Drawing.Point(3, 164);
            this.txt_IDdono.Name = "txt_IDdono";
            this.txt_IDdono.Size = new System.Drawing.Size(133, 26);
            this.txt_IDdono.TabIndex = 56;
            this.txt_IDdono.TextChanged += new System.EventHandler(this.txt_IDdono_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(-3, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Numero de Cliente:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "E-Mail:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(0, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaShell;
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 24);
            this.label10.TabIndex = 58;
            this.label10.Text = "Dados do Cliente";
            // 
            // combobox_nomedono
            // 
            this.combobox_nomedono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobox_nomedono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_nomedono.FormattingEnabled = true;
            this.combobox_nomedono.Location = new System.Drawing.Point(3, 58);
            this.combobox_nomedono.Name = "combobox_nomedono";
            this.combobox_nomedono.Size = new System.Drawing.Size(210, 24);
            this.combobox_nomedono.TabIndex = 59;
            this.combobox_nomedono.SelectedIndexChanged += new System.EventHandler(this.combobox_nomedono_SelectedIndexChanged);
            // 
            // txt_emaildono
            // 
            this.txt_emaildono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_emaildono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emaildono.Location = new System.Drawing.Point(3, 110);
            this.txt_emaildono.Name = "txt_emaildono";
            this.txt_emaildono.Size = new System.Drawing.Size(210, 26);
            this.txt_emaildono.TabIndex = 57;
            // 
            // BT_creditos
            // 
            this.BT_creditos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BT_creditos.FlatAppearance.BorderSize = 0;
            this.BT_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_creditos.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_creditos.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_creditos.Image = ((System.Drawing.Image)(resources.GetObject("BT_creditos.Image")));
            this.BT_creditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_creditos.Location = new System.Drawing.Point(0, 609);
            this.BT_creditos.Name = "BT_creditos";
            this.BT_creditos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BT_creditos.Size = new System.Drawing.Size(220, 60);
            this.BT_creditos.TabIndex = 5;
            this.BT_creditos.Text = "Créditos";
            this.BT_creditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_creditos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_creditos.UseVisualStyleBackColor = true;
            this.BT_creditos.Click += new System.EventHandler(this.BT_creditos_Click);
            // 
            // PN_logotipo
            // 
            this.PN_logotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PN_logotipo.Controls.Add(this.label1);
            this.PN_logotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_logotipo.Location = new System.Drawing.Point(0, 0);
            this.PN_logotipo.Name = "PN_logotipo";
            this.PN_logotipo.Size = new System.Drawing.Size(220, 75);
            this.PN_logotipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinica Veterinária";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_titulo
            // 
            this.PN_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PN_titulo.Controls.Add(this.LBL_escolha);
            this.PN_titulo.Controls.Add(this.BT_fecharChildForm);
            this.PN_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_titulo.Location = new System.Drawing.Point(220, 0);
            this.PN_titulo.Name = "PN_titulo";
            this.PN_titulo.Size = new System.Drawing.Size(721, 75);
            this.PN_titulo.TabIndex = 1;
            // 
            // LBL_escolha
            // 
            this.LBL_escolha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_escolha.Location = new System.Drawing.Point(100, 0);
            this.LBL_escolha.Name = "LBL_escolha";
            this.LBL_escolha.Size = new System.Drawing.Size(621, 75);
            this.LBL_escolha.TabIndex = 2;
            this.LBL_escolha.Text = "                ";
            this.LBL_escolha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_fecharChildForm
            // 
            this.BT_fecharChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.BT_fecharChildForm.FlatAppearance.BorderSize = 0;
            this.BT_fecharChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_fecharChildForm.Image = ((System.Drawing.Image)(resources.GetObject("BT_fecharChildForm.Image")));
            this.BT_fecharChildForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_fecharChildForm.Location = new System.Drawing.Point(0, 0);
            this.BT_fecharChildForm.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.BT_fecharChildForm.Name = "BT_fecharChildForm";
            this.BT_fecharChildForm.Size = new System.Drawing.Size(100, 75);
            this.BT_fecharChildForm.TabIndex = 1;
            this.BT_fecharChildForm.UseVisualStyleBackColor = true;
            this.BT_fecharChildForm.Click += new System.EventHandler(this.BT_fecharChildForm_Click);
            // 
            // PN_desktop
            // 
            this.PN_desktop.AutoSize = true;
            this.PN_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_desktop.Location = new System.Drawing.Point(220, 75);
            this.PN_desktop.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.PN_desktop.Name = "PN_desktop";
            this.PN_desktop.Size = new System.Drawing.Size(721, 594);
            this.PN_desktop.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 669);
            this.Controls.Add(this.PN_desktop);
            this.Controls.Add(this.PN_titulo);
            this.Controls.Add(this.Menu);
            this.MinimumSize = new System.Drawing.Size(957, 645);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PN_logotipo.ResumeLayout(false);
            this.PN_titulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button BT_creditos;
        private System.Windows.Forms.Panel PN_logotipo;
        private System.Windows.Forms.Panel PN_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PN_desktop;
        private System.Windows.Forms.Button BT_fecharChildForm;
        private System.Windows.Forms.Label LBL_escolha;
        private System.Windows.Forms.Button BT_consultas;
        private System.Windows.Forms.Button BT_comunicacoes;
        private System.Windows.Forms.Button BT_clientes;
        private System.Windows.Forms.Button BT_cronograma;
        private System.Windows.Forms.Button BT_administracao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combobox_nomedono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IDdono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_emaildono;
    }
}