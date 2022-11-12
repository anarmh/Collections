using Author_type_for_List.Models;
using System;
using System.Collections.Generic;

namespace Author_type_for_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> author = new List<Author>();
            author.Add(new Author{ FullName = "Huseynov Anar", Age = 35 });
            author.Add(new Author{ FullName = "Salmanov Xeyyam", Age = 42 });
            author.Add(new Author{ FullName = "Ehmedov Samir", Age = 51 });
            author.Add(new Author{ FullName = "Aslanov Elvin", Age = 32 });

            var authors = author.FindAll(m => m.Age > 40);
            foreach (var item in authors)
            {
                Console.WriteLine($"{item.FullName} {item.Age}");
            }
        }
    }
}
