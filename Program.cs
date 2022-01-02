using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1k2c_1._3_2_
{
   class Program
    {static void Main(string[] args)
            {
                Book[] bookList = new Book[]
                {
                new Book("Властелин колец", "Джон Р.М. Толкин", 896, 3000),
                new Book("Гарри Поттер и философский камень", "Дж.К. Роулинг", 223, 2100),
                new Book("Война и мир", "Л.Н. Толстой", 1225, 2450),
                new Book("Кулинария для начинающих", "О.О. Вилкин", 105, 145),
                new Book("С# для чайников", "Д.И. Мюллер", 608, 1500),
                new Book("Математика 6 класс", "Д.Ю. Воронцова", 98, 60),
                };
                foreach (var g in Book.GetTheMostPagesBooks(bookList))
                    Console.WriteLine(g);
                Book.GetTheMostPagesBook(bookList);
                Console.ReadKey();
            }
    }
}
