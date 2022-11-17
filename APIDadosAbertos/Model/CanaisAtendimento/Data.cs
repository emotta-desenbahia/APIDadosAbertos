using APIDadosAbertos.Model.CanaisAtendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class Data
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Data> data { get; set; }
        public Company company { get; set; }
        public BranchIdentification branchIdentification { get; set; }
        public PostalAddress postalAddress { get; set; }
        public Availability availability { get; set; }
        public List<Phone> phones { get; set; }
        public List<Service> services { get; set; }
        public string lastModified { get; set; }
    }
}
