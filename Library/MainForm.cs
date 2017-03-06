using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBWork;

namespace Library
{
    public partial class PersonalForm : Form
    {
        DBConnector conector = new DBConnector();
        public PersonalForm()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchGrid.Rows.Clear();
            var res = conector.GetResult(QueryGenerator.GetBooks(TextBoxAuthor.Text, TextBoxGenre.Text, TextBoxYear.Text));
            SearchGrid.AddToGrid(res);             
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxAuthor.Text == "" || TextBoxGenre.Text == "" || TextBoxYear.Text == "")
            {
                MessageBox.Show(" Bad arguments");
                return;
            }
            conector.GetResult(QueryGenerator.AddBook(TextBoxAuthor.Text, TextBoxGenre.Text, TextBoxYear.Text));
            MessageBox.Show(" Successful add");
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            conector.GetResult(QueryGenerator.DeleteBook(TextBoxAuthor.Text, TextBoxGenre.Text, TextBoxYear.Text));
            MessageBox.Show(" Successful remove");
        }
    }
}
