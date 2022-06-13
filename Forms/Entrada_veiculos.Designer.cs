namespace ProjetoEstacionamento.Forms
{
    partial class frm_entrada_veiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_entrada_veiculos));
            this.lb_placa_entrada = new System.Windows.Forms.Label();
            this.tb_placa_entrada = new System.Windows.Forms.TextBox();
            this.tb_dt_entrada = new System.Windows.Forms.TextBox();
            this.lb_dt_entrada = new System.Windows.Forms.Label();
            this.tb_hr_entrada = new System.Windows.Forms.TextBox();
            this.lb_hr_entrada = new System.Windows.Forms.Label();
            this.clb_moto = new System.Windows.Forms.CheckedListBox();
            this.clb_carro = new System.Windows.Forms.CheckedListBox();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            pb_carro_entrada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pb_carro_entrada)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_carro_entrada
            // 
            pb_carro_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            pb_carro_entrada.Image = global::ProjetoEstacionamento.Properties.Resources.veiculo_frente_sem_fundo;
            pb_carro_entrada.Location = new System.Drawing.Point(351, 2);
            pb_carro_entrada.Name = "pb_carro_entrada";
            pb_carro_entrada.Size = new System.Drawing.Size(140, 113);
            pb_carro_entrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_carro_entrada.TabIndex = 9;
            pb_carro_entrada.TabStop = false;
            // 
            // lb_placa_entrada
            // 
            this.lb_placa_entrada.AutoSize = true;
            this.lb_placa_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_placa_entrada.Location = new System.Drawing.Point(38, 95);
            this.lb_placa_entrada.Name = "lb_placa_entrada";
            this.lb_placa_entrada.Size = new System.Drawing.Size(156, 18);
            this.lb_placa_entrada.TabIndex = 40;
            this.lb_placa_entrada.Text = "PLACA DO VEÍCULO:";
            // 
            // tb_placa_entrada
            // 
            this.tb_placa_entrada.AcceptsTab = true;
            this.tb_placa_entrada.BackColor = System.Drawing.Color.LightGray;
            this.tb_placa_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_placa_entrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_placa_entrada.Location = new System.Drawing.Point(192, 95);
            this.tb_placa_entrada.Name = "tb_placa_entrada";
            this.tb_placa_entrada.Size = new System.Drawing.Size(139, 18);
            this.tb_placa_entrada.TabIndex = 0;
            this.tb_placa_entrada.Leave += new System.EventHandler(this.tb_placa_entrada_Leave);
            // 
            // tb_dt_entrada
            // 
            this.tb_dt_entrada.BackColor = System.Drawing.Color.LightGray;
            this.tb_dt_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dt_entrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_dt_entrada.Enabled = false;
            this.tb_dt_entrada.Location = new System.Drawing.Point(192, 144);
            this.tb_dt_entrada.Name = "tb_dt_entrada";
            this.tb_dt_entrada.Size = new System.Drawing.Size(139, 18);
            this.tb_dt_entrada.TabIndex = 1;
            // 
            // lb_dt_entrada
            // 
            this.lb_dt_entrada.AutoSize = true;
            this.lb_dt_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_dt_entrada.Location = new System.Drawing.Point(38, 144);
            this.lb_dt_entrada.Name = "lb_dt_entrada";
            this.lb_dt_entrada.Size = new System.Drawing.Size(148, 18);
            this.lb_dt_entrada.TabIndex = 42;
            this.lb_dt_entrada.Text = "DATA DE ENTRADA:";
            // 
            // tb_hr_entrada
            // 
            this.tb_hr_entrada.BackColor = System.Drawing.Color.LightGray;
            this.tb_hr_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hr_entrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_hr_entrada.Enabled = false;
            this.tb_hr_entrada.Location = new System.Drawing.Point(192, 195);
            this.tb_hr_entrada.Name = "tb_hr_entrada";
            this.tb_hr_entrada.Size = new System.Drawing.Size(139, 18);
            this.tb_hr_entrada.TabIndex = 43;
            // 
            // lb_hr_entrada
            // 
            this.lb_hr_entrada.AutoSize = true;
            this.lb_hr_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_hr_entrada.Location = new System.Drawing.Point(38, 195);
            this.lb_hr_entrada.Name = "lb_hr_entrada";
            this.lb_hr_entrada.Size = new System.Drawing.Size(154, 18);
            this.lb_hr_entrada.TabIndex = 2;
            this.lb_hr_entrada.Text = "HORA DE ENTRADA:";
            // 
            // clb_moto
            // 
            this.clb_moto.BackColor = System.Drawing.Color.Gold;
            this.clb_moto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_moto.CheckOnClick = true;
            this.clb_moto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clb_moto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_moto.FormattingEnabled = true;
            this.clb_moto.Items.AddRange(new object[] {
            "MOTO"});
            this.clb_moto.Location = new System.Drawing.Point(88, 34);
            this.clb_moto.Name = "clb_moto";
            this.clb_moto.Size = new System.Drawing.Size(63, 16);
            this.clb_moto.TabIndex = 2;
            this.clb_moto.ThreeDCheckBoxes = true;
            this.clb_moto.SelectedIndexChanged += new System.EventHandler(this.clb_moto_SelectedIndexChanged);
            // 
            // clb_carro
            // 
            this.clb_carro.BackColor = System.Drawing.Color.Gold;
            this.clb_carro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_carro.CheckOnClick = true;
            this.clb_carro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clb_carro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_carro.FormattingEnabled = true;
            this.clb_carro.Items.AddRange(new object[] {
            "CARRO"});
            this.clb_carro.Location = new System.Drawing.Point(208, 34);
            this.clb_carro.Name = "clb_carro";
            this.clb_carro.Size = new System.Drawing.Size(63, 16);
            this.clb_carro.TabIndex = 1;
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_voltar.Location = new System.Drawing.Point(66, 255);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(94, 48);
            this.bt_voltar.TabIndex = 4;
            this.bt_voltar.Text = "VOLTAR";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.Transparent;
            this.bt_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_limpar.Location = new System.Drawing.Point(177, 255);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(94, 48);
            this.bt_limpar.TabIndex = 5;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.Transparent;
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_salvar.Location = new System.Drawing.Point(291, 255);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(94, 48);
            this.bt_salvar.TabIndex = 3;
            this.bt_salvar.Text = "SALVAR";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // frm_entrada_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(492, 350);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.clb_carro);
            this.Controls.Add(this.clb_moto);
            this.Controls.Add(this.tb_hr_entrada);
            this.Controls.Add(this.lb_hr_entrada);
            this.Controls.Add(this.tb_dt_entrada);
            this.Controls.Add(this.lb_dt_entrada);
            this.Controls.Add(this.tb_placa_entrada);
            this.Controls.Add(this.lb_placa_entrada);
            this.Controls.Add(pb_carro_entrada);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_entrada_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Veículos";
            ((System.ComponentModel.ISupportInitialize)(pb_carro_entrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_placa_entrada;
        private System.Windows.Forms.TextBox tb_placa_entrada;
        private System.Windows.Forms.TextBox tb_dt_entrada;
        private System.Windows.Forms.Label lb_dt_entrada;
        private System.Windows.Forms.TextBox tb_hr_entrada;
        private System.Windows.Forms.Label lb_hr_entrada;
        private System.Windows.Forms.CheckedListBox clb_moto;
        private System.Windows.Forms.CheckedListBox clb_carro;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_salvar;
    }
}