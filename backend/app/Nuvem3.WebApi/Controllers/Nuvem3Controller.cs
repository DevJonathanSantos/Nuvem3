using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nuvem3.Entities;
using System.Collections.Generic;

namespace Nuvem3.WebApi.Controllers
{
    [Route("api/teste")]
    [ApiController]
    public class Nuvem3Controller : ControllerBase
    {
        [HttpGet("get")]
        public string Buscar()
        {
            var listaDeClientes = new List<Cliente>
            {
                new Cliente{ Nome="José",Documento= TipoDocumento.Cpf, DataDeNascimento=09092000,Email="jose.teste@gmail.com",Telefone="119586119587412507051" },
                new Cliente{ Nome="José",Documento= TipoDocumento.Cpf, DataDeNascimento=09092000,Email="jose.teste@gmail.com",Telefone="119586119587412507051" },
                new Cliente{ Nome="Bianca",Documento= TipoDocumento.RG, DataDeNascimento=09092000,Email="bianca.teste@gmail.com",Telefone="9547852156" },
                new Cliente{ Nome="Leticia",Documento= TipoDocumento.Cpf, DataDeNascimento=0101999,Email="leticia.teste@gmail.com",Telefone="11958607051" },
                new Cliente{ Nome="Miriane",Documento= TipoDocumento.Cpf, DataDeNascimento=01052000,Email="miriane.teste@gmail.com",Telefone="1155554444" },
                new Cliente{ Nome="Barbara",Documento= TipoDocumento.RG, DataDeNascimento=09092000,Email="barbara.teste@gmail.com",Telefone="1142423636" },
                new Cliente{ Nome="Pedro",Documento= TipoDocumento.Cpf, DataDeNascimento=0101999,Email="pedro.teste@gmail.com",Telefone="1155554444" },
                new Cliente{ Nome="João",Documento= TipoDocumento.RG, DataDeNascimento=09092000,Email="joao.teste@gmail.com",Telefone="9547852156" },
                new Cliente{ Nome="Jéssica",Documento= TipoDocumento.Cpf, DataDeNascimento=01052000,Email="jessica.teste@gmail.com",Telefone="1195874125" },
            };

            var json = JsonConvert.SerializeObject(listaDeClientes);

            return json;
        }
    }
}
