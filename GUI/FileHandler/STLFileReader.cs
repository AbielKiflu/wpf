using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
 

namespace GUI.FileHandler
{
    public class STLFileReader : IFileReader
    {
        //public StlModel model;
         
        public  void ReadFile(string path)
        {
            // Check file if it exists

            using(FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {

               
                byte[] numTriangleByte = new byte[4];
                fstream.Seek(80,SeekOrigin.Begin); // skip header
                fstream.Read(numTriangleByte, 0, 4); // get num triangle
                int counter = BitConverter.ToInt32(numTriangleByte, 0);
                for (int i = 0; i < counter; i++)
                {
                    fstream.Seek(12,SeekOrigin.Current);

                    for (int j = 0; j < 3; j++)
                    {
                        byte[] vertexByte = new byte[12];
                        fstream.Read(vertexByte, 0, 12);

                        float x = BitConverter.ToSingle(vertexByte, 0);
                        float y = BitConverter.ToSingle(vertexByte, 4);
                        float z = BitConverter.ToSingle(vertexByte, 8);

                        var vertex=new {x,y,z};
                        Console.WriteLine("x= {0} , y={1} , z={2}", x, y, z);

 
                    }
                }

               
                 
            }

            // handle error
        }
    }
}

