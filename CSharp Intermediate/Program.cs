using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Amazon;
using CSharpIntermediate.Associate_Between_Classes;
using CSharpIntermediate.Associate_Between_Classes.Composition;
using CSharpIntermediate.Classes;
using CSharpIntermediate.Classes_Exercises;


namespace CSharpIntermediate
{
    
    
    class Program
    {
        
        static void Main()
        {
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();

        }
    }
}
