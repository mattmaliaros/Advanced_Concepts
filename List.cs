using System;

namespace Advanced_Concepts
{
   
        public class List
        {
            public void Add(int number)
            {
                Console.WriteLine(number);
                throw new NotImplementedException();
            }

            public int this[int index] => throw new NotImplementedException();
        }
    }
