using Nuvem3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvem3.Interfaces
{
    public interface IClienteService
    {
        public List<Cliente> Buscar();
        public void Adicionar(Cliente cliente);
        public void Editar(Cliente cliente);
        public void Deletar(int Id);
    }
}
