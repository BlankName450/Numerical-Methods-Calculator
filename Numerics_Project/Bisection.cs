using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Numerics_Project
{
    public partial class Bisection : Form
    {
        double xolder = 0;
        double xr = 0;
        double error = 0;
        int counter = 0;

      

        public Bisection()
        {
            InitializeComponent();
        }

        double f(double xx)
        {
            try
            {
                string func = txt_fx.Text; 
                double result;
                result = Eval.Execute<double>(txt_fx.Text.ToString(), new { x = xx });
                return (Math.Round(result,3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double xl = Convert.ToDouble(txt_xl.Text);
            double xu = Convert.ToDouble(txt_xu.Text);
            double Err = Convert.ToDouble(txt_error.Text);

            if (f(xl) * f(xu) < 0)
            {
                do
                {
                    xr = (xl + xu) / 2;
                    error = Math.Abs((xr - xolder) / xr) * 100;
                    xolder = xr;

                    dataGridView1.Rows.Add(counter.ToString(), Math.Round(xl, 3).ToString(),
                        f(xl).ToString(), Math.Round(xu, 3).ToString(), f(xu).ToString(),
                        Math.Round(xr, 3).ToString(), f(xr).ToString(), Math.Round(error, 3).ToString());
                    counter++;

                    if (f(xl) * f(xr) < 0)
                    {
                        xu = xr;
                    }
                    else if (f(xl) * f(xr) > 0)
                    {
                        xl = xr;
                    }
                } while (error > (Err / 100) * 100);

                txt_root.Text = Math.Round(xr,3).ToString();
                txt_Ferror.Text = Math.Round(error, 3).ToString();
            }
            else
                MessageBox.Show("No solution", "Warnning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fx.Text = "";
            txt_xu.Text = "";
            txt_xl.Text = "";
            txt_root.Text = "";
            txt_Ferror.Text = " ";
            txt_error.Text = "";

            double xolder = 0;
            double xr = 0;
            double error = 0;
            int counter = 1;
            double xl = 0;
            double xu = 0;

            dataGridView1.Rows.Clear();



        }

        private void txt_xu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
