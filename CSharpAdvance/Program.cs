﻿using System;

namespace CSharpAdvance
{
    // where T : IComparable
    // where T : Product
    // Where T : Struct
    // Where T : Class
    // Where T : new
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book{Isbn = "1111", Title = "C# Advance"};

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: "+ number.GetValueOrDefault());
            // 6. Generics and constraints
        }
    }
}
