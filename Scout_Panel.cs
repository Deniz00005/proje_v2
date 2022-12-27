using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_v1
{
    public partial class Scout_Panel : Form
    {
        public Scout_Panel()
        {
            InitializeComponent();
        }
        public void passToForm1()
        {
            this.Hide();
            Enterance form1 = new Enterance();
            form1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            passToForm1();
        }

        private void exitBut2_Click(object sender, EventArgs e)
        {
            Enterance form1 = new Enterance();
            this.Close();
            form1.absoluteExit();
            
            
        }
    }
}
