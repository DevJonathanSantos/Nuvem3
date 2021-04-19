using System;
using System.Collections.Generic;

#nullable disable

namespace Nuvem3.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string DataDeNascimento { get; set; }
        public string Sexo { get; set; }
    }
}
