using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerics_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Bisection":
                    Bisection b = new Bisection();
                    this.Hide();
                    b.Show();
                    break;
                case "False-Postion":
                    FalsePostion f = new FalsePostion();
                    this.Hide();
                    f.Show();
                    break;
                case "Simple-Fixed-Point":
                    Fixed s = new Fixed();
                    this.Hide();
                    s.Show();
                    break;
                case "Newton":
                    Newton n = new Newton();
                    this.Hide();
                    n.Show();
                    break;
                case "Secant":
                    Secant se = new Secant();
                    this.Hide();
                    se.Show();
                    break;
            }
            switch (comboBox2.Text)
            {
                case "Gauss-Elimination":
                    GaussElimination ge = new GaussElimination();
                    this.Hide();
                    ge.Show();
                    break;
                case "LU_Decomposition":
                    LU_Decomposition ld = new LU_Decomposition();
                    this.Hide();
                    ld.Show();
                    break;

                case "Cramer-Rule":
                    CramerRule cr = new CramerRule();
                    this.Hide();
                    cr.Show();
                    break;
            }
        }
        

        
    }
}
