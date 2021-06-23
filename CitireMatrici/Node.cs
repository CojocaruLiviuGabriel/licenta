using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    public class Node
    {
        public int nodeID;
        public List<int> rows;
        public int splitCol;
        public double splitVal;
        public int[] classCounts;
        public int predictedClass;
    }
}
