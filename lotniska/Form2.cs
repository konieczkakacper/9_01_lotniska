using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotniska
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            this.label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //zamykanie

        }
    }
}
