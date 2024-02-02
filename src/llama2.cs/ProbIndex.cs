using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llama2.cs
{
    /// <summary>
    ///     Used in top-p sampling
    /// </summary>
    internal struct ProbIndex
    {
        public float Prob;
        public int Index;
    }
}
