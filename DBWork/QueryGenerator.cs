using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWork
{
    public static class QueryGenerator
    {
        public static string GetBooks(string author = "", string genre = "", string year = "")
        {
            string result= @"Select Author, Genre, Year 
                            From Books ";
            string where = GenerateBooksWhereString(author, genre, year);
            result += where;
            return result;
        }

        public static string GetBookId(string author, string genre, string year)
        {
            string result = @"Select Id 
                            From Books ";
            string where = GenerateBooksWhereString(author, genre, year);
            result += where;
            return result;
        }

        public static string AddBook(string author, string genre, string year)
        {
            string result = string.Format(@"Insert Into Books (Author, Genre, Year) 
                                  Values ('{0}', '{1}' ,{2})", author, genre, year);
            return result;
        }

        public static string DeleteBook(string author, string genre, string year)
        {
            string result = ("Delete From Books ");
            string where = GenerateBooksWhereString(author, genre, year);
            result += where;
            return result;
        }

        private static string GenerateBooksWhereString(string author, string genre, string year)
        {
            if (author == "" && genre == "" && year == "")
            {
                return String.Empty;
            } 
            string where = "Where";
            if (author != "")
            {
                where += string.Format(" Author = '{0}' ", author);
            }
            if (genre != "")
            {
                if (where != "Where")
                {
                    where += string.Format(" AND Genre = '{0}' " ,  genre);
                }
                else
                {
                    where += string.Format(" Genre = '{0}' ", genre); ;
                }
            }
            if (year != "")
            {
                if (where != "Where")
                {
                    where += " AND Year = " + year;
                }
                else
                {
                    where += "Year = " + year;
                }
            }
            return where;
        }

        public static string ContainsClientName(string name)
        {
            string result = string.Format("Select * From Client Where Name = '{0}'", name);
            return result;
        }

        public static string GetClientBook(string id)
        {
            string result = string.Format(@"
            Select Author, Genre, Year 
            From Books
            Join BooksToClient On books.ID = BooksToClient.BookId
            Where ClientId = {0}", id);
            return result;
        }

        public static string GetClientHistory(string id)
        {
            string result = string.Format(@"
            Select Author, Genre, Year, ActionType 
            From Books
            Join ClientHistory On books.ID = ClientHistory.BookId
            Where ClientId = {0}", id);
            return result;
        }

        public static string AddNewClient(string name, string year)
        {
            string result = string.Format(@"Insert Into Client (Name, Year) 
                                  Values ('{0}', '{1}' )", name , year);
            return result;
        }

        public static string ClientBorrowBook(string clientId, string bookId)
        {
            string result = string.Format(@"Insert Into BooksToClient (ClientId, BookId) 
                                  Values ('{0}', '{1}')", clientId, bookId);
            return result;
        }

        public static string ClientReturnBook(string clientId, string bookId)
        {
            string result = string.Format(@"Delete From BooksToClient  
                                            Where ClientId = {0} And BookId = {1}", clientId, bookId);
            return result;
        }

        public static string AddToClientHistory(string clientId, string bookId, string actionType)
        {
            string result = string.Format(@"Insert Into ClientHistory(ClientId, BookId, ActionType)
                                  Values({0}, {1} , '{2}')", clientId, bookId, actionType);
            return result;
        }


    }
}
