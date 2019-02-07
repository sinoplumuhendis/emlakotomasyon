using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Emlak_Program
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Yönetici Girişi")
            {
                Form1 emlakkayıt2 = new Form1();
                emlakkayıt2.Show();
                this.Hide();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Kullanıcı Girişi")
            {
                Form2 emlakkayıt = new Form2();
                emlakkayıt.Show();
                this.Hide();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
