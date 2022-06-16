using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento.Classes
{
    public class Arquivo
    {
        #region GRAVAR ARQUIVO
        public static void GravaArquivo(Veiculo objeto)
        {
            try
            {
                StreamWriter sw = new StreamWriter("veiculosEstacionados.dat", true);
                sw.Flush();
                sw.WriteLine(objeto.Placa + ";" + objeto.DataEntrada + ";" + objeto.HoraEntrada);
                MessageBox.Show("Veículo salvo com sucesso");
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo com problema. Favor entrar em contato com o suporte");
            }
        }

        public static void GravaArquivo(List<Veiculo> listaVeiculos)
        {
            try
            {
                StreamWriter sw = new StreamWriter("veiculosEstacionados.dat", true);
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo com problema. Favor entrar em contato com o suporte");
            }
        }
        #endregion

        #region CARREGAR OS DADOS DO ARQUIVO
        public static void CarregarArquivo(List<Veiculo> listaVeiculos)
        {

            try
            {
                StreamReader sr = new StreamReader("veiculosEstacionados.dat");
                string linha;
                string[] dados;
                do
                {
                    linha = sr.ReadLine();
                    dados = linha.Split(';');
                    listaVeiculos.Add(new Veiculo(dados[0], dados[1], dados[2]));
                }
                while (!sr.EndOfStream);
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo com problemas ou inexistente");
            }
        }
        #endregion

        #region CADASTRAR VEÍCULO

        public static void CadastrarVeiculo(List<Veiculo> listaVeiculos)
        {
            string placa = string.Empty;
            string dataEntrada = null;
            string horaEntrada = null;
            Veiculo veiculo = new Veiculo(placa, dataEntrada, horaEntrada);
            listaVeiculos.Add(veiculo);
            Arquivo.GravaArquivo(veiculo);
        }
        #endregion

        #region VER SE TEM VAGAS DISPONÍVEIS

        public static bool TemVaga(List<Veiculo> listaVeiculos)
        {
            StreamReader sr = new StreamReader("veiculosEstacionados.dat");
            int i = 0;

            while (sr.Peek() != -1)
            {
                i++;
                sr.ReadLine();
            }
            if (i == 50)
            {
                return false;
            }
            sr.Close();
            return true;           
        }
        #endregion

        #region GRAVAR ARQUIVO DE PROBLEMA
        public static void GravaArquivoProblema(string data, string problema)
        {
            try
            {
                StreamWriter sw = new StreamWriter("relatorioProblemas.dat", true);
                sw.Flush();
                sw.WriteLine("DATA:" + data + "; PROBLEMA: " + problema);
                MessageBox.Show("Problema reportado com sucesso");
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo com problema. Favor entrar em contato com o suporte");
            }
        }
        #endregion
    }
}

