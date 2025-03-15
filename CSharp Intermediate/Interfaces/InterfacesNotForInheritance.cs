using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Interfaces
{
    class InterfacesNotForInheritance : UiControl, IDraggable, IDroppable // INFI inhertis base class UiControl; INFI implements the interfaces
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public interface IDroppable
    {
        void Drop();
    }

    public interface IDraggable
    {
        void Drag();
    }

    public class UiControl
    {
        public string Id { get; set; }

    }

    
}
