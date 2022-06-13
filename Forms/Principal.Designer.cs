﻿namespace ProjetoEstacionamento
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button bt_entrada_veiculos;
            System.Windows.Forms.PictureBox pb_carro_entrada;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.PictureBox pictureBox3;
            System.Windows.Forms.Button bt_saida_veiculos;
            System.Windows.Forms.Button bt_relatorios;
            System.Windows.Forms.Button bt_relatar_problema;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip_principal = new System.Windows.Forms.MenuStrip();
            this.ms_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_registrar_entrada = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_registrar_saida = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_relatar_problema = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_impressao_relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_suporte_ti = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_suporte_adm = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_fechar_sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_sair = new System.Windows.Forms.PictureBox();
            this.lb_sair = new System.Windows.Forms.Label();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.col_placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_data_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_grid = new System.Windows.Forms.Label();
            bt_entrada_veiculos = new System.Windows.Forms.Button();
            pb_carro_entrada = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            bt_saida_veiculos = new System.Windows.Forms.Button();
            bt_relatorios = new System.Windows.Forms.Button();
            bt_relatar_problema = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(pb_carro_entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.menuStrip_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_entrada_veiculos
            // 
            bt_entrada_veiculos.BackColor = System.Drawing.Color.Gold;
            bt_entrada_veiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_entrada_veiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            bt_entrada_veiculos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            bt_entrada_veiculos.FlatAppearance.BorderSize = 100;
            bt_entrada_veiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            bt_entrada_veiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            bt_entrada_veiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_entrada_veiculos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt_entrada_veiculos.Location = new System.Drawing.Point(60, 40);
            bt_entrada_veiculos.Name = "bt_entrada_veiculos";
            bt_entrada_veiculos.Size = new System.Drawing.Size(102, 79);
            bt_entrada_veiculos.TabIndex = 1;
            bt_entrada_veiculos.Text = "ENTRADA DE VEÍCULOS";
            bt_entrada_veiculos.UseCompatibleTextRendering = true;
            bt_entrada_veiculos.UseVisualStyleBackColor = false;
            bt_entrada_veiculos.Click += new System.EventHandler(this.bt_entrada_veiculos_Click);
            // 
            // pb_carro_entrada
            // 
            pb_carro_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            pb_carro_entrada.Image = global::ProjetoEstacionamento.Properties.Resources.veiculo_frente_sem_fundo;
            pb_carro_entrada.Location = new System.Drawing.Point(133, 90);
            pb_carro_entrada.Name = "pb_carro_entrada";
            pb_carro_entrada.Size = new System.Drawing.Size(26, 27);
            pb_carro_entrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_carro_entrada.TabIndex = 8;
            pb_carro_entrada.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = global::ProjetoEstacionamento.Properties.Resources.veiculo_saindosem_fundo;
            pictureBox1.Location = new System.Drawing.Point(242, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(26, 27);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.Image = global::ProjetoEstacionamento.Properties.Resources.carro_problema_sem_fundo;
            pictureBox2.Location = new System.Drawing.Point(133, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(26, 27);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox3.Image = global::ProjetoEstacionamento.Properties.Resources.relatorio;
            pictureBox3.Location = new System.Drawing.Point(242, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(26, 27);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // bt_saida_veiculos
            // 
            bt_saida_veiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_saida_veiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            bt_saida_veiculos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            bt_saida_veiculos.FlatAppearance.BorderSize = 100;
            bt_saida_veiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            bt_saida_veiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            bt_saida_veiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_saida_veiculos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt_saida_veiculos.Location = new System.Drawing.Point(168, 40);
            bt_saida_veiculos.Name = "bt_saida_veiculos";
            bt_saida_veiculos.Size = new System.Drawing.Size(102, 79);
            bt_saida_veiculos.TabIndex = 2;
            bt_saida_veiculos.Text = "SAÍDA DE VEÍCULOS";
            bt_saida_veiculos.UseCompatibleTextRendering = true;
            bt_saida_veiculos.UseVisualStyleBackColor = false;
            bt_saida_veiculos.Click += new System.EventHandler(this.bt_saida_veiculos_Click);
            // 
            // bt_relatorios
            // 
            bt_relatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_relatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            bt_relatorios.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            bt_relatorios.FlatAppearance.BorderSize = 100;
            bt_relatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            bt_relatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            bt_relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_relatorios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt_relatorios.Location = new System.Drawing.Point(168, 125);
            bt_relatorios.Name = "bt_relatorios";
            bt_relatorios.Size = new System.Drawing.Size(102, 79);
            bt_relatorios.TabIndex = 4;
            bt_relatorios.Text = "RELATÓRIOS";
            bt_relatorios.UseCompatibleTextRendering = true;
            bt_relatorios.UseVisualStyleBackColor = true;
            // 
            // bt_relatar_problema
            // 
            bt_relatar_problema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_relatar_problema.Cursor = System.Windows.Forms.Cursors.Hand;
            bt_relatar_problema.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            bt_relatar_problema.FlatAppearance.BorderSize = 100;
            bt_relatar_problema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            bt_relatar_problema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            bt_relatar_problema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_relatar_problema.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt_relatar_problema.Location = new System.Drawing.Point(60, 125);
            bt_relatar_problema.Name = "bt_relatar_problema";
            bt_relatar_problema.Size = new System.Drawing.Size(102, 79);
            bt_relatar_problema.TabIndex = 3;
            bt_relatar_problema.Text = "RELATAR PROBLEMA";
            bt_relatar_problema.UseCompatibleTextRendering = true;
            bt_relatar_problema.UseVisualStyleBackColor = true;
            // 
            // menuStrip_principal
            // 
            this.menuStrip_principal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_menu,
            this.ms_ajuda,
            this.ms_sair});
            this.menuStrip_principal.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_principal.Name = "menuStrip_principal";
            this.menuStrip_principal.Size = new System.Drawing.Size(744, 24);
            this.menuStrip_principal.TabIndex = 0;
            this.menuStrip_principal.Text = "menuStrip1";
            // 
            // ms_menu
            // 
            this.ms_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_registrar_entrada,
            this.ms_registrar_saida,
            this.ms_relatar_problema,
            this.ms_impressao_relatorio});
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(51, 20);
            this.ms_menu.Text = "Menu";
            // 
            // ms_registrar_entrada
            // 
            this.ms_registrar_entrada.Name = "ms_registrar_entrada";
            this.ms_registrar_entrada.Size = new System.Drawing.Size(214, 22);
            this.ms_registrar_entrada.Text = "Registrar Entrada";
            // 
            // ms_registrar_saida
            // 
            this.ms_registrar_saida.Name = "ms_registrar_saida";
            this.ms_registrar_saida.Size = new System.Drawing.Size(214, 22);
            this.ms_registrar_saida.Text = "Registrar Saída";
            // 
            // ms_relatar_problema
            // 
            this.ms_relatar_problema.Name = "ms_relatar_problema";
            this.ms_relatar_problema.Size = new System.Drawing.Size(214, 22);
            this.ms_relatar_problema.Text = "Relatar Problema";
            // 
            // ms_impressao_relatorio
            // 
            this.ms_impressao_relatorio.Name = "ms_impressao_relatorio";
            this.ms_impressao_relatorio.Size = new System.Drawing.Size(214, 22);
            this.ms_impressao_relatorio.Text = "Impressão de Relatórios";
            // 
            // ms_ajuda
            // 
            this.ms_ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_suporte_ti,
            this.ms_suporte_adm});
            this.ms_ajuda.Name = "ms_ajuda";
            this.ms_ajuda.Size = new System.Drawing.Size(52, 20);
            this.ms_ajuda.Text = "Ajuda";
            // 
            // ms_suporte_ti
            // 
            this.ms_suporte_ti.Name = "ms_suporte_ti";
            this.ms_suporte_ti.Size = new System.Drawing.Size(149, 22);
            this.ms_suporte_ti.Text = "Suporte TI";
            // 
            // ms_suporte_adm
            // 
            this.ms_suporte_adm.Name = "ms_suporte_adm";
            this.ms_suporte_adm.Size = new System.Drawing.Size(149, 22);
            this.ms_suporte_adm.Text = "Suporte Adm";
            // 
            // ms_sair
            // 
            this.ms_sair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_fechar_sistema});
            this.ms_sair.Name = "ms_sair";
            this.ms_sair.Size = new System.Drawing.Size(42, 20);
            this.ms_sair.Text = "Sair";
            // 
            // ms_fechar_sistema
            // 
            this.ms_fechar_sistema.Name = "ms_fechar_sistema";
            this.ms_fechar_sistema.Size = new System.Drawing.Size(166, 22);
            this.ms_fechar_sistema.Text = "Fechar Sistema";
            // 
            // pb_sair
            // 
            this.pb_sair.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.pb_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_sair.Image = global::ProjetoEstacionamento.Properties.Resources.sair_vermelho;
            this.pb_sair.Location = new System.Drawing.Point(29, 279);
            this.pb_sair.Name = "pb_sair";
            this.pb_sair.Size = new System.Drawing.Size(36, 30);
            this.pb_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sair.TabIndex = 6;
            this.pb_sair.TabStop = false;
            this.pb_sair.Click += new System.EventHandler(this.pb_sair_Click);
            // 
            // lb_sair
            // 
            this.lb_sair.AutoSize = true;
            this.lb_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sair.ForeColor = System.Drawing.Color.Red;
            this.lb_sair.Location = new System.Drawing.Point(32, 310);
            this.lb_sair.Name = "lb_sair";
            this.lb_sair.Size = new System.Drawing.Size(29, 13);
            this.lb_sair.TabIndex = 7;
            this.lb_sair.Text = "Sair";
            // 
            // dgv_menu
            // 
            this.dgv_menu.AllowUserToAddRows = false;
            this.dgv_menu.AllowUserToDeleteRows = false;
            this.dgv_menu.AllowUserToOrderColumns = true;
            this.dgv_menu.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_menu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_placa,
            this.col_data_entrada,
            this.col_hora_entrada});
            this.dgv_menu.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_menu.Location = new System.Drawing.Point(393, 58);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.ReadOnly = true;
            this.dgv_menu.Size = new System.Drawing.Size(339, 265);
            this.dgv_menu.TabIndex = 12;
            this.dgv_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_placa
            // 
            this.col_placa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.col_placa.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_placa.HeaderText = "PLACA";
            this.col_placa.MaxInputLength = 7;
            this.col_placa.Name = "col_placa";
            this.col_placa.ReadOnly = true;
            this.col_placa.Width = 66;
            // 
            // col_data_entrada
            // 
            this.col_data_entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.col_data_entrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_data_entrada.HeaderText = "DATA DE ENTRADA";
            this.col_data_entrada.MaxInputLength = 10;
            this.col_data_entrada.Name = "col_data_entrada";
            this.col_data_entrada.ReadOnly = true;
            this.col_data_entrada.Width = 123;
            // 
            // col_hora_entrada
            // 
            this.col_hora_entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.col_hora_entrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_hora_entrada.HeaderText = "HORA DE ENTRADA";
            this.col_hora_entrada.MaxInputLength = 10;
            this.col_hora_entrada.Name = "col_hora_entrada";
            this.col_hora_entrada.ReadOnly = true;
            this.col_hora_entrada.Width = 124;
            // 
            // lb_grid
            // 
            this.lb_grid.AutoSize = true;
            this.lb_grid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_grid.ForeColor = System.Drawing.Color.Green;
            this.lb_grid.Location = new System.Drawing.Point(486, 40);
            this.lb_grid.Name = "lb_grid";
            this.lb_grid.Size = new System.Drawing.Size(165, 18);
            this.lb_grid.TabIndex = 14;
            this.lb_grid.Text = "Veículos estacionados";
            this.lb_grid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(55, 0);
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::ProjetoEstacionamento.Properties.Resources.imagemfundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(744, 333);
            this.Controls.Add(this.lb_grid);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pb_carro_entrada);
            this.Controls.Add(this.lb_sair);
            this.Controls.Add(this.pb_sair);
            this.Controls.Add(bt_relatorios);
            this.Controls.Add(bt_relatar_problema);
            this.Controls.Add(bt_saida_veiculos);
            this.Controls.Add(bt_entrada_veiculos);
            this.Controls.Add(this.menuStrip_principal);
            this.Controls.Add(this.dgv_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_principal;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATOS Parking";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(pb_carro_entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.menuStrip_principal.ResumeLayout(false);
            this.menuStrip_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_principal;
        private System.Windows.Forms.ToolStripMenuItem ms_menu;
        private System.Windows.Forms.ToolStripMenuItem ms_registrar_entrada;
        private System.Windows.Forms.ToolStripMenuItem ms_registrar_saida;
        private System.Windows.Forms.ToolStripMenuItem ms_relatar_problema;
        private System.Windows.Forms.ToolStripMenuItem ms_impressao_relatorio;
        private System.Windows.Forms.ToolStripMenuItem ms_ajuda;
        private System.Windows.Forms.ToolStripMenuItem ms_suporte_ti;
        private System.Windows.Forms.ToolStripMenuItem ms_suporte_adm;
        private System.Windows.Forms.ToolStripMenuItem ms_sair;
        private System.Windows.Forms.ToolStripMenuItem ms_fechar_sistema;
        private System.Windows.Forms.PictureBox pb_sair;
        private System.Windows.Forms.Label lb_sair;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.Label lb_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hora_entrada;
    }
}

