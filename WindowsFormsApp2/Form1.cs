using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(dizi, 0);
            dizi = dizi.OrderBy(x => x).ToArray();
            foreach (string item in dizi)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
