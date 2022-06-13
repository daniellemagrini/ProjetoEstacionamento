using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento.Classes
{
    public class Arquivo_saida
    {
        #region GRAVAR ARQUIVO DE SAÍDA
        public static void GravaArquivoSaida(Veiculo objeto)
        {
            try
            {
                StreamWriter sw = new StreamWriter("historicoSaida.dat", true);
                sw.Flush();
                sw.WriteLine(objeto.Placa + ";" + objeto.DataEntrada + ";" + objeto.HoraEntrada + ";" + objeto.DataSaida + ";" + objeto.HoraSaida + ";" + objeto.ValorTotal);
                MessageBox.Show("Vaga liberada");
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Arquivo com problema. Favor entrar em contato com o suporte");
            }
        }
        #endregion

        #region CARREGAR OS DADOS DO ARQUIVO DE SAÍDA
        public static void CarregarArquivoSaida(List<Veiculo> listaVeiculosSaida)
        {

            try
            {
                StreamReader sr = new StreamReader("historicoSaida.dat");
                string linha;
                string[] dados;
                do
                {
                    linha = sr.ReadLine();
                    dados = linha.Split(';');
                    listaVeiculosSaida.Add(new Veiculo(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5]));
                }
                while (!sr.EndOfStream);
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Arquivo com problemas");
            }
        }
        #endregion

        #region REMOVER VEÍCULO ESTACIONADO E PASSAR PARA O HISTÓRICO DE VEÍCULOS

        public static void LiberarVaga(string placa, List<Veiculo> listaVeiculos, List<Veiculo> listaVeiculosSaida)
        {
            int posicao = Veiculo.ProcuraVeiculos(placa, listaVeiculos);
            Veiculo v_temp = listaVeiculos[posicao];
            string dt_entr = v_temp.DataEntrada;
            string hr_entr = v_temp.HoraEntrada;
            listaVeiculos.RemoveAt(posicao);            
        }

        #endregion

        #region GRAVANDO ARQUIVO DEPOIS DE DAR SAÍDA EM VEÍCULO
        
        #endregion
        
    }
}
