using System;
using System.Linq;

namespace SistemaVendas
{
    public class VendedorNegocio 
    {
        private ICadastVendedor _cadastvend;

        public VendedorNegocio (ICadastVendedor cadastvend)
        {
            _cadastvend = cadastvend;

        }

        public int Nomevendedor(short ID )
        {
            var vendedor = _cadastvend.BuscarVendedor(ID);

            var id = vendedor;
            
            return ;
        }

    }
}