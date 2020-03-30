using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS221_Starter_Code
{
    class Book
    {
        private string isbn;
        private string title;
        private Author author;

        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            this.isbn = tempIsbn;
            this.title = tempTitle;
            this.author = tempAuthor;
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public Author GetAuthor()
        {
            return author;
        }

        public void SetAuthor(Author author)
        {
            this.author = author;
        }

        public string ToString()
        {
            string temp = string.Format("isbn = " + isbn + ", title =  " + title + ", author: " + author.ToString());
            return temp;
        }
    }
}
