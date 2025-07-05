using System;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Amazon;
using CSharpIntermediate.Associate_Between_Classes;
using CSharpIntermediate.Associate_Between_Classes.Composition;
using CSharpIntermediate.Classes;
using CSharpIntermediate.Classes_Exercises;
using CSharpIntermediate.Inheritance;
using CSharpIntermediate.Interfaces;
using CSharpIntermediate.Polymorphism;
using CSharpIntermediate.Polymorphism.Exercises;
using CSharpIntermediate.Interfaces.Exercise;
using CSharpIntermediate.Delegates;


namespace CSharpIntermediate
{
    
    class Program
    {

        static void Main()
        {
            // the syntax is: args => expression
            // number => number * number;

            Func<int, int> square = number => number * number;

            //Console.WriteLine(square(6));

            // if no args: () => expression
            // if 1 args: x => expression
            // if 2 or more: (x, y, z) => expression

            const int factor = 5;

            Func<int, int> multiply = n => n * factor;

            //Console.WriteLine(multiply(10));

            /* ---------- */
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
