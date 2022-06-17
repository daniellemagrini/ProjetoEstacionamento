using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ProjetoEstacionamento.Classes
{
    public class Veiculo
    {
        List<Veiculo> listaVeiculos = new List<Veiculo>();
        List<Veiculo> listaVeiculosSaida = new List<Veiculo>();
        string tipo;
        string placa;
        string dataEntrada = DateTime.UtcNow.ToShortDateString();
        string dataSaida = DateTime.UtcNow.ToShortDateString();
        string horaEntrada = DateTime.UtcNow.ToString("HH:mm:ss");
        string horaSaida = DateTime.UtcNow.ToString("HH:mm:ss");
        double valorHora;
        double valorTotal;
        string valor;

        CultureInfo Culture = new CultureInfo("pt-BR");

        #region ENTRADA DE VEÍCULOS
        public Veiculo(string placa, string dataEntrada, string horaEntrada)
        {
            this.placa = placa;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
            listaVeiculos.Add(this);
        }

        public Veiculo(string placa, string dataSaida, string horaSaida, string valor)
        {
            this.placa = placa;
            this.dataSaida = dataSaida;
            this.HoraSaida = horaSaida;
            this.valor = valor;
            listaVeiculosSaida.Add(this);
        }

        public Veiculo(string placa, string dataEntrada, string horaEntrada, string dataSaida, string horaSaida, string valor) : this(placa,dataEntrada,horaEntrada)
        {
            this.dataSaida = dataSaida;
            this.HoraSaida = horaSaida;
            this.valor = valor;
            listaVeiculosSaida.Add(this);
        }   


        public Veiculo(string placa)
        {
            this.placa = placa;
        }

        public Veiculo(List<Veiculo> listaVeiculos)
        {
            this.listaVeiculos = listaVeiculos;
        }

        public Veiculo(List<Veiculo> listaVeiculos, List<Veiculo> listaVeiculosSaida)
        {
            this.listaVeiculos = listaVeiculos;
            this.listaVeiculosSaida = listaVeiculosSaida;
        }
        #endregion

        #region GETTERs E SETTERs
        public string Tipo { get => tipo; set => tipo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public string Valor { get => valor; set => valor = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }


        #endregion

        #region VEÍCULOS ESTACIONADOS
        public static bool Estacionado(string placa, List<Veiculo> listaVeiculos)
        {
            foreach (Veiculo i in listaVeiculos)
            {
                if (i.placa.Equals(placa))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region PROCURAR VEÍCULOS

        public static int ProcuraVeiculos(string placa, List<Veiculo> listaVeiculos)
        {
            foreach (Veiculo i in listaVeiculos)
            {
                if (i.placa.Equals(placa))
                {
                    return listaVeiculos.IndexOf(i);
                }
            }
            return -1;
        }
        #endregion

        #region VALIDAR PLACA
        public static bool ValidaPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa) && string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("É necessário informar a placa do veículo. Caso o veículo não tenha placa, favor informar NOV1234.");
                return false;
            }

            if (placa.Length > 8)
            {
                MessageBox.Show("Placa Inválida");
                return false;
            }
            if (placa.Length < 7)
            {
                MessageBox.Show("Placa Inválida");
                return false;
            }
            if (placa.Length == 7)
            {
                var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
                var padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");

                if (padraoMercosul.IsMatch(placa) || padraoNormal.IsMatch(placa))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Placa Inválida");
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region CALCULAR VALOR A PAGAR

        public static double ValorPagar(string placa, List<Veiculo> listaVeiculos)
        {
            double valorTotal = 0;

            if (placa != "")
            {
                int posicao = Veiculo.ProcuraVeiculos(placa, listaVeiculos);
                Veiculo vTemp = listaVeiculos[posicao];
                string pl = vTemp.placa;
                string dt_ent = vTemp.dataEntrada;
                string hr_ent = vTemp.horaEntrada;
                double valorHora = 2.50;
                int valorDia = 45;
                string dataSaida = DateTime.Now.ToShortDateString();
                string horaSaida = DateTime.Now.ToString("HH:mm:ss");

                while (placa == pl)
                {
                    DateTime dtt_saida = Convert.ToDateTime(dataSaida);
                    DateTime dtt_entrada = Convert.ToDateTime(vTemp.dataEntrada);
                    DateTime dth_saida = Convert.ToDateTime(horaSaida);
                    DateTime dth_entrada = Convert.ToDateTime(vTemp.horaEntrada);
                    TimeSpan dt = dtt_saida.Subtract(dtt_entrada);
                    TimeSpan dth_total = dth_saida - dth_entrada;
                    double tempo_min = dth_total.TotalMinutes;
                    double tempo_hr = dth_total.TotalHours;

                    if (dt.TotalDays > 0)
                    {
                        valorTotal = valorDia * dt.TotalDays;
                        return valorTotal;
                    }
                    if (dt.TotalDays == 0)
                    {
                        if (tempo_min <= 70) // tolerância de 10min. resto da divisão sobra 6
                        {
                            valorTotal = valorHora;
                            return valorTotal;
                        }
                        else if (tempo_min > 60)
                        {
                            if (tempo_min % 60 >= 0 && tempo_min % 60 <= 6)
                            {
                                double tempoHora = tempo_min / 60;
                                int tempoHora_temp = Convert.ToInt32(tempoHora);
                                valorTotal = valorHora * tempoHora_temp;
                                return valorTotal;
                            }
                            else
                            {
                                double tempoHora = tempo_min / 60;
                                int tempoHora_temp = Convert.ToInt32(tempoHora);
                                valorTotal = (valorHora * tempoHora_temp) + valorHora;
                                return valorTotal;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Total de dias/horas inválidos. Favor contatar o suporte");
                    }
                }                
            }
            return valorTotal;
        }
        #endregion

        #region RETORNAR DADOS DE ENTRADA NA TELA DE SAÍDA

        //DEIXEI COM MANEIRAS DIFERENTES DE PUXAR OS DADOS PARA APRENDIZADO!
        public static string RetornaDataEntrada(string placa, List<Veiculo> listaVeiculos)
        {
            if (placa != "")
            {
                int posicao = Veiculo.ProcuraVeiculos(placa, listaVeiculos);
                Veiculo v_temp = listaVeiculos[posicao];
                string dt_ent = v_temp.dataEntrada;

                return dt_ent;
            }
            return null;
        }

        public static string RetornaHoraEntrada(string placa, List<Veiculo> listaVeiculos)
        {
            string hr_entrada = String.Empty;
            foreach (Veiculo i in listaVeiculos)
            {
                if (i.placa.Equals(placa))
                {
                    hr_entrada = i.horaEntrada;
                }
            }
            return hr_entrada;
        }
        #endregion
    }
}



