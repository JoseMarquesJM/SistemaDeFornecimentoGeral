using FornecimentoGeral.Business.Interfaces;
using FornecimentoGeral.Business.Models;
using FornecimentoGeral.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornecimentoGeral.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ContextDb contextDb):base(contextDb) { }
            
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(f=> f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(e => e.Endereco)
                .Include(e => e.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
