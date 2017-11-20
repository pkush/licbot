using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot_1
{
    [Serializable]
    public class LICpolicy
    {
        public Int32 id { get; set; }
        public string name { get; set; }

        public string plan { get; set; }

        public string entryAge { get; set; }

        public string
            minSumAssured { get; set; }

        public string status { get; set; }

        public string minPremium { get; set; }

        public string image { get; set; }

        public string maturityDate { get; set; }
    }
}


