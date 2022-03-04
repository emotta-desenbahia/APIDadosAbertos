using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class Recurso 
    {
        public string nome { get; set; }
        public string caminhoRecurso { get; set; }
        public Parametro parametros { get; set; }
        public string periodicidade { get; set; }
    }
}
