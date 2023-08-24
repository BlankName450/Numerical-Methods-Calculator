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
    public partial class Fixed : Form
    {
        double Xnew = 0;
        double xi = 0;
        double error = 0;
        int counter = 0 ;

        public Fixed()
        {
            InitializeComponent();
        }

        double f(double xx)
        {
            try
            {
                string w = txt_fx.Text;
                double result;
                result = Eval.Execute<double>(txt_fx.Text.ToString(), new { x = xx });
                return (Math.Round(result,3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }
        }
        private void btn_sum_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txt_x0.Text);
            FixedSingle(x0);
        }

        void FixedSingle(double x)
        {
            if (counter == 0)
            {
                xi = x;
                dataGridView1.Rows.Add(counter.ToString(), xi.ToString(), "----");
                counter++; 
                FixedSingle(xi);
            }
            else
            {   
                xi = x;
                Xnew = f(xi);
                error = Math.Abs((Xnew - xi) / Xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xnew,4).ToString(), Math.Round(error,4).ToString());
                counter++;
                double Err = Convert.ToDouble(txt_error.Text);
                if (error > Err)
                    FixedSingle(Xnew);
            }

            txt_root.Text = Math.Round(Xnew, 3).ToString();
            txt_Ferror.Text = Math.Round(error,3).ToString();
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_error.Text = "";
            txt_Ferror.Text = "";
            txt_fx.Text = "";
            txt_root.Text = "";
            txt_x0.Text = "";
            double x0 = 0;
            double Xnew = 0;

            dataGridView1.Rows.Clear();
        }
    }
}
