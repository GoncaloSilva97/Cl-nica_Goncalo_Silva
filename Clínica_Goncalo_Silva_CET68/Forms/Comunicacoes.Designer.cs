namespace Clínica_Goncalo_Silva_CET68.Forms
{
    partial class Comunicacoes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.txt_mensagens = new System.Windows.Forms.TextBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Assunto";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Escreva uma mensagem para todos os clientes ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mensagem ";
            // 
            // txt_assunto
            // 
            this.txt_assunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_assunto.Location = new System.Drawing.Point(47, 90);
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(631, 20);
            this.txt_assunto.TabIndex = 18;
            // 
            // txt_mensagens
            // 
            this.txt_mensagens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mensagens.Location = new System.Drawing.Point(12, 154);
            this.txt_mensagens.Multiline = true;
            this.txt_mensagens.Name = "txt_mensagens";
            this.txt_mensagens.Size = new System.Drawing.Size(680, 266);
            this.txt_mensagens.TabIndex = 19;
            // 
            // bt_enviar
            // 
            this.bt_enviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enviar.Location = new System.Drawing.Point(553, 448);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(139, 31);
            this.bt_enviar.TabIndex = 17;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // Comunicacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_assunto);
            this.Controls.Add(this.txt_mensagens);
            this.Controls.Add(this.bt_enviar);
            this.MinimumSize = new System.Drawing.Size(720, 530);
            this.Name = "Comunicacoes";
            this.Text = "Comunicacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_assunto;
        private System.Windows.Forms.TextBox txt_mensagens;
        private System.Windows.Forms.Button bt_enviar;
    }
}