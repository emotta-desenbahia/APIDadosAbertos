using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class PostalAddress
    {
        public string address { get; set; }
        public string districtName { get; set; }
        public string townName { get; set; }
        public string ibgeCode { get; set; }
        public string countrySubDivision { get; set; }
        public string postCode { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public GeographicCoordinates geographicCoordinates { get; set; }
    }
}
