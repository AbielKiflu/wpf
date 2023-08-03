using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.FileHandler
{
    public class StlModel
    {
        public List<Vertex> vertices { get; set; }
    }
}



public class Vertex
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
}