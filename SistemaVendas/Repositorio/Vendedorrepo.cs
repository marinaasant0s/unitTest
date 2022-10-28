using System;
using System.Collections.Generic;

namespace SistemaVendas
{
    public class VendedorRepositorio 
    {
        
            public IList<Vendedor>  BuscarVendedor(int id )
            {
                return new List<Vendedor>
            {
                new Vendedor
                {
                    ID = 1059,
                    DataCadastr = new DateTime(2021, 05, 02),
                    Nome = "Matheus Trajano",
                    CPF = 70396
                    
                }

            };
            }
        }

    }
