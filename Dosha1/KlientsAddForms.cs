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
    public partial class KlientsAddForms : Form
    {
        Klient EditKlient; 
        public KlientsAddForms( Klient klient )
        {
            this.EditKlient = klient;
            InitializeComponent();

            tbLogin.Text = klient.klient_login;
            tbName.Text = klient.klient_name;
            tbPass.Text = klient.klient_pass;
            tbPhone.Text = klient.klient_phone.ToString(); 

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (EditKlient.Idklient == 0)
                Klient.Add(tbPass.Text, tbLogin.Text, tbName.Text, Convert.ToUInt64(tbPhone.Text));

            else
                EditKlient.change (tbPass.Text, tbLogin.Text, tbName.Text, Convert.ToUInt64(tbPhone.Text));

            Console.WriteLine("test");
            
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
