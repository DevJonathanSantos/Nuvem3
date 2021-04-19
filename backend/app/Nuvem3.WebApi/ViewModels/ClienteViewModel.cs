using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuvem3.WebApi.ViewModels
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Documento { get; set; }
        public string DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
