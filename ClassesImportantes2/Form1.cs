using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Olá, sou uma janela de menssagem");
            // MessageBox.Show("Olá, sou uma janela de menssagem", "Título da minha janela");
            //MessageBox.Show("Mensagem Na Janela", "Título da Janela", MessageBoxButtons.YesNoCancel);
            //MessageBox.Show("Mensagem Na Janela", "Título da Janela", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //MessageBox.Show("Mensagem Na Janela");
            DialogResult resultadoJanela = MessageBox.Show("Mensagem da Janela", "Título da Janela",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (resultadoJanela == DialogResult.Yes)
            {
                labelresult.Text = "Você selecionou a opção SIM";

            }
            else if (resultadoJanela == DialogResult.No)
            {
                labelresult.Text = "Você seleciounou a opção NÃO";
            }

            else
            {
                // labeltex.Text= "";
                // labeltex.Text= null;
                labelresult.Text = string.Empty;
            }

            //labeltex.Text = resultadoJanela.ToString();
            //text fakeee


        }
    }
    }

