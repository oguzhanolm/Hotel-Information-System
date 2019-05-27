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
    public partial class AgacIslemleri : Form
    {
        public AgacIslemleri()
        {
            InitializeComponent();
        }
        IkiliAramaAgac agac;

        private void AgacIslemleri_Load(object sender, EventArgs e)
        {
            OtelProvider op = new OtelProvider();
            agac = op.AgacaOtelEkle();
        }

            

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            agac.PreOrder();
            richTextBox1.Text = agac.DugumleriYazdir();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            agac.InOrder();
            richTextBox1.Text = agac.DugumleriYazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            agac.PostOrder();
            richTextBox1.Text = agac.DugumleriYazdir();
        }


    }
}
