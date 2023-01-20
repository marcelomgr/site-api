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
        List<UnidadesMedidaDistancia> retorno = new List<UnidadesMedidaDistancia>();

            try
            {
                var unidadesMedidaDistancia = _context.UnidadesMedidaDistancia.ToList();

                retorno = unidadesMedidaDistancia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        return retorno;
    }
}