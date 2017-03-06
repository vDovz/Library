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
    public partial class NewClientWindow : Form
    {
        DBConnector conector = new DBConnector();
        public NewClientWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textLogin.Text) || string.IsNullOrWhiteSpace(textYear.Text))
            {
                MessageBox.Show("One or more value is empty. Try again");
                return;
            }
            try
            {
                conector.GetResult(QueryGenerator.AddNewClient(textLogin.Text, textYear.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect name. Try another name");
                return;
            }
            MainForm form = new MainForm(textLogin.Text);
            form.ShowDialog();
        }
    }
}
