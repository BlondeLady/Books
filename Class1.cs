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

        public static int GetLeafCount(Book[] books)
        {
            Book[] leafs = new Book[books.Length];
            for (int i = 0; i < books.Length; i++)
                leafs[i] = books[i];
            int x = 0;
            int y = 0;
            int z = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < books.Length - 1; i++)
            { 
                 x = books[0]._pageCount / 2;
                 y = books[1]._pageCount / 2;
                 z = books[2]._pageCount / 2;
                 a = books[3]._pageCount / 2;
                 b = books[4]._pageCount / 2;
                 c = books[5]._pageCount / 2;
            }
            Console.WriteLine($"Количество листов: {x} {y} {z} {a} {b} {c} ");
            return x;
        }

        public static int GetTheMostPagesBook(Book[] books)
        {
            int max = books[0]._pageCount;  
            for (int i = 1; i < books.Length; ++i)
            {
                if (books[i]._pageCount > max) max = books[i]._pageCount;
                Console.WriteLine("Книга с наибольшим количеством листов: " + max);
            }
            return max;
        }
    }


}
