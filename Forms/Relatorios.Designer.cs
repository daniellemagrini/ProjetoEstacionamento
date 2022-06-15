namespace ProjetoEstacionamento.Forms
{
    partial class frm_relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_relatorios));
            this.bt_rel_estacionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_rel_estacionados
            // 
            this.bt_rel_estacionados.Location = new System.Drawing.Point(41, 33);
            this.bt_rel_estacionados.Name = "bt_rel_estacionados";
            this.bt_rel_estacionados.Size = new System.Drawing.Size(166, 65);
            this.bt_rel_estacionados.TabIndex = 0;
            this.bt_rel_estacionados.Text = "Relatório de Veículos Estacionados";
            this.bt_rel_estacionados.UseVisualStyleBackColor = true;
            // 
            // frm_relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.bt_rel_estacionados);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de Relatórios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_rel_estacionados;
    }
}