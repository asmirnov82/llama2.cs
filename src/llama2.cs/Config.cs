using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace llama2.cs
{
    // Transformer and RunState structs, and related memory management
    [StructLayout(LayoutKind.Sequential)]
    internal struct Config
    {
        public int dim; // transformer dimension
        public int hidden_dim; // for ffn layers
        public int n_layers; // number of layers
        public int n_heads; // number of query heads
        public int n_kv_heads; // number of key/value heads (can be < query heads because of multiquery)
        public int vocab_size; // vocabulary size, usually 256 (byte-level)
        public int seq_len; // max sequence length
    }
}
