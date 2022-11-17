
using APIDadosAbertos.Model.CanaisAtendimento;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDadosAbertos.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CanaisAtendimentoController : ControllerBase
    {

        private readonly ILogger<CanaisAtendimentoController> _logger;

        public CanaisAtendimentoController(ILogger<CanaisAtendimentoController> logger)
        {
            _logger = logger;
        }

        [Route("branches")]
        public object GetData()
        {

            return new
            {
                data = new List<Data>()
                        {
                            new Data
                            {

                    company = new Company()
                    {
                        name = "Desenbahia - Agência de Fomento do Estado da Bahia S.A.",
                        cnpjNumber = "15163587",
                        compeCode = "000",
                        brand = "Desenbahia - Agência de Fomento do Estado da Bahia S.A.",
                    },

                    branchIdentification = new BranchIdentification()
                    {
                        type = "AGENCIA",
                        cnpjNumber = "15163587000127",
                        code = "0001",
                        checkDigit = "1",
                        name = "Salvador",
                        openingDate = "2001-09-17"
                    },

                    postalAddress = new PostalAddress()
                    {
                        address = "Rua Ivonne Silveira",
                        number = "213",
                        districtName = "Narandiba",
                        townName = "Salvador",
                        ibgeCode = "2927408",
                        countrySubDivision = "BA",
                        postCode = "41192-007",
                        country = "Brasil",
                        countryCode = "BRA",
                        geographicCoordinates = new GeographicCoordinates()
                        {
                            latitude = "-12.966246",
                            longitude = "-38.439370",
                        }
                    },

                    availability = new Availability()
                    {
                        standards = new List<Standard>()
                        {
                            new Standard
                            {
                                weekday = "SEGUNDA_FEIRA",
                                openingTime = "11:00:00Z",
                                closingTime = "17:00:00Z"
                            },
                            new Standard
                            {
                                weekday = "TERCA_FEIRA",
                                openingTime = "11:00:00Z",
                                closingTime = "17:00:00Z"
                            },
                            new Standard
                            {
                                weekday = "QUARTA_FEIRA",
                                openingTime = "11:00:00Z",
                                closingTime = "17:00:00Z"
                            },
                            new Standard
                            {
                                weekday = "QUINTA_FEIRA",
                                openingTime = "11:00:00Z",
                                closingTime = "17:00:00Z"
                            },
                            new Standard
                            {
                                weekday = "SEXTA_FEIRA",
                                openingTime = "11:00:00Z",
                                closingTime = "17:00:00Z"
                            }
                        },
                        exception = "Exceto feriados municipal, estadual e nacional",
                        isPublicAccessAllowed = true
                    },

                    phones = new List<Phone>()
                    {
                        new Phone
                        {
                            type = "FIXO",
                            countryCallingCode = "55",
                            areaCode = "71",
                            number = "31031001"
                        }
                    },
                    services = new List<Service>()
                    {
                        new Service
                        {
                            name = "OPERACOES_CREDITO_BEM_COMO_OUTROS_SERVICOS_PRESTADOS_ACOMPANHAMENTO_OPERACAO",
                            code = "OPERA_CREDITO_OUTROS_SERVICOS_ACOMPANHA_OPERACAO"
                        },
                        new Service
                        {
                            name = "INFORMACOES",
                            code = "INFORMACOES"
                        },
                        new Service
                        {
                            name = "RECLAMACOES",
                            code = "RECLAMACOES"
                        }
                    },


                       lastModified = "2022-10-14T12:00:00Z"
                   }
                },
                                                    
                links = new Links()
                {

                    self = "https://wwws.desenbahia.ba.gov.br/dadosabertos/canaisatendimento/branches",
                    first = "https://wwws.desenbahia.ba.gov.br/dadosabertos/canaisatendimento/branches",
                    prev = "null",
                    next = "null",
                    last = "https://wwws.desenbahia.ba.gov.br/dadosabertos/canaisatendimento/branches"

                },

                meta = new Meta()
                {
                    totalRecords = 1,
                    totalPages = 1
                }
            };
        }

    }
}


        

















       
          



     
        
         