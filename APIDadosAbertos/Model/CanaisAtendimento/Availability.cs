using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class Availability
    {
        public List<Standard> standards { get; set; }
        public string exception { get; set; }
        public bool isPublicAccessAllowed { get; set; }
    }
}
