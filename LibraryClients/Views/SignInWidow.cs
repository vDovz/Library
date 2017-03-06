using DBWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClients
{
    public partial class SingInWinodw : Form
    {
        DBConnector conector = new DBConnector();
        public SingInWinodw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = conector.GetResult(QueryGenerator.ContainsClientName(textLogin.Text));
            if(result.Count == 0)
            {
                MessageBox.Show("Name not found. Try again");
                return;
            }
            var user = result[0].Split(';');
            MainForm form = new MainForm(user[0]);
            form.ShowDialog();//to main form          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewClientWindow form = new NewClientWindow();
            form.ShowDialog();
        }
    }
}
