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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (StreamReader srResGet = File.OpenText("CalcTask.txt"))
            {
                string srRes1 = "";
                string srRes2 = "";
                string srRes3 = "";
                string srRes4 = "";
                //while ()
                {
                    
                    
                }
            }
        }
    }
}
