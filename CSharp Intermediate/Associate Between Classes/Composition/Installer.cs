using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Associate_Between_Classes.Composition
{
    class Installer
    {
        private readonly Logger_Composition _logger;

        public Installer(Logger_Composition logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing...");
        }
    }
}
