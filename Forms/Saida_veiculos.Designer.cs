namespace ProjetoEstacionamento.Forms
{
    partial class frm_saida_veiculos
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saida_veiculos));
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.tb_hr_saida = new System.Windows.Forms.TextBox();
            this.lb_hr_saida = new System.Windows.Forms.Label();
            this.tb_dt_saida = new System.Windows.Forms.TextBox();
            this.lb_dt_saida = new System.Windows.Forms.Label();
            this.lb_placa_saida = new System.Windows.Forms.Label();
            this.tb_vlr_a_pagar = new System.Windows.Forms.TextBox();
            this.lb_vlr_saida = new System.Windows.Forms.Label();
            this.lb_vlr_hora = new System.Windows.Forms.Label();
            this.lb_vlr_hr_carro = new System.Windows.Forms.Label();
            this.cb_placa_saida = new System.Windows.Forms.ComboBox();
            this.tb_hr_entrada_saida = new System.Windows.Forms.TextBox();
            this.lb_hr_entrada_saida = new System.Windows.Forms.Label();
            this.tb_dt_entrada_saida = new System.Windows.Forms.TextBox();
            this.lb_entrada_saida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = global::ProjetoEstacionamento.Properties.Resources.veiculo_saindosem_fundo;
            pictureBox1.Location = new System.Drawing.Point(662, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(140, 113);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.Transparent;
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_salvar.Location = new System.Drawing.Point(467, 256);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(94, 48);
            this.bt_salvar.TabIndex = 1;
            this.bt_salvar.Text = "SALVAR";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.Transparent;
            this.bt_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_limpar.Location = new System.Drawing.Point(353, 256);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(94, 48);
            this.bt_limpar.TabIndex = 3;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_voltar.Location = new System.Drawing.Point(242, 256);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(94, 48);
            this.bt_voltar.TabIndex = 2;
            this.bt_voltar.Text = "VOLTAR";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // tb_hr_saida
            // 
            this.tb_hr_saida.BackColor = System.Drawing.Color.LightGray;
            this.tb_hr_saida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hr_saida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_hr_saida.Enabled = false;
            this.tb_hr_saida.Location = new System.Drawing.Point(515, 151);
            this.tb_hr_saida.Name = "tb_hr_saida";
            this.tb_hr_saida.Size = new System.Drawing.Size(139, 18);
            this.tb_hr_saida.TabIndex = 52;
            // 
            // lb_hr_saida
            // 
            this.lb_hr_saida.AutoSize = true;
            this.lb_hr_saida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_hr_saida.Location = new System.Drawing.Point(361, 151);
            this.lb_hr_saida.Name = "lb_hr_saida";
            this.lb_hr_saida.Size = new System.Drawing.Size(126, 18);
            this.lb_hr_saida.TabIndex = 46;
            this.lb_hr_saida.Text = "HORA DE SAÍDA:";
            // 
            // tb_dt_saida
            // 
            this.tb_dt_saida.BackColor = System.Drawing.Color.LightGray;
            this.tb_dt_saida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dt_saida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_dt_saida.Enabled = false;
            this.tb_dt_saida.Location = new System.Drawing.Point(515, 100);
            this.tb_dt_saida.Name = "tb_dt_saida";
            this.tb_dt_saida.Size = new System.Drawing.Size(139, 18);
            this.tb_dt_saida.TabIndex = 45;
            // 
            // lb_dt_saida
            // 
            this.lb_dt_saida.AutoSize = true;
            this.lb_dt_saida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_dt_saida.Location = new System.Drawing.Point(361, 100);
            this.lb_dt_saida.Name = "lb_dt_saida";
            this.lb_dt_saida.Size = new System.Drawing.Size(120, 18);
            this.lb_dt_saida.TabIndex = 51;
            this.lb_dt_saida.Text = "DATA DE SAÍDA:";
            // 
            // lb_placa_saida
            // 
            this.lb_placa_saida.AutoSize = true;
            this.lb_placa_saida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_placa_saida.Location = new System.Drawing.Point(137, 38);
            this.lb_placa_saida.Name = "lb_placa_saida";
            this.lb_placa_saida.Size = new System.Drawing.Size(156, 18);
            this.lb_placa_saida.TabIndex = 50;
            this.lb_placa_saida.Text = "PLACA DO VEÍCULO:";
            // 
            // tb_vlr_a_pagar
            // 
            this.tb_vlr_a_pagar.BackColor = System.Drawing.Color.LightGray;
            this.tb_vlr_a_pagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_vlr_a_pagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_vlr_a_pagar.Enabled = false;
            this.tb_vlr_a_pagar.Location = new System.Drawing.Point(364, 204);
            this.tb_vlr_a_pagar.Name = "tb_vlr_a_pagar";
            this.tb_vlr_a_pagar.Size = new System.Drawing.Size(139, 18);
            this.tb_vlr_a_pagar.TabIndex = 54;
            // 
            // lb_vlr_saida
            // 
            this.lb_vlr_saida.AutoSize = true;
            this.lb_vlr_saida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_vlr_saida.Location = new System.Drawing.Point(210, 204);
            this.lb_vlr_saida.Name = "lb_vlr_saida";
            this.lb_vlr_saida.Size = new System.Drawing.Size(126, 18);
            this.lb_vlr_saida.TabIndex = 53;
            this.lb_vlr_saida.Text = "VALOR A PAGAR:";
            // 
            // lb_vlr_hora
            // 
            this.lb_vlr_hora.AutoSize = true;
            this.lb_vlr_hora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_vlr_hora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vlr_hora.ForeColor = System.Drawing.Color.Red;
            this.lb_vlr_hora.Location = new System.Drawing.Point(685, 140);
            this.lb_vlr_hora.Name = "lb_vlr_hora";
            this.lb_vlr_hora.Size = new System.Drawing.Size(85, 15);
            this.lb_vlr_hora.TabIndex = 55;
            this.lb_vlr_hora.Text = "VALOR HORA:";
            // 
            // lb_vlr_hr_carro
            // 
            this.lb_vlr_hr_carro.AutoSize = true;
            this.lb_vlr_hr_carro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_vlr_hr_carro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vlr_hr_carro.Location = new System.Drawing.Point(685, 161);
            this.lb_vlr_hr_carro.Name = "lb_vlr_hr_carro";
            this.lb_vlr_hr_carro.Size = new System.Drawing.Size(105, 15);
            this.lb_vlr_hr_carro.TabIndex = 56;
            this.lb_vlr_hr_carro.Text = "CARRO:    R$ 2,50";
            // 
            // cb_placa_saida
            // 
            this.cb_placa_saida.BackColor = System.Drawing.Color.LightGray;
            this.cb_placa_saida.FormattingEnabled = true;
            this.cb_placa_saida.Location = new System.Drawing.Point(291, 30);
            this.cb_placa_saida.Name = "cb_placa_saida";
            this.cb_placa_saida.Size = new System.Drawing.Size(139, 26);
            this.cb_placa_saida.TabIndex = 0;
            this.cb_placa_saida.Leave += new System.EventHandler(this.cb_placa_saida_Leave);
            // 
            // tb_hr_entrada_saida
            // 
            this.tb_hr_entrada_saida.BackColor = System.Drawing.Color.LightGray;
            this.tb_hr_entrada_saida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hr_entrada_saida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_hr_entrada_saida.Enabled = false;
            this.tb_hr_entrada_saida.Location = new System.Drawing.Point(192, 151);
            this.tb_hr_entrada_saida.Name = "tb_hr_entrada_saida";
            this.tb_hr_entrada_saida.Size = new System.Drawing.Size(139, 18);
            this.tb_hr_entrada_saida.TabIndex = 61;
            // 
            // lb_hr_entrada_saida
            // 
            this.lb_hr_entrada_saida.AutoSize = true;
            this.lb_hr_entrada_saida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_hr_entrada_saida.Location = new System.Drawing.Point(38, 151);
            this.lb_hr_entrada_saida.Name = "lb_hr_entrada_saida";
            this.lb_hr_entrada_saida.Size = new System.Drawing.Size(154, 18);
            this.lb_hr_entrada_saida.TabIndex = 59;
            this.lb_hr_entrada_saida.Text = "HORA DE ENTRADA:";
            // 
            // tb_dt_entrada_saida
            // 
            this.tb_dt_entrada_saida.BackColor = System.Drawing.Color.LightGray;
            this.tb_dt_entrada_saida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dt_entrada_saida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_dt_entrada_saida.Enabled = false;
            this.tb_dt_entrada_saida.Location = new System.Drawing.Point(192, 100);
            this.tb_dt_entrada_saida.Name = "tb_dt_entrada_saida";
            this.tb_dt_entrada_saida.Size = new System.Drawing.Size(139, 18);
            this.tb_dt_entrada_saida.TabIndex = 58;
            // 
            // lb_entrada_saida
            // 
            this.lb_entrada_saida.AutoSize = true;
            this.lb_entrada_saida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_entrada_saida.Location = new System.Drawing.Point(38, 100);
            this.lb_entrada_saida.Name = "lb_entrada_saida";
            this.lb_entrada_saida.Size = new System.Drawing.Size(148, 18);
            this.lb_entrada_saida.TabIndex = 60;
            this.lb_entrada_saida.Text = "DATA DE ENTRADA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "MOTO:      R$ 2,50";
            // 
            // frm_saida_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(805, 350);
            this.Controls.Add(this.tb_hr_entrada_saida);
            this.Controls.Add(this.lb_hr_entrada_saida);
            this.Controls.Add(this.tb_dt_entrada_saida);
            this.Controls.Add(this.lb_entrada_saida);
            this.Controls.Add(this.cb_placa_saida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_vlr_hr_carro);
            this.Controls.Add(this.lb_vlr_hora);
            this.Controls.Add(this.tb_vlr_a_pagar);
            this.Controls.Add(this.lb_vlr_saida);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.tb_hr_saida);
            this.Controls.Add(this.lb_hr_saida);
            this.Controls.Add(this.tb_dt_saida);
            this.Controls.Add(this.lb_dt_saida);
            this.Controls.Add(this.lb_placa_saida);
            this.Controls.Add(pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_saida_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída de Veículos";
            this.Load += new System.EventHandler(this.frm_saida_veiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.TextBox tb_hr_saida;
        private System.Windows.Forms.Label lb_hr_saida;
        private System.Windows.Forms.TextBox tb_dt_saida;
        private System.Windows.Forms.Label lb_dt_saida;
        private System.Windows.Forms.Label lb_placa_saida;
        private System.Windows.Forms.TextBox tb_vlr_a_pagar;
        private System.Windows.Forms.Label lb_vlr_saida;
        private System.Windows.Forms.Label lb_vlr_hora;
        private System.Windows.Forms.Label lb_vlr_hr_carro;
        private System.Windows.Forms.ComboBox cb_placa_saida;
        private System.Windows.Forms.TextBox tb_hr_entrada_saida;
        private System.Windows.Forms.Label lb_hr_entrada_saida;
        private System.Windows.Forms.TextBox tb_dt_entrada_saida;
        private System.Windows.Forms.Label lb_entrada_saida;
        private System.Windows.Forms.Label label1;
    }
}