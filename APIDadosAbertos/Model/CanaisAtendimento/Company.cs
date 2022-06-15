using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class Company
    {
        public string name { get; set; }
        public string cnpjNumber { get; set; }
        public List<Branch> branches { get; set; }
    }
}
