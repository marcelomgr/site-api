using System;
using System.Linq;
using DefaultAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


public class UnidadesMedidaDistanciaBusiness
{
    private readonly MeuDbContext _context;

    public UnidadesMedidaDistanciaBusiness(MeuDbContext context)
    {
        _context = context;
    }

    public List<UnidadesMedidaDistancia> GetAllUnidadesMedidaDistancia()
    {
        List<UnidadesMedidaDistancia> retorno;

        try
        {
            List<UnidadesMedidaDistancia> unidadesMedida = new List<UnidadesMedidaDistancia>
            {
                new UnidadesMedidaDistancia { ID = 1, Sigla = "km", Nome = "Quilômetro" },
                new UnidadesMedidaDistancia { ID = 2, Sigla = "m" , Nome = "Metro" },
                new UnidadesMedidaDistancia { ID = 3, Sigla = "dm", Nome = "Decímetro" },
                new UnidadesMedidaDistancia { ID = 4, Sigla = "cm", Nome = "Centímetro" },
                new UnidadesMedidaDistancia { ID = 5, Sigla = "mm", Nome = "Milímetro" },
                new UnidadesMedidaDistancia { ID = 6, Sigla = "µm", Nome = "Micrômetro" },
                new UnidadesMedidaDistancia { ID = 7, Sigla = "nm", Nome = "Nanômetro" },
                new UnidadesMedidaDistancia { ID = 8, Sigla = "Å" , Nome = "Angstrom" }
            };

            //var unidadesMedidaDistancia = _context.UnidadesMedidaDistancia.ToList();

            retorno = unidadesMedida;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return retorno;
    }
}