using System;
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
using CSharpIntermediate.Polymorphism;
using CSharpIntermediate.Polymorphism.Exercises;


namespace CSharpIntermediate
{
    class Program
    {

        static void Main()
        {
            var sql = new SqlConnection();
            sql.SetConnectionString("dotacsgo");

            var oracle = new OracleConnection();
            oracle.SetConnectionString("valomlbb");

            var dbsql = new DbCommand(oracle, "Run the program");
            dbsql.Execute();
        }
    }
}
