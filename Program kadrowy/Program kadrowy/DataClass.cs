using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_kadrowy
{
    public class DataClass
    {
        public int Num { get; set; }
        public string Str { get; set; }

        public DataClass(int num, string str)
        {
            this.Num = num;
            this.Str = str;
        }
    }
}
