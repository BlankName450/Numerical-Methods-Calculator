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
    public partial class Secant : Form
    {
        double Xold = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        double xnew = 0;

        public Secant()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double f(double xx)
        {
            try
            {
                string w = txt_fx.Text;
                double result;
                result = Eval.Execute<double>(txt_fx.Text.ToString(), new { x = xx });
                return (Math.Round(result,4));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_error.Text = "";
            txt_Ferror.Text = "";
            txt_fx.Text = "";
            txt_root.Text = "";
            txt_x0.Text = "";
            txt_xold.Text = "";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double xol = Convert.ToDouble(txt_xold.Text);
            double x0 = Convert.ToDouble(txt_x0.Text);
            Secan(xol , x0);
        }

        void Secan (double xol , double x0 )
        {
           
            if (counter == 0)
            {
                Xold = xol;
                xi = x0;
                dataGridView1.Rows.Add(counter.ToString(), Xold.ToString(), Math.Round(f(Xold),4).ToString() , xi.ToString() , Math.Round(f(xi),4).ToString() , "---" );
                counter++; Secan(Xold , xi );
            }
            else
            {
                Xold = xol;
                xi = x0;
                xnew =  xi - ((f(xi) * (Xold - xi)) / (f(Xold) - f(xi)));
                error = Math.Abs((xnew - xi) / xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(),Math.Round(xi,4).ToString(), Math.Round(f(xi),4).ToString(), Math.Round(xnew, 4).ToString(), Math.Round(f(xnew),4).ToString(), Math.Round(error, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(txt_error.Text);
                if (error > Err)
                    Secan(xi , xnew);
            }
            txt_root.Text = Math.Round(xnew,4).ToString();
            txt_Ferror.Text = Math.Round(error,4).ToString();
        }
    }
}
