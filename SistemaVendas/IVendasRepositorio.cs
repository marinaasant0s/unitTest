using System.Collections.Generic;

namespace SistemaVendas
{
    public interface IVendasRepositorio
    {
        IList<Vendas> BuscarVendas(short mes, short ano);
    }

    public interface ICadastVendedor
    {
        IList <Vendedor> BuscarVendedor(int id );
        
    }
}