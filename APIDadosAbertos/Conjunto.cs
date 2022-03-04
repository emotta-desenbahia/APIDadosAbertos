using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class Conjunto 
    {
        public string @ref { get; set; }
        public string nome { get; set; }
        public string urlBase { get; set; }
        public string urlVisualizacao { get; set; }
        public string situacao { get; set; }
        public List<Recurso> recursos { get; set; }
        public string contatoArea { get; set; }
        public string contatoEmail { get; set; }
    }




}
