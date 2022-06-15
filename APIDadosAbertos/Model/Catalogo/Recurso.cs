using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIDadosAbertos
{
    public class Recurso 
    {
        public string nome { get; set; }
        public string caminhoRecurso { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Parametro parametros { get; set; }
       
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string periodicidade { get; set; }
    }
}
