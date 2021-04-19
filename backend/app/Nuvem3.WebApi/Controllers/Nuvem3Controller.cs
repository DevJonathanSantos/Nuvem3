using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nuvem3.Entities;
using Nuvem3.WebApi.ViewModels;
using System;
using System.Collections.Generic;

namespace Nuvem3.WebApi.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class Nuvem3Controller : ControllerBase
    {
        [HttpGet("buscar")]
        public string Buscar()
        {
            var listaDeClientes = new List<Cliente>
            {
                new Cliente{ Nome="José",Documento= TipoDocumento.Cpf, DataDeNascimento="09/09/1992", Sexo='M',Email="jose.teste@gmail.com",Telefone="1195861195" },
                new Cliente{ Nome="José",Documento= TipoDocumento.Cpf, DataDeNascimento="09/09/1990",Sexo='M',Email="jose.teste@gmail.com",Telefone="11958611958" },
                new Cliente{ Nome="Bianca",Documento= TipoDocumento.RG, DataDeNascimento="09/09/1985",Sexo='F',Email="bianca.teste@gmail.com",Telefone="9547852156" },
                new Cliente{ Nome="Leticia",Documento= TipoDocumento.Cpf, DataDeNascimento="01/01/1999",Sexo='F',Email="leticia.teste@gmail.com",Telefone="11958607051" },
                new Cliente{ Nome="Miriane",Documento= TipoDocumento.Cpf, DataDeNascimento="01/05/2000",Sexo='F',Email="miriane.teste@gmail.com",Telefone="1155554444" },
                new Cliente{ Nome="Barbara",Documento= TipoDocumento.RG, DataDeNascimento="09/09/2000",Sexo='F',Email="barbara.teste@gmail.com",Telefone="1142423636" },
                new Cliente{ Nome="Pedro",Documento= TipoDocumento.Cpf, DataDeNascimento="01/01/1599",Sexo='M',Email="pedro.teste@gmail.com",Telefone="1155554444" },
                new Cliente{ Nome="João",Documento= TipoDocumento.RG, DataDeNascimento="09/09/1980",Sexo='M',Email="joao.teste@gmail.com",Telefone="9547852156" },
                new Cliente{ Nome="Jéssica",Documento= TipoDocumento.Cpf, DataDeNascimento="01/05/2000",Sexo='F',Email="jessica.teste@gmail.com",Telefone="1195874125" },
            };

            var json = JsonConvert.SerializeObject(listaDeClientes);

            return json;
        }

        [HttpPost("editar")]
        public string Editar(ClienteViewModel cliente)
        {
            return null;
        }

        [HttpPost("cadastrar")]
        public string Cadastrar(ClienteViewModel cliente)
        {
            return null;
        }

        [HttpPost("remover")]
        public string Remover(Guid id)
        {
            return null;
        }
    }
}
