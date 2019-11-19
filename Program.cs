using System;

namespace Advanced_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book();

            ////var numbers = new List();
            ////numbers.Add(10);
            //////var temp = numbers[0];
            //////Console.WriteLine(temp);

            ////var books = new BookList();
            ////books.Add(book);
            //var numbers = new GenericList<int>();
            //numbers.Add(10);
            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());

            Console.WriteLine(args.Length);
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }

}