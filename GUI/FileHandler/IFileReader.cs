using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.FileHandler
{
    public interface IFileReader
    {
        /* 
            Read 3D and image files
            
        */
         void ReadFile(string path);
    }
}
