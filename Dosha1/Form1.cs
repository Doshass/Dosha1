using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            foreach (Klient klient in Klient.Select())
            {


                
                dgvklients.Rows.Add(klient.klient_login, klient.klient_pass);



            }
        }

        private void dgvklients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btDobavit_Click(object sender, EventArgs e)
        {
            new KlientsAddForms(new Klient()).ShowDialog();
            Updatekli
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
