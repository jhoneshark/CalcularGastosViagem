using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Viagem
{
    public partial class FrmRelatorio : Form
    {
        private float distancia, consumo, combustivel, pedagio;


        public FrmRelatorio(float distancia, float consumo, float combustivel, float pedagio)
        {
            this.distancia = distancia;
            this.consumo = consumo;
            this.combustivel = combustivel;
            this.pedagio = pedagio;
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            float qtdLitros = calcularQtdLitros(distancia, consumo);
            float vTotalCombustivel = calcularValorGastoCombustivel(qtdLitros, combustivel);
            float vTotalViagem = calcularTotalViagem(vTotalCombustivel, pedagio);
            String aux = "";

            aux = "Distancia informada: " + distancia + "km";
            adicionaTexto(aux);

            aux = "Consumo do veiculo informado: " + consumo + "Km/L";
            adicionaTexto(aux);

            aux = "Valor informado do combustivel: R$" + combustivel;
            adicionaTexto(aux);

            aux = "Houve gasto com pedagio: " + (pedagio == 0 ? "Não" : "Sim");
            adicionaTexto(aux);

            if(pedagio != 0)
            {
                aux = "Valor gasto com pedagio(s): R$" + pedagio;
                adicionaTexto(aux);
            }

            rtRelatorio.AppendText(Environment.NewLine + "-------------------" + Environment.NewLine);

            aux = "Quantidade de litros utilizado: " + qtdLitros + "L";
            adicionaTexto(aux);

            aux = "Valor total gasto com combustível: R$" + vTotalCombustivel;
            adicionaTexto(aux);

            aux = "-> Valor total da Viagem: R$" + vTotalViagem;
            adicionaTexto(aux);
        }

        private float calcularQtdLitros(float distancia, float consumo)
        {
            return distancia / consumo;
        }

        private float calcularValorGastoCombustivel(float qtdLitros, float vCombustivel)
        {
            return qtdLitros * vCombustivel;
        }

        private float calcularTotalViagem(float vGastoCombustivel, float vPedagios)
        {
            return vGastoCombustivel + vPedagios;
        }


        private void adicionaTexto(string texto)
        {
            string[] aux = texto.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            if (aux.Length == 2)
            {
                rtRelatorio.DeselectAll();
                rtRelatorio.SelectionFont = new Font(rtRelatorio.SelectionFont, FontStyle.Bold);
                rtRelatorio.AppendText(Environment.NewLine + aux[0] + ": ");
                rtRelatorio.SelectionFont = new Font(rtRelatorio.SelectionFont, FontStyle.Regular);
                rtRelatorio.AppendText(aux[1]);
            }
      
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo texto | *.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.ShowDialog();

            if (String.IsNullOrEmpty(saveFileDialog.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(rtRelatorio.Text);
                        writer.Flush();
                    }
                }
                catch (Exception ex) 
                {

                    MessageBox.Show(string.Format("Não foi possivel salvar o seu arquivo. Erro: {0}", ex.Message
                        ), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }


        

        private void btFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


    }   
}
