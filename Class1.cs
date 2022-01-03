using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1k2c_1._3_2_
{
  class Book
    {
        private string _title;
        private string _author;
        private int _pageCount;
        private double _price;

        public Book() { }

        public Book(string title, string author, int pageCount, double price)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
            Price = price;
        }

        public string Title
        {
            get => _title;
            set => _title = value != null ? value : "Нет названия книги";
        }

        public string Author
        {
            get => _author;
            set => _author = value != null ? value : "Нет автора";
        }

        public int PageCount
        {
            get => _pageCount;
            set => _pageCount = value != 0 ? value : 0;
        }
        public double Price
        {
            get => _price;
            set => _price = value != 0 ? value : 0;
        }
        public override string ToString() => $"{Title} {Author} {PageCount} {Price}";
        public static Book[] GetTheMostPagesBooks(Book[] books)
        {
            Book[] newOne = new Book[books.Length];
            for (int i = 0; i < books.Length; i++)
                newOne[i] = books[i];
            for (int i = 0; i < books.Length - 1; i++)
            {
                for (int j = i + 1; j < books.Length; j++)
                {
                    if (books[i]._pageCount < books[j]._pageCount)
                    {
                        Book buf = books[i];
                        books[i] = books[j];
                        books[j] = buf;
                    }
                }
            }
            return books;
        }

        public static int GetLeafCount(Book books)
        {
            int x = books.PageCount / 2;
            return x;
        }

        public static Book GetMaxPagesBook(Book[] books)
        {
            int MaxPages = books[0]._pageCount;
            Book MaxPagesBook = books[0];
            for (int i = 1; i < books.Length; ++i)
                if (books[i]._pageCount > MaxPages) 
                    MaxPages = books[i]._pageCount;
            return MaxPagesBook;
        }
    }

    

}
