using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konvertor_valyut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        int Dollar = 27;
        int Euro = 429;
        int UAH = 1;
        int x;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) convert(Dollar);
            else if (radioButton2.Checked) convert(Euro);
            else if (radioButton3.Checked) convert(UAH);
            else MessageBox.Show("Вы не выбрали валюту для перевода");
        }
        private void convert(int Kurs)
        {
            if (int.TryParse(textBox3.Text, out x))
                textBox1.Text = (Kurs * x).ToString();
            else
                MessageBox.Show("Вы не указали сумму в гривне");
        }
    }
}
