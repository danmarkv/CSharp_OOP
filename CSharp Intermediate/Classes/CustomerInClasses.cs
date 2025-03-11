using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Classes
{

    public class CustomerInClasses
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public CustomerInClasses(int id)
        {
            this.Id = id;
        }

        public CustomerInClasses(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // ...
        }
    }
}
