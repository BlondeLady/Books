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
        public static Book[] GetTheMostPagesBook(Book[] books)
        {
            Book[] newOne = new Book[books.Length];
            for (int i = 0; i < books.Length; i++)
                newOne[i] = books[i];
            foreach (var g in books)
            {
                if (g.PageCount > pageCount)
                {
                    Array.Resize(ref newOne, newOne.Length - 1);
                    newOne[newOne.Length - 1] = g;
                }
            }
            return newOne;
        }
        public static void GetLeafCount(string title, int pageCount)
        {
            Console.WriteLine($"{title} {pageCount}");
        } 
    }
}