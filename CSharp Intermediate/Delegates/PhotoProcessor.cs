using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Delegates
{
    public class PhotoProcessor
    {
        //public void Process(string path, PhotoFilterHandler filterHandler)

        public void Process(string path, Action<Photo> filterHandler)

        {
            // System.Action<> // points to a method that returns void
            // System.Func<> // points to a method that returns a value

            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
