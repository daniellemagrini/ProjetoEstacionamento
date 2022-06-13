using ProjetoEstacionamento.Classes;
using ProjetoEstacionamento.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            List<Veiculo> listaVeiculos = new List<Veiculo>();
            Arquivo.CarregarArquivo(listaVeiculos);
        }

        private void pb_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_entrada_veiculos_Click(object sender, EventArgs e)
        {
            frm_entrada_veiculos frm = new frm_entrada_veiculos();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void bt_saida_veiculos_Click(object sender, EventArgs e)
        {
            frm_saida_veiculos frm = new frm_saida_veiculos();
            frm.Show();
        }
    }
}
