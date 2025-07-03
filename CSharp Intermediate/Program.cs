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
            //var processor = new PhotoProcessor();

            //processor.Process("photo.jpg");
            //var program = new Program(); // if RemoveRedEye isn't static
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness; // call a method of photo filter, so create an instance of photo filters
            filterHandler += filters.ApplyContrast;
            //filterHandler += program.RemoveRedEye; // if RemoveRedEye isn't static
            filterHandler += RemoveRedEye;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Apply Remove RedEye effect...");
        }
    }
}
