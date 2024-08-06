using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(txt_renda.Text);
            double energia = double.Parse(txt_energia.Text);
            double agua = double.Parse(txt_agua.Text);
            double tv = double.Parse(txt_tv.Text);
            double alimentacao = double.Parse(txt_alimentacao.Text);
            double outros = double.Parse(txt_outros.Text);

            double resultado = energia+ agua+ tv+ alimentacao+outros ;
            double saldo = renda - resultado;

            lbl_resultado.Text = resultado.ToString();
            lbl_saldo.Text = saldo.ToString();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_renda.Clear();
            txt_energia.Clear();
            txt_agua.Clear()    ;
            txt_tv.Clear();
            txt_alimentacao.Clear();
            txt_outros.Clear();

            lbl_resultado.Text = "";
            lbl_saldo.Text = "";
        }
    }
}
