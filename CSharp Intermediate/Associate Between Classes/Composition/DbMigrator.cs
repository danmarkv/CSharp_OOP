using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Associate_Between_Classes.Composition
{
    class DbMigrator_Composition
    {
        private readonly Logger_Composition _logger;

        public DbMigrator_Composition(Logger_Composition logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating...");
        }
    }
}
