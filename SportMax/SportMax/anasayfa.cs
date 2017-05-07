using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SportMax.com.omerenlicay.dao;
namespace SportMax
{
    public partial class anasayfa : Form
    {
        DataTable dataTable;
        DataViewDAO dataViewDAO;
        public anasayfa()
        {
            InitializeComponent();
        }



        private void filterData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterData.SelectedIndex == 0)
            {
                tariheGoreYeni();
            }
            else if (filterData.SelectedIndex == 1)
            {
                tariheGoreEski();
            }
            else if (filterData.SelectedIndex == 2)
            {
                borcuOlan();
            }
            else if (filterData.SelectedIndex == 3)
            {
                kaydiBiten();
            }
            else if (filterData.SelectedIndex == 4)
            {
                bayanUye();
            }
            else if (filterData.SelectedIndex == 5)
            {
                erkekUye();
            }
            else
            {
                kaydiDonduran();
            }
           
        }

        private void tariheGoreYeni()
        {
            dataViewDAO = new DataViewDAO();
        }

        private void tariheGoreEski()
        {
            dataViewDAO = new DataViewDAO();
        }

        private void borcuOlan()
        {
            dataViewDAO = new DataViewDAO();
        }

        private void kaydiBiten()
        {
            dataViewDAO = new DataViewDAO();
        }

        private void bayanUye()
        {
            dataViewDAO = new DataViewDAO();
        }

        private void erkekUye()
        {
            dataViewDAO = new DataViewDAO();
        }

        private void kaydiDonduran()
        {
            dataViewDAO = new DataViewDAO();
        }


        private void viewData(MySqlDataAdapter da, DataGridView view)
        {
            using (dataTable = new DataTable())
            {
                da.Fill(dataTable);
                view.DataSource = dataTable;
            }
        }

        private void anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



       
    }
}
