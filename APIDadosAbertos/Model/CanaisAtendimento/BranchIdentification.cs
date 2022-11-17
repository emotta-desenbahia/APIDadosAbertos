using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos.Model.CanaisAtendimento
{
    public class BranchIdentification
    {
        public string type { get; set; }
        public string cnpjNumber { get; set; }
        public string code { get; set; }
        public string checkDigit { get; set; }
        public string name { get; set; }
        public string openingDate { get; set; }
        
    }
}
