using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aritmetik_4_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam, fark, bölüm, çarpım;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            toplam = s1 + s2;
            fark = s1 - s2;
            bölüm = s1 / s2;
            çarpım = s1 * s2;
            MessageBox.Show("Toplam: " + toplam + "\n" + "Fark: " + fark + "\n" + "Bölüm: " + bölüm + "\n" + "Çarpım: " + çarpım);

        }
    }
}
