using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Polymorphism.Exercises
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public void SetConnectionString(string connection)
        {
            if (String.IsNullOrEmpty(connection))
                throw new InvalidDataException("Connection must not be null or empty.");
            ConnectionString = connection;
        }

        public string GetConnectionString()
        {
            return ConnectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnection : DbConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Open blahblah for SQL: " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close blahblah for SQL: " + ConnectionString);
        }
    }

    public class OracleConnection : DbConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Open blahblah for Oracle: " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close blahblah for Oracle: " + ConnectionString);
        }
    }

    public class DbCommand
    {
        private DbConnection _connection;
        private string _instructions;
        public DbCommand(DbConnection db, string instructions)
        {
            if (String.IsNullOrEmpty(db.ConnectionString))
                throw new ArgumentException("Connection must not be null or empty.");
            if (String.IsNullOrWhiteSpace(instructions))
                throw new ArgumentException("Instruction must not be empty.");
            _connection = db;
            _instructions = instructions;

        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine(_instructions);
            _connection.CloseConnection();

        }
    }
}


