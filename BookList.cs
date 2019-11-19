using System;

namespace Advanced_Concepts
{
    public class BookList
    {
        public void Add(Book book)
        {
            book.Price = 5;
            throw new NotImplementedException();
        }

        public Book this[int index] => throw new NotImplementedException();

        //public class ObjectList
        //{
        //    public void Add(object value)
        //    {

        //    }

        //    public object this[int index]
        //    {
        //        get { throw new NotImplementedException(); }
        //    }
        //}
    }

}