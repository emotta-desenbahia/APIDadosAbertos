using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace APIDadosAbertos
{
    public class Root
    {
        public string cnpj { get; set; }
        public string nome { get; set; }
        public string dataUltimaAtualizacao { get; set; }
        public string contatoArea { get; set; }
        public string contatoEmail { get; set; }
        public List<Conjunto> conjuntos { get; set; }
        

    }


}


