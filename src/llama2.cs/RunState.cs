using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace llama2.cs
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct RunState
    {
        // current wave of activations
        public float[] x; // activation at current time stamp (dim,)
        public float[] xb; // same, but inside a residual branch (dim,)
        public float[] xb2; // an additional buffer just for convenience (dim,)
        public float[] hb; // buffer for hidden dimension in the ffn (hidden_dim,)
        public float[] hb2; // buffer for hidden dimension in the ffn (hidden_dim,)
        public float[] q; // query (dim,)
        public float[] k; // key (dim,)
        public float[] v; // value (dim,)
        public float[] att; // buffer for scores/attention values (n_heads, seq_len)
        public float[] logits; // output logits

        public ProbIndex[] probindex; // buffer used in top-p sampling

        // kv cache
        public float[] key_cache; // (layer, seq_len, dim)
        public float[] value_cache; // (layer, seq_len, dim)
    }
}
