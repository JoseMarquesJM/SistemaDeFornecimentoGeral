﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FornecimentoGeral.Business.Interfaces;
using FornecimentoGeral.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}