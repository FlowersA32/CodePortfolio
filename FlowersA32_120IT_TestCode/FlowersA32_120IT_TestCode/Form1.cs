using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersA32_120IT_TestCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbIn1.SelectedIndex = 0;
            cbIn2.SelectedIndex = 0;
            cbIn3.SelectedIndex = 0;
            cbIn4.SelectedIndex = 0;
            lblOut1.Visible = false;
            lblOut2.Visible = false;
            lblOut3.Visible = false;
            lblOut4.Visible = false;
            mtbIn1.KeyPress += MtbIn1_KeyPress;
            mtbIn2.KeyPress += MtbIn2_KeyPress;
        }

        private void MtbIn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delLett = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delLett;
        }

        private void MtbIn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delLett = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delLett;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal res1;
            decimal res2;
            decimal res3;
            decimal res4;
            if (cbIn1.Text == "+")
            {
                res1 = Convert.ToDecimal(mtbIn1.Text) + Convert.ToDecimal(mtbIn2.Text);
                lblOut1.Text = res1.ToString();
            }
            else if (cbIn1.Text == "-")
            {
                res1 = Convert.ToDecimal(mtbIn1.Text) - Convert.ToDecimal(mtbIn2.Text);
                lblOut1.Text = res1.ToString();
            }
            else if (cbIn1.Text == "/")
            {
                res1 = Convert.ToDecimal(mtbIn1.Text) / Convert.ToDecimal(mtbIn2.Text);
                lblOut1.Text = res1.ToString();
            }
            else if (cbIn1.Text == "*")
            {
                res1 = Convert.ToDecimal(mtbIn1.Text) * Convert.ToDecimal(mtbIn2.Text);
                lblOut1.Text = res1.ToString();
            }

            if (cbIn2.Text == "+")
            {
                res2 = Convert.ToDecimal(mtbIn3.Text) + Convert.ToDecimal(mtbIn4.Text);
                lblOut2.Text = res2.ToString();
            }
            else if (cbIn2.Text == "-")
            {
                res2 = Convert.ToDecimal(mtbIn3.Text) - Convert.ToDecimal(mtbIn4.Text);
                lblOut2.Text = res2.ToString();
            }
            else if (cbIn2.Text == "/")
            {
                res2 = Convert.ToDecimal(mtbIn3.Text) / Convert.ToDecimal(mtbIn4.Text);
                lblOut2.Text = res2.ToString();
            }
            else if (cbIn2.Text == "*")
            {
                res2 = Convert.ToDecimal(mtbIn3.Text) * Convert.ToDecimal(mtbIn4.Text);
                lblOut2.Text = res2.ToString();
            }

            if (cbIn3.Text == "+")
            {
                res3 = Convert.ToDecimal(mtbIn5.Text) + Convert.ToDecimal(mtbIn6.Text);
                lblOut3.Text = res3.ToString();
            }
            else if (cbIn3.Text == "-")
            {
                res3 = Convert.ToDecimal(mtbIn5.Text) - Convert.ToDecimal(mtbIn6.Text);
                lblOut3.Text = res3.ToString();
            }
            else if (cbIn3.Text == "/")
            {
                res3 = Convert.ToDecimal(mtbIn5.Text) / Convert.ToDecimal(mtbIn6.Text);
                lblOut3.Text = res3.ToString();
            }
            else if (cbIn3.Text == "*")
            {
                res3 = Convert.ToDecimal(mtbIn5.Text) * Convert.ToDecimal(mtbIn6.Text);
                lblOut3.Text = res3.ToString();
            }

            if (cbIn4.Text == "+")
            {
                res4 = Convert.ToDecimal(mtbIn7.Text) + Convert.ToDecimal(mtbIn8.Text);
                lblOut4.Text = res4.ToString();
            }
            else if (cbIn4.Text == "-")
            {
                res4 = Convert.ToDecimal(mtbIn7.Text) - Convert.ToDecimal(mtbIn8.Text);
                lblOut4.Text = res4.ToString();
            }
            else if (cbIn4.Text == "/")
            {
                res4 = Convert.ToDecimal(mtbIn7.Text) / Convert.ToDecimal(mtbIn8.Text);
                lblOut4.Text = res4.ToString();
            }
            else if (cbIn4.Text == "*")
            {
                res4 = Convert.ToDecimal(mtbIn7.Text) * Convert.ToDecimal(mtbIn8.Text);
                lblOut4.Text = res4.ToString();
            }
            using (StreamWriter swCalcTask = File.AppendText("CalcTask.txt"))
            {
                swCalcTask.WriteLine(lblOut1.Text);
                swCalcTask.WriteLine(lblOut2.Text);
                swCalcTask.WriteLine(lblOut3.Text);
                swCalcTask.WriteLine(lblOut4.Text);
                swCalcTask.Close();
            }
        }
    }
}
