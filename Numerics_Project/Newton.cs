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
    public partial class Newton : Form
    {
        double Xnew = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        public Newton()
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
                return (Math.Round(result,4));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }
        }

        double Fdash(double xx)
        {
            try
            {
                string w = txt_fdash.Text;
                double result;
                result = Eval.Execute<double>(txt_fdash.Text.ToString(), new { x = xx });
                return (Math.Round(result, 4));
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txt_x0.Text);
            Newto(x0);
        }

        void Newto(double x) 
        {
            if (counter == 0)
            {
                xi = x;
                dataGridView1.Rows.Add(counter.ToString(),
                    Math.Round(xi,4).ToString(),
                    Math.Round(f(xi),4).ToString() ,
                    Math.Round(Fdash(xi)).ToString() , "---");
                counter++; Newto(xi);
            }
            else
            {
                xi = x;
                Xnew = xi - (f(xi) / Fdash(xi));
                error = Math.Abs((Xnew - xi) / Xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xnew,4).ToString(), Math.Round(f(Xnew),5).ToString(),Math.Round(Fdash(Xnew),5).ToString(), Math.Round(error,4).ToString());
                counter++;
                double Err = Convert.ToDouble(txt_error.Text);
                if (error > Err)
                    Newto(Xnew);
            }
            txt_root.Text = Math.Round(Xnew, 4).ToString();
            txt_Ferror.Text = Math.Round(error, 4).ToString();
        }

        private void txt_root_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
