using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Parsing_in_C_Sharp
{
    class RootObject
    {
        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public string WHO { get; set; }
            public WEEK[] WEEK { get; set; }
        }

        public class WEEK
        {
            public int NUMBER { get; set; }
            public EXPENSE[] EXPENSE { get; set; }
        }

        public class EXPENSE
        {
            public string WHAT { get; set; }
            public float AMOUNT { get; set; }
        }
    }
}
