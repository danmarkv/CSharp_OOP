﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness...");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast...");
        }

        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Resize photo...");
        }
    }
}
