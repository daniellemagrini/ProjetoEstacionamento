namespace ProjetoEstacionamento.Forms
{
    partial class frm_problemas
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
            System.Windows.Forms.PictureBox pb_carro_entrada;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_problemas));
            this.lb_data_problema = new System.Windows.Forms.Label();
            this.tb_dt_problema = new System.Windows.Forms.TextBox();
            this.lb_det_problema = new System.Windows.Forms.Label();
            this.tb_det_problema = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            pb_carro_entrada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pb_carro_entrada)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_data_problema
            // 
            this.lb_data_problema.AutoSize = true;
            this.lb_data_problema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_data_problema.Location = new System.Drawing.Point(21, 28);
            this.lb_data_problema.Name = "lb_data_problema";
            this.lb_data_problema.Size = new System.Drawing.Size(49, 18);
            this.lb_data_problema.TabIndex = 61;
            this.lb_data_problema.Text = "DATA:";
            // 
            // tb_dt_problema
            // 
            this.tb_dt_problema.BackColor = System.Drawing.Color.LightGray;
            this.tb_dt_problema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dt_problema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_dt_problema.Enabled = false;
            this.tb_dt_problema.Location = new System.Drawing.Point(76, 28);
            this.tb_dt_problema.Name = "tb_dt_problema";
            this.tb_dt_problema.Size = new System.Drawing.Size(139, 18);
            this.tb_dt_problema.TabIndex = 62;
            // 
            // lb_det_problema
            // 
            this.lb_det_problema.AutoSize = true;
            this.lb_det_problema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_det_problema.Location = new System.Drawing.Point(21, 76);
            this.lb_det_problema.Name = "lb_det_problema";
            this.lb_det_problema.Size = new System.Drawing.Size(207, 18);
            this.lb_det_problema.TabIndex = 63;
            this.lb_det_problema.Text = "DETALHES DO PROBLEMA:";
            // 
            // tb_det_problema
            // 
            this.tb_det_problema.BackColor = System.Drawing.Color.White;
            this.tb_det_problema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_det_problema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_det_problema.Location = new System.Drawing.Point(24, 109);
            this.tb_det_problema.Multiline = true;
            this.tb_det_problema.Name = "tb_det_problema";
            this.tb_det_problema.Size = new System.Drawing.Size(293, 207);
            this.tb_det_problema.TabIndex = 0;
            // 
            // pb_carro_entrada
            // 
            pb_carro_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            pb_carro_entrada.Image = global::ProjetoEstacionamento.Properties.Resources.carro_problema_sem_fundo1;
            pb_carro_entrada.Location = new System.Drawing.Point(350, 1);
            pb_carro_entrada.Name = "pb_carro_entrada";
            pb_carro_entrada.Size = new System.Drawing.Size(140, 113);
            pb_carro_entrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_carro_entrada.TabIndex = 64;
            pb_carro_entrada.TabStop = false;
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.Transparent;
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_salvar.Location = new System.Drawing.Point(362, 226);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(94, 48);
            this.bt_salvar.TabIndex = 65;
            this.bt_salvar.Text = "SALVAR";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_voltar.Location = new System.Drawing.Point(362, 172);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(94, 48);
            this.bt_voltar.TabIndex = 66;
            this.bt_voltar.Text = "VOLTAR";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // frm_problemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(492, 350);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(pb_carro_entrada);
            this.Controls.Add(this.tb_det_problema);
            this.Controls.Add(this.lb_det_problema);
            this.Controls.Add(this.tb_dt_problema);
            this.Controls.Add(this.lb_data_problema);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_problemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar problemas";
            ((System.ComponentModel.ISupportInitialize)(pb_carro_entrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_data_problema;
        private System.Windows.Forms.TextBox tb_dt_problema;
        private System.Windows.Forms.Label lb_det_problema;
        private System.Windows.Forms.TextBox tb_det_problema;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_voltar;
    }
}