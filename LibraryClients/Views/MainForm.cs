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
   
    public partial class MainForm : Form
    {
        DBConnector conector = new DBConnector();

        private string _userId;

        public MainForm(string userId)
        {
            _userId = userId;
            InitializeComponent();
            BorrowGrid.ShowGrid(conector.GetResult(QueryGenerator.GetClientBook(_userId)));
            BookGrid.ShowGrid(conector.GetResult(QueryGenerator.GetBooks()));
            gridHistory.ShowGrid(conector.GetResult(QueryGenerator.GetClientHistory(_userId)));
        }

        private void ButonBorrow_Click(object sender, EventArgs e)
        {
            int bookId = GetBookId(textBoxAuthor.Text, textBoxGenre.Text, textBoxYear.Text);
            if(bookId == -1)
            {
                MessageBox.Show("Incorrect argments. Try again.");
                return;
            }
            conector.GetResult(QueryGenerator.ClientBorrowBook(_userId, bookId.ToString()));
            conector.GetResult(QueryGenerator.AddToClientHistory(_userId, bookId.ToString(), "borrow"));
            UpdateGrid();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            int bookId = GetBookId(textBoxAuthor.Text, textBoxGenre.Text, textBoxYear.Text);
            if (bookId == -1)
            {
                MessageBox.Show("Incorrect argments. Try again.");
                return;
            }
            conector.GetResult(QueryGenerator.ClientReturnBook(_userId, bookId.ToString()));
            conector.GetResult(QueryGenerator.AddToClientHistory(_userId, bookId.ToString(), "return"));
            UpdateGrid();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            BookGrid.ShowGrid(conector.GetResult(QueryGenerator.GetBooks()));
        }


        private int GetBookId(string author, string genre, string year)
        {
            string bookId;
            try
            {
                var r = conector.GetResult(QueryGenerator.GetBookId(author, genre, year));
                bookId = r[0];
            }
            catch (Exception)
            {
                return -1;
            }
            return int.Parse(bookId);
        }

        private void UpdateGrid()
        {
            BorrowGrid.ShowGrid(conector.GetResult(QueryGenerator.GetClientBook(_userId)));
            gridHistory.ShowGrid(conector.GetResult(QueryGenerator.GetClientHistory(_userId)));
        }


    }
}
