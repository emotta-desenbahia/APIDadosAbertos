using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace APIDadosAbertos.Controllers
{
    [ApiController]
    [Route("[controller]")]



    public class CatalogoController : ControllerBase
    {

        private readonly ILogger<CatalogoController> _logger;

        public CatalogoController(ILogger<CatalogoController> logger)
        {
            _logger = logger;
        }

        public object GetRoot()
        {
            return new
            {
                cnpj = "15.163.587",
                nome = "Desenbahia Agencia de Fomento do Estado da Bahia",
                dataUltimaAtualizacao = "2021-12-16",
                contatoArea = "Gerência de Compliance e Risco",
                contatoEmail = "gcr@desenbahia.ba.gov.br",
                conjuntos = new List<Conjunto>()
                {
                    new Conjunto {
                    @ref = "https://www.bcb.gov.br/htms/dasfn/pilar3/1.2.0/openapi.json",
                    nome = "Relatório de Pilar 3",
                    urlBase = "https://wwws.desenbahia.ba.gov.br/dadosabertos",
                    urlVisualizacao = "https://dados.desenbahia.ba.gov.br/",
                    situacao = "Produção",
                    recursos =  new List<Recurso>()
                    {
                        new Recurso
                        {
                             nome = "OVA - Visão geral do gerenciamento de riscos da instituição",
                             caminhoRecurso = "/ova/{ano}",
                             parametros =  new Parametro()
                             {
                                   nome = "Ano",
                                   valores = new List<string>()
                                   {
                                      "2020"
                                   }
                             },
                             periodicidade = "Anual",
                        }
                    },
                    contatoArea = "Gerência de Compliance e Risco",
                    contatoEmail = "gcr@desenbahia.ba.gov.br"
                    }

                }
            };
        }
    }

}

