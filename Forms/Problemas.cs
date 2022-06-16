using ProjetoEstacionamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento.Forms
{
    public partial class frm_problemas : Form
    {
        public frm_problemas()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            tb_dt_problema.Text = DateTime.Now.ToShortDateString();
            Arquivo.GravaArquivoProblema(tb_dt_problema.Text, tb_det_problema.Text);
        }
    }
}
