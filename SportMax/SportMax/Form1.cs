using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportMax.com.omerenlicay.dao;
namespace SportMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();

            if(userDAO.loginDelegate(txtKulad.Text, txtSifre.Text))
            {
                anasayfa ana = new anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!");
            }
        }
    }
}
