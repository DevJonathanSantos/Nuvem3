using Nuvem3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvem3.Interfaces
{
    public interface IClienteRepository
    {
        public List<Cliente> Buscar();
        public void Adicionar(Cliente cliente);
        public void Editar(Cliente cliente);
        public void Deletar(int Id);
    }
}
