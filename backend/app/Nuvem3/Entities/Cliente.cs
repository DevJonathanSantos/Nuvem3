using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvem3.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public TipoDocumento Documento { get; set; }
        public string DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }

    public enum TipoDocumento
    {
        Cpf,
        RG
    }
}
