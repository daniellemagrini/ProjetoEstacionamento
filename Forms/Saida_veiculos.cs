using ProjetoEstacionamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento.Forms
{
    public partial class frm_saida_veiculos : Form
    {
        public frm_saida_veiculos()
        {
            InitializeComponent();
            
            Arquivo.CarregarArquivo(listaVeiculos);
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            cb_placa_saida.Items.Clear();
            tb_dt_entrada_saida.Clear();
            tb_hr_entrada_saida.Clear();
            tb_dt_saida.Clear();
            tb_hr_saida.Clear();
            tb_vlr_a_pagar.Clear();
        }

        private void frm_saida_veiculos_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("veiculosEstacionados.dat");
            string linha = null;
            string[] vetorDados;

            while ((linha = sr.ReadLine()) != null)
            {
                vetorDados = linha.Split(';');
                cb_placa_saida.Items.Add(vetorDados[0]); ;
            }
            sr.Close();
        }

        private void cb_placa_saida_Leave(object sender, EventArgs e)
        {
            if (cb_placa_saida.Text == null)
            {
                return;
            }
            else { 
                tb_dt_entrada_saida.Text = Convert.ToString(Veiculo.RetornaDataEntrada(cb_placa_saida.Text, listaVeiculos));
                tb_hr_entrada_saida.Text = Veiculo.RetornaHoraEntrada(cb_placa_saida.Text, listaVeiculos);
                tb_dt_saida.Text = DateTime.Now.ToShortDateString();
                tb_hr_saida.Text = DateTime.Now.ToString("HH:mm:ss");
                tb_vlr_a_pagar.Text = Convert.ToString(Veiculo.ValorPagar(cb_placa_saida.Text, listaVeiculos));
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_placa_saida.Text))
            {
                MessageBox.Show("Favor informar a placa do veículo");
            }
            else
            {
                Veiculo.ProcuraVeiculos(cb_placa_saida.Text, listaVeiculos);

                string dataSaida = tb_dt_saida.Text;
                string horaSaida = tb_hr_saida.Text;
                string valorTotal = tb_vlr_a_pagar.Text;
                Arquivo_saida.LiberarVaga(cb_placa_saida.Text, listaVeiculos, listaVeiculosSaida);
                Veiculo vs = new Veiculo(cb_placa_saida.Text, tb_dt_entrada_saida.Text, tb_hr_entrada_saida.Text, tb_dt_saida.Text, tb_hr_saida.Text, tb_vlr_a_pagar.Text);
                Arquivo_saida.GravaArquivoSaida(vs);
                Arquivo.GravaArquivo(listaVeiculos);

                cb_placa_saida.Items.Clear();

                StreamReader sr = File.OpenText("veiculosEstacionados.dat");
                string linha = null;
                string[] vetorDados;

                while ((linha = sr.ReadLine()) != null)
                {
                    vetorDados = linha.Split(';');
                    cb_placa_saida.Items.Add(vetorDados[0]); ;
                }
                sr.Close();

                tb_dt_entrada_saida.Clear();
                tb_hr_entrada_saida.Clear();
                tb_dt_saida.Clear();
                tb_hr_saida.Clear();
                tb_vlr_a_pagar.Clear();

            }
        }

        //variavel global dentro deste codigo todo
        List<Veiculo> listaVeiculos = new List<Veiculo>();
        List<Veiculo> listaVeiculosSaida = new List<Veiculo>();
    }
}
