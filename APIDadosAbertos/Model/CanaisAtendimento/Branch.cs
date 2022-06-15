using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class Branch
    {
        public Identification identification { get; set; }
        public PostalAddress postalAddress { get; set; }
        public Availability availability { get; set; }
        //public List<Identification> identifications { get; set; }
        public List<Phone> phones { get; set; }
        public List<Service> services { get; set; }

    }
}
