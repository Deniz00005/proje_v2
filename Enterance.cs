using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje_v1
{
    public partial class Enterance : Form
    {
        private System.Windows.Forms.TextBox _userNameTxt;
        private System.Windows.Forms.TextBox _passwordTxt;
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\thebl\\Desktop\\Database711.accdb");
        OleDbDataReader dr = null;
        OleDbCommand com;

        public Enterance()
        {
            InitializeComponent();
            _userNameTxt = new System.Windows.Forms.TextBox();
            _passwordTxt = new System.Windows.Forms.TextBox();

            Controls.Add(_userNameTxt);
            Controls.Add(_passwordTxt);

             
        }
        public void absoluteExit()
        {
            this.Close();
        }

        public void passToForm2()
        {
            this.Hide();
            Scout_Panel form2 = new Scout_Panel();
            form2.ShowDialog();
        }        

        private void enterBut_Click(object sender, EventArgs e)
        {
            Enterance form = new Enterance();
            if (adminBut.Checked == true)
            {
                con.Open();
                string user = userNameTxt.Text;
                string password = passwordTxt.Text;
                com=new OleDbCommand("Select*From admin where admin_no=" + user + " And admin_sifre='" + password + "'", con);
                com.ExecuteNonQuery();
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler Giriş Başarılı");
                    passToForm2();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                }

            }
            if (scoutBut.Checked == true)
            {
                con.Open();
                string user = userNameTxt.Text;
                string password = passwordTxt.Text;
                com = new OleDbCommand("Select*From scout where scout_no=" + user + " And scout_sifre=" + password + "", con);
                com.ExecuteNonQuery();
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler Giriş Başarılı");
                    passToForm2();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                }

            }
        }
        public void connect()
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\thebl\\Desktop\\Database711.accdb");
            con.Open();
        }
        public void disconnect()
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\thebl\\Desktop\\Database711.accdb");
            con.Close();
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    


