using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIDadosAbertos
{

    public class Parametro 
    {
        public string nome { get; set; }
        public List<string> valores { get; set; }
    }

}
