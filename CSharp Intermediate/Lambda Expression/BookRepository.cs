﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Lambda_Expression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5 },
                new Book() {Title = "Title 2", Price = 8},
                new Book() {Title = "Title 3", Price = 12}
            };
        }
    }
}
