using ProjetoEstacionamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento.Forms
{
    public partial class frm_entrada_veiculos : Form
    {
        public frm_entrada_veiculos()
        {
            InitializeComponent();
            Arquivo.CarregarArquivo(listaVeiculos);
        }

        //BOTAO VOLTAR - APENAS FECHA O FORM E VOLTA PARA O MENU PRINCIPAL
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //BOTÃO LIMPAR - LIMPAR TODOS OS CAMPOS
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            foreach (int checados in clb_moto.CheckedIndices)
            {
                clb_moto.SetItemChecked(checados, false);
            }

            foreach (int checados in clb_carro.CheckedIndices)
            {
                clb_carro.SetItemChecked(checados, false);
            }

            tb_placa_entrada.Clear();
            tb_dt_entrada.Clear();
            tb_hr_entrada.Clear();
        }

        private void clb_moto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //VERIFICA SE TODOS OS CAMPOS ESTÃO PREENCHIDOS E SALVA NO ARQUIVO, NO GRID E NA LISTA
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (Arquivo.TemVaga(listaVeiculos) == false)
            {
                MessageBox.Show("Estacionamento lotado. Não é possível dar entrada");
                return;
            }
            else
            {
                if (clb_moto.CheckedIndices.Count > 0 && clb_carro.CheckedIndices.Count > 0)
                {
                    MessageBox.Show("Obrigatório informar apenas um tipo de veículo (Moto ou Carro)");
                    return;
                }

                if (clb_moto.CheckedIndices.Count == 0 && clb_carro.CheckedIndices.Count == 0)
                {
                    MessageBox.Show("Obrigatório informar o tipo de veículo (Moto ou Carro)");
                    return;
                }

                if (Veiculo.ValidaPlaca(tb_placa_entrada.Text) == true)
                {

                    tb_dt_entrada.Text = DateTime.Now.ToShortDateString();
                    tb_hr_entrada.Text = DateTime.Now.ToString("HH:mm:ss");

                    List<Veiculo> listaVeiculos = new List<Veiculo>();
                    Veiculo v = new Veiculo(tb_placa_entrada.Text, tb_dt_entrada.Text, tb_hr_entrada.Text);
                    Arquivo.GravaArquivo(v);

                    foreach (int checados in clb_moto.CheckedIndices)
                    {
                        clb_moto.SetItemChecked(checados, false);
                    }

                    foreach (int checados in clb_carro.CheckedIndices)
                    {
                        clb_carro.SetItemChecked(checados, false);
                    }

                    tb_placa_entrada.Clear();
                    tb_dt_entrada.Clear();
                    tb_hr_entrada.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar os dados digitados");
                }
            }
        }

        //VERIFICA SE A PLACA É VÁLIDA (PADRÃO MERCOSUL E PADRÃO ANTIGO DO BRASIL)
        //E PREENCHE AUTOMATICAMENTE OS CAMPOS DE DATA E HORA CONFORME SISTEMA
        private void tb_placa_entrada_Leave(object sender, EventArgs e)
        {
            tb_dt_entrada.Text = DateTime.Now.ToShortDateString();
            tb_hr_entrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        List<Veiculo> listaVeiculos = new List<Veiculo>();
    }
}

